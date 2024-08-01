
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_Forms
{
    public partial class FormIndexManagerSettingChildNode : Form
    {
        private List<OrgUnit> OrgUnitsTable;
        private SC_DbContext SC_DB;
        public FormIndexManagerSettingChildNode()
        {
            InitializeComponent();
        }


        // 获取数据库表
        private List<OrgUnit> GetTable()
        {
            // 1.先获得账户所有持有的节点
            // 2.再将 所有 1 的子节点找出

            List<OrgUnit> MyNode = SC_DB.OrgUnits.Where(o => o.OwnerId == FormsManager.UserId).ToList();
            List<OrgUnit> AllNode = SC_DB.OrgUnits.ToList();

            var resultShow = AllNode
                .Where(allnode => MyNode
                .Any(mynode => allnode.ParentGuid == mynode.Guid)).ToList();
            Debug.WriteLine(resultShow);
            return resultShow;
        }


        // 查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (SC_DB != null) SC_DB.Dispose();
            SC_DB = new SC_DbContext();
            OrgUnitsTable = GetTable();
            this.dataGridView1.DataSource = OrgUnitsTable;
            this.dataGridView1.DataError += dataGridView1_DataError;
        }

        // 类型错误防止
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取消默认的错误处理
            e.Cancel = true;

            // 获取出错的单元格信息
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // 自定义错误处理逻辑示例
            MessageBox.Show($"在行 {e.RowIndex + 1}，列 {cell.ColumnIndex + 1} 处发生数据错误：{e.Exception.Message}",
                            "数据错误",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            //this.dataGridView1.DataSource = null;
            //button3_Click(null, null);

            // 可以根据需要执行其他的错误处理逻辑，例如记录日志
            // Logger.Log($"数据错误：{e.Exception.Message}");
        }

        // 修改
        private void button1_Click(object sender, EventArgs e)
        {
            if (SC_DB == null) return;

            // 事务
            using (var transaction = SC_DB.Database.BeginTransaction())
            {
                try
                {
                    foreach (var orgUnit in OrgUnitsTable)
                    {
                        var entry = SC_DB.Entry(orgUnit);

                        // 根据实体状态处理相应操作 这里实际上只用到修改                     
                        if (entry.State == EntityState.Modified)
                        {

                            // 归属权转移 合法性为false
                            if (orgUnit.OwnerId != FormsManager.UserId)
                            {
                                orgUnit.AV = false;
                            }
                            Debug.WriteLine(entry.State.ToString() + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            //SC_DB.SaveChanges();

                            // BUG细节
                            // 第一个 SaveChanges() 被调用后，
                            // 所有状态为 Modified、Added、Deleted 的实体对象的状态会被更新到数据库，
                            // 并且它们的状态将被重置为 Unchanged。SC_DB.SaveChanges();


                        }
                        else if (entry.State == EntityState.Added)
                        {
                            // 处理新增状态的实体对象
                            //MessageBox.Show($"OrgUnit {orgUnit.Guid} is added.");
                            Debug.WriteLine(entry.State.ToString() + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                        else if (entry.State == EntityState.Deleted)
                        {
                            // 处理删除状态的实体对象
                            //MessageBox.Show($"OrgUnit {orgUnit.Guid} is deleted.");
                            Debug.WriteLine(entry.State.ToString() + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                        else
                        {
                            // 处理未更改状态的实体对象
                            //MessageBox.Show($"OrgUnit {orgUnit.Guid} is unchanged.");
                            Debug.WriteLine(entry.State.ToString() + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                    }
                    SC_DB.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // 如果出现异常，则回滚事务
                    transaction.Rollback();
                    MessageBox.Show($"提交失败 事务回滚：{ex.Message}");
                }
            }
            btnQuery_Click(null, null);
        }

        // 接收节点
        private void button4_Click(object sender, EventArgs e)
        {
            if (SC_DB == null) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                Debug.WriteLine(dataGridView1.SelectedCells.Count);
                // 检查每一行
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    // 获取单元格所在的行
                    DataGridViewRow row = cell.OwningRow;

                    // 获取与行关联的数据源对象
                    if (row.DataBoundItem is OrgUnit orgUnit)
                    {
                        // 现在可以直接使用 orgUnit 对象来操作数据，而不需要深拷贝
                        // 例如：
                        orgUnit.AV = true;
                        //MessageBox.Show($"{dataGridView1.SelectedCells.Count}");
                        // 对 orgUnit 做其他操作...
                    }
                }
                SC_DB.SaveChanges();
            }
            btnQuery_Click(null, null);

        }

        // 删除节点
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                
                // 获取用户框选列
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    Debug.WriteLine(dataGridView1.SelectedCells.Count.ToString());
                    // 获取单元格所在的行
                    DataGridViewRow row = cell.OwningRow;

                    // 获取与行关联的数据源对象
                    if (row.DataBoundItem is OrgUnit orgUnit)
                    {
                        // 现在可以直接使用 orgUnit 对象来操作数据，而不需要深拷贝
                        // 例如：
                        orgUnit.IsDeleted = true;
                        //MessageBox.Show($"{dataGridView1.SelectedCells.Count}");
                        // 对 orgUnit 做其他操作...
                    }

                }
                SC_DB.SaveChanges();
                // 删除选中行
            }
            btnQuery_Click(null, null);
        }
    }
}
