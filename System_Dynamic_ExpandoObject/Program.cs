dynamic var1 = new System.Dynamic.ExpandoObject();
var1.name = "test";
var1.price = 10;
string json = Newtonsoft.Json.JsonConvert.SerializeObject(var1);
Console.WriteLine(var1); // Prints the System.Dynamic.ExpandoObject
Console.WriteLine(json); // {"name":"test","price":10}

