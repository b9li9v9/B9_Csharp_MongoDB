```
.
mongodb

基本配置
1. 下载mongodb mongodbshell mongodbGUI / NuGet Install-package MongoDB.Driver
2. 启动db  mongod.exe --dbpath "path"

google AI
https://aistudio.google.com/app/prompts/new_chat

依赖注入-服务定位器
1.NuGet Install-package Microsoft.Extensions.DependencyInjection
2.using Microsoft.Extensions.DependencyInjection
3.容器注册 ServiceCollection services = new ServiceCollection()  
	services.AddTransient<class>() 瞬态
	services.AddSingleton<class>() 单例
	services.AddScoped<class>() 范围
4.构建  services.BuildServiceProvider()

rabbitmq

原生CLI
创建库 use "dbname"
创建表 db.createCollection("collectionname")
插入  db.CName.insertMany([{...},{...}])

查询  db.CName.find().pretty()   find({条件..})
// 查询所有文档
db.users.find() 
// 查询 "name"  为 "John Doe" 的文档
db.users.find({ "name": "John Doe" }) 
// 查询 "age" 大于 25 的文档
db.users.find({ "age": { "$gt": 25 } })

更新
db.collectionName.updateOne(
    // 查询条件 
    { "field1": "value1" }, 
    // 更新语句
    { $set: { "field2": "newValue" } }
)
删除
db.collectionName.deleteOne({ 
    // 查询条件
    "field1": "value1",
    "field2": "value2",
    //  ... 
})

C# 驱动
1.定义实体类

2.建立连接
using MongoDB.Driver;

// 连接字符串
string connectionString = "mongodb://localhost:27017";

// 创建 MongoClient 对象
MongoClient client = new MongoClient(connectionString);

// 获取数据库
var database = client.GetDatabase("your_database_name");

// 获取集合
var collection = database.GetCollection<Person>("people");

插入
// 创建一个新的文档
var newPerson = new Person { Name = "John Doe", Age = 30 };
// 插入到集合中
await collection.InsertOneAsync(newPerson);

查询
// 查询所有文档
var allPeople = await collection.Find(_ => true).ToListAsync(); 
// 查询特定条件的文档
var peopleByName = await collection.Find(x => x.Name == "John Doe").ToListAsync();
// 查询第一个匹配条件的文档
var firstPerson = await collection.Find(x => x.Name == "John Doe").FirstOrDefaultAsync();

删除
// 使用过滤条件定位文档
var filter = Builders<Person>.Filter.Eq(x => x.Name, "John Doe");
// 删除匹配的文档
await collection.DeleteOneAsync(filter);

更新
// 使用过滤条件定位文档
var filter = Builders<Person>.Filter.Eq(x => x.Name, "John Doe"); 
// 使用更新语句设置新值
var update = Builders<Person>.Update.Set(x => x.Age, 35);
// 执行更新操作
await collection.UpdateOneAsync(filter, update); 


```

```
想法
    https://www.nuget.org/ 
    
    240803
    嵌套的越深越难处理
    每个用户都有一个User记录
    每个User都有一个唯一识别
    可以用逻辑主键

    240804 
    没有设计导航 无法像EFCore递归控制权限.. 
    也能写但很臭
    弃工跳学rabbitmq
```
