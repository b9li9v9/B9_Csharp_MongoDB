```
.
mongodb

��������
1. ����mongodb mongodbshell mongodbGUI / NuGet Install-package MongoDB.Driver
2. ����db  mongod.exe --dbpath "path"

google AI
https://aistudio.google.com/app/prompts/new_chat

����ע��-����λ��
1.NuGet Install-package Microsoft.Extensions.DependencyInjection
2.using Microsoft.Extensions.DependencyInjection
3.����ע�� ServiceCollection services = new ServiceCollection()  
	services.AddTransient<class>() ˲̬
	services.AddSingleton<class>() ����
	services.AddScoped<class>() ��Χ
4.����  services.BuildServiceProvider()

rabbitmq

ԭ��CLI
������ use "dbname"
������ db.createCollection("collectionname")
����  db.CName.insertMany([{...},{...}])

��ѯ  db.CName.find().pretty()   find({����..})
// ��ѯ�����ĵ�
db.users.find() 
// ��ѯ "name"  Ϊ "John Doe" ���ĵ�
db.users.find({ "name": "John Doe" }) 
// ��ѯ "age" ���� 25 ���ĵ�
db.users.find({ "age": { "$gt": 25 } })

����
db.collectionName.updateOne(
    // ��ѯ���� 
    { "field1": "value1" }, 
    // �������
    { $set: { "field2": "newValue" } }
)
ɾ��
db.collectionName.deleteOne({ 
    // ��ѯ����
    "field1": "value1",
    "field2": "value2",
    //  ... 
})

C# ����
1.����ʵ����

2.��������
using MongoDB.Driver;

// �����ַ���
string connectionString = "mongodb://localhost:27017";

// ���� MongoClient ����
MongoClient client = new MongoClient(connectionString);

// ��ȡ���ݿ�
var database = client.GetDatabase("your_database_name");

// ��ȡ����
var collection = database.GetCollection<Person>("people");

����
// ����һ���µ��ĵ�
var newPerson = new Person { Name = "John Doe", Age = 30 };
// ���뵽������
await collection.InsertOneAsync(newPerson);

��ѯ
// ��ѯ�����ĵ�
var allPeople = await collection.Find(_ => true).ToListAsync(); 
// ��ѯ�ض��������ĵ�
var peopleByName = await collection.Find(x => x.Name == "John Doe").ToListAsync();
// ��ѯ��һ��ƥ���������ĵ�
var firstPerson = await collection.Find(x => x.Name == "John Doe").FirstOrDefaultAsync();

ɾ��
// ʹ�ù���������λ�ĵ�
var filter = Builders<Person>.Filter.Eq(x => x.Name, "John Doe");
// ɾ��ƥ����ĵ�
await collection.DeleteOneAsync(filter);

����
// ʹ�ù���������λ�ĵ�
var filter = Builders<Person>.Filter.Eq(x => x.Name, "John Doe"); 
// ʹ�ø������������ֵ
var update = Builders<Person>.Update.Set(x => x.Age, 35);
// ִ�и��²���
await collection.UpdateOneAsync(filter, update); 


```

```
�뷨
    https://www.nuget.org/ 
    Ƕ�׵�Խ��Խ�Ѵ���
    ÿ���û�����һ��User��¼
    ÿ��User����һ��Ψһʶ��
    ���еı������Ψһʶ�𣬾Ϳ��Բ�Ƕ��
    User��������User�Ǹ�������Ҫ����������
```