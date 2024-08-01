
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
    public partial class FormIndexManagerSettingSelfNode : Form
    {
        private List<OrgUnit> OrgUnitsTable;
        private SC_DbContext SC_DB;
        public FormIndexManagerSettingSelfNode()
        {
            InitializeComponent();
        }

        //private void FormIndexManagerSettingLoadSelfNote_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = GetSqlData();
        //}


        // 获取表数据
        private List<OrgUnit> GetTable()
        {
            return SC_DB.OrgUnits.Where(o => o.OwnerId == FormsManager.UserId && o.ParentGuid != null).ToList();
        }

        // 错误类型检测
        // dataerror
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

        // 查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (SC_DB != null) SC_DB.Dispose();
            SC_DB = new SC_DbContext();
            OrgUnitsTable = GetTable();
            this.dataGridView1.DataSource = OrgUnitsTable;
            this.dataGridView1.DataError += dataGridView1_DataError;
        }

        // 加入父节点
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            this.btnQuery_Click(null, null);

            var result = SC_DB.OrgUnits.FirstOrDefault(o => o.Guid.ToString() == this.txParentNode.Text);
            //Debug.WriteLine(result.ParentGuid.ToString());
            if (result != null)
            {
                OrgUnit orgunit = new OrgUnit();
                Guid guid = new Guid();
                orgunit.Guid = guid;
                orgunit.EmpName = "default";
                orgunit.OrgName = "default";
                orgunit.OwnerId = FormsManager.UserId;
                orgunit.ParentGuid = result.Guid;
                SC_DB.OrgUnits.Add(orgunit);
                SC_DB.SaveChanges();

            }
            else
            {
                MessageBox.Show("不存在此父节点");
            }

            this.btnQuery_Click(null, null);
            //if (txParentNode.Text)
        }

        // 修改
        private void btnUpData_Click(object sender, EventArgs e)
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

        // 删除节点  
        // 这里的删除不是软删除  也不是真删除  而是把归属权还给父节点
        private void btnSignOutNode_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // 获取用户框选列
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    // 获取单元格所在的行
                    DataGridViewRow row = cell.OwningRow;

                    // 获取与行关联的数据源对象
                    if (row.DataBoundItem is OrgUnit orgUnit)
                    {
                        // 当前对象父节点的对象  节点归属权移交给父节点
                        var parentorgunit = SC_DB.OrgUnits.FirstOrDefault(o=>o.Guid == orgUnit.ParentGuid);
                        orgUnit.AV = false;
                        orgUnit.OwnerId = parentorgunit.OwnerId;
                    }

                }
                SC_DB.SaveChanges();
                // 删除选中行
            }
            btnQuery_Click(null, null);
        }
    }

}
