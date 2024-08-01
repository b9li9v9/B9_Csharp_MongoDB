
using Microsoft.VisualBasic;

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
    /// <summary>
    /// 不支持同一个账户多端登陆，这样数据库批量修改乱套了  单条修改只需每次操作先读取一次
    /// OrgName允许同名 因为Guid是唯一的  并且例如许多组织叫  “行政部...”  是很正常的事情
    /// Owner允许转移 转移后默认为False 需要接收者手动接收后为True
    /// </summary>
    public partial class FormIndexManagerSettingRootNote : Form
    {
        private List<OrgUnit> OrgUnitsTable;
        private SC_DbContext SC_DB;
        public FormIndexManagerSettingRootNote()
        {
            InitializeComponent();
        }

        //private void FormIndexManagerSettingLoadSelfRootNote_Load(object sender, EventArgs e)
        //{
        //    this.dataGridView1.DataSource = OrgUnitsTable;
        //}

        // 获取数据库表
        private List<OrgUnit> GetTable()
        {
            return SC_DB.OrgUnits.Where(o => o.OwnerId == FormsManager.UserId && o.ParentGuid == null).ToList();
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
            button3_Click(null, null);
        }

        // 删除  --> 这边还少了个操作 懒得写了  要递归删除子节点 因为根已经消失了 
        private void button2_Click(object sender, EventArgs e)
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
                        // 如果用户更改了owner却没保存
                        if (orgUnit.OwnerId != FormsManager.UserId)
                        {
                            MessageBox.Show("请先保存修改 再尝试删除");
                            button3_Click(null, null);
                            return;
                        }
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
            button3_Click(null, null);
        }

        // 查询
        private void button3_Click(object sender, EventArgs e)
        {
            if (SC_DB != null) SC_DB.Dispose();
            SC_DB = new SC_DbContext();
            OrgUnitsTable = GetTable();
            this.dataGridView1.DataSource = OrgUnitsTable;
            this.dataGridView1.DataError += dataGridView1_DataError;
            //this.dataGridView1.AllowUserToAddRows = true;
            //this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        // 注册
        private void btnRegistered_Click(object sender, EventArgs e)
        {
            button3_Click(null, null);

            OrgUnit orgunit = new OrgUnit();
            Guid giud = new Guid();
            orgunit.Guid = giud;
            orgunit.EmpName = "default";
            orgunit.OrgName = "default";
            orgunit.OwnerId = FormsManager.UserId;
            orgunit.AV = true;

            SC_DB.OrgUnits.Add(orgunit);
            SC_DB.SaveChanges();

            button3_Click(null, null);

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

        // 接收节点
        private void button4_Click(object sender, EventArgs e)
        {
            if (SC_DB == null) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // 检查每一行
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    // 获取单元格所在的行
                    DataGridViewRow row = cell.OwningRow;

                    // 获取与行关联的数据源对象
                    if (row.DataBoundItem is OrgUnit orgUnit)
                    {
                        // 如果用户更改了owner却没保存
                        if (orgUnit.OwnerId != FormsManager.UserId)
                        {
                            MessageBox.Show("请先保存修改 再尝试删除");
                            button3_Click(null, null);
                            return;
                        }
                        // 现在可以直接使用 orgUnit 对象来操作数据，而不需要深拷贝
                        // 例如：
                        orgUnit.AV = true;
                        //MessageBox.Show($"{dataGridView1.SelectedCells.Count}");
                        // 对 orgUnit 做其他操作...
                    }
                }
                SC_DB.SaveChanges();
            }
            button3_Click(null, null);

        }
    }
}
