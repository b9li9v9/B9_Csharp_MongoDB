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
		public string conneStr { get; set; } = null;
		public string dbName { get; set; } = null;
		public string collName { get; set; } = null;

		private static MongoDbHelper _singleton = new MongoDbHelper();

		private MongoDbHelper() { }
		public static MongoDbHelper Instance()
		{
			return _singleton;
		}
		private MongoClient _client { get; set; } = null;
		public MongoClient Client
		{
			get 
			{ 
				if(this.conneStr == null)
				{
					throw new Exception();
				}
				if (this._client == null)
				{
					this._client = new MongoClient(conneStr);
					return _client;
				}
				return _client; 
			}
		}
	}
}
