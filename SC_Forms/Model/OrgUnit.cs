using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    internal class OrgUnit
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string OrgUnitId { get; set; }
        public string EmpName { get; set; }     // 员工名字
        public string OrgName { get; set; }     // 组织、部门名字
        public string OwnerId { get; set; }     // 数据拥有者
        public bool IsDeleted { get; set; }
        public string ParentId { get; set; } // 即是父节点 也是上级领导人
        public bool AV { get; set; } // 节点合法性
    }
}
