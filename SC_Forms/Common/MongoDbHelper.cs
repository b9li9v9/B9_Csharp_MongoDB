using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SC_Forms.Helper
{
    internal sealed class MongoDbHelper
    {
        private MongoDbHelper() { }
        private static readonly string conneStr = "mongodb://localhost:27017";
        private static readonly MongoClient _mongoclient = new MongoClient(conneStr);
        public static MongoClient GetClient() {
            return _mongoclient;
        }

    }
}
