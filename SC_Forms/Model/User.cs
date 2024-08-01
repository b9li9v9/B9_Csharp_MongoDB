using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    internal class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        public string Acct { get; set; }
        public string Nick { get; set; }
        public string pwd { get; set; }
        public bool IsDeleted { get; set; }

        // 组织管理树导航
        public NavOrgUnits? navOrgUnits { get; set; }

        // 构造函数初始化AssociatedOrgUnits，以避免null引用异常
        //public User()
        //{
        //    navOrgUnits = new NavOrgUnits();
        //}

    }

    //internal class OrgUnit { }
}
