
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
using System.Windows.Forms;

namespace SC_Forms
{
    public partial class FormIndexManagerSettingSelfNode : Form
    {
		private IMongoCollection<OrgUnit> OrgUnitsCollection = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<OrgUnit>("OrgUnits");
		private IMongoCollection<User> UsersCollection = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<User>("Users");
		private List<OrgUnit> OrgUnitsTable = null;
		public FormIndexManagerSettingSelfNode()
        {
            InitializeComponent();
        }

        // 获取表数据
        private List<OrgUnit> GetTable()
        {
			//return SC_DB.OrgUnits.Where(o => o.OwnerId == FormsHelper.UserId && o.ParentGuid != null).ToList();
			OrgUnitsTable = OrgUnitsCollection.AsQueryable()
		.Where(o => o.OwnerId == FormsHelper.UserId && o.IsDeleted == false && o.ParentId != null).ToList();

			return OrgUnitsTable;
		}

		// 错误类型检测 √
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

		//bsonid检测 √
		private bool IsValidObjectId(string str)
		{
			try
			{
				ObjectId.Parse(str);
				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		// 查询 
		private void btnQuery_Click(object sender, EventArgs e)
        {
			this.OrgUnitsTable = GetTable();
			this.dataGridView1.DataSource = this.OrgUnitsTable;
			this.dataGridView1.DataError += dataGridView1_DataError;
			this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
		}

        // 加入父节点
        private void btnAddNode_Click(object sender, EventArgs e)
        {
			if (IsValidObjectId(txParentNode.Text) == false) { return; }
            this.btnQuery_Click(null, null);

			if (OrgUnitsCollection.AsQueryable().Where(o => o.OrgUnitId == txParentNode.Text).FirstOrDefault() == null)
			{
				MessageBox.Show($"无效用户 {txParentNode.Text}");
				return;
			}

			OrgUnit orgunit = new OrgUnit();
			orgunit.EmpName = "default";
			orgunit.OrgName = "default";
			orgunit.OwnerId = FormsHelper.UserId;
			orgunit.IsDeleted = false;
			orgunit.ParentId = txParentNode.Text;
			orgunit.AV = false;
			OrgUnitsCollection.InsertOne(orgunit);

			this.btnQuery_Click(null, null);
        }

        // 修改
        private void btnUpData_Click(object sender, EventArgs e)
        {
			if (this.OrgUnitsTable == null) this.btnQuery_Click(null, null);

			// 检查更新信息 or 移交节点 后者AV需更改为false
			foreach (var orgUnit in OrgUnitsTable)
			{

				var filter = Builders<OrgUnit>.Filter
							.Eq(o => o.OrgUnitId, orgUnit.OrgUnitId);

				var update = Builders<OrgUnit>.Update
					.Set(o => o.EmpName, orgUnit.EmpName)
					.Set(o => o.OrgName, orgUnit.OrgName);
					//.Set(o => o.OwnerId, orgUnit.OwnerId)
					//.Set(o => o.ParentId, orgUnit.ParentId);
				
				OrgUnitsCollection.UpdateOne(filter, update);

			}
			this.btnQuery_Click(null, null);
		}

        // 退出节点 - 把归属权还给父节点
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

						var parentNode = OrgUnitsCollection.AsQueryable().Where(o => o.OrgUnitId == orgUnit.ParentId).FirstOrDefault();

						var filter = Builders<OrgUnit>.Filter
							.Eq(o => o.OrgUnitId, orgUnit.OrgUnitId);

						var update = Builders<OrgUnit>.Update
							.Set(o => o.AV, false)
							.Set(o => o.OwnerId, parentNode.OwnerId);
						//.Set(o => o.OwnerId, orgUnit.OwnerId)
						//.Set(o => o.ParentId, orgUnit.ParentId);

						OrgUnitsCollection.UpdateOne(filter, update);
					}
                }
            }
            btnQuery_Click(null, null);
        }
    }

}
