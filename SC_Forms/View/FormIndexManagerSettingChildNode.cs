
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    public partial class FormIndexManagerSettingChildNode : Form
    {
		private IMongoCollection<OrgUnit> OrgUnitsCollection = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<OrgUnit>("OrgUnits");
		private IMongoCollection<User> UsersCollection = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<User>("Users");
		private List<OrgUnit> OrgUnitsTable = null;
		public FormIndexManagerSettingChildNode()
        {
            InitializeComponent();
        }


        // 获取数据库表
        private List<OrgUnit> GetTable()
        {
            // 1.先获得账户所有持有的节点
            var leaderNodeTable = OrgUnitsCollection.AsQueryable()
                                                .Where(o => o.OwnerId == FormsHelper.UserId && o.IsDeleted == false).ToList();

			var leaderNodeIds = leaderNodeTable.Select(o => o.OrgUnitId).ToList();

            // 2.检查哪些子节点是该账户的  这样效率很慢 可以拆成多张表。
			return OrgUnitsCollection.AsQueryable()
	                                    .Where(x => leaderNodeIds.Contains(x.ParentId))
	                                    .Where(x => x.IsDeleted == false) // Add additional conditions here
	                                    .Where(x => x.ParentId != null)
                                        .ToList();
		}


		// 查询√
		private void btnQuery_Click(object sender, EventArgs e)
        {
            this.OrgUnitsTable = GetTable();
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
            // 先检查是否转移操作，如果是合法性为false
        }

		// 授权√
		private void button4_Click(object sender, EventArgs e)
        {
            if(this.OrgUnitsTable == null) btnQuery_Click(null, null);
            
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
						var filter = Builders<OrgUnit>.Filter.Eq(o => o.OrgUnitId, orgUnit.OrgUnitId);

                        var update = Builders<OrgUnit>.Update.Set(o => o.AV, true);
						
                        OrgUnitsCollection.UpdateOne(filter, update);
					}
                }
            }
            
            btnQuery_Click(null, null);

        }

        // 删除节点   没有设计导航 无法像EFCore递归控制权限..
        private void button2_Click(object sender, EventArgs e)
        {
			if (this.OrgUnitsTable == null) btnQuery_Click(null, null);

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
						var filter = Builders<OrgUnit>.Filter.Eq(o => o.OrgUnitId, orgUnit.OrgUnitId);

						var update = Builders<OrgUnit>.Update.Set(o => o.IsDeleted, true);

						OrgUnitsCollection.UpdateOne(filter, update);
					}

                }
            }
            btnQuery_Click(null, null);
        }
    }
}
