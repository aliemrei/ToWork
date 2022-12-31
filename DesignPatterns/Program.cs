using DesignPatterns.Models;
using DesignPatterns.Models.AbstractFactory;
using DesignPatterns.Models.Factory;
using DesignPatterns.Models.Prototype;

#region Singleton Design Pattern
SingletonModel singleton1;

SingletonModel singleton2;

singleton1 = SingletonModel.GetInstance();

singleton2 = SingletonModel.GetInstance();

Console.WriteLine("Signleton objects' hashcodes are same : " + singleton1?.GetHashCode() + " = " + singleton2.GetHashCode());
#endregion

#region Factory Design Pattern
Console.WriteLine("Add result is " + CalculateFactory.GetCalculator("Gather").Calculate(100, 20));

Console.WriteLine("Divide result is " + CalculateFactory.GetCalculator("Divide").Calculate(100, 20));
#endregion

#region Abstract/Prototype Design Pattern
ExcelFile excelFile = new ExcelFile();
excelFile.OpenProcessAndClose();

TextFile textFile = new TextFile();
textFile.Open();
textFile.Process();
textFile.Close();
#endregion

#region Abstract Factory Design
Factory factory = new Factory(new SqlFactory());

factory.ExecuteSql("Select * ....");

factory = new Factory(new MySqlFactory());

factory.ExecuteSql("Select * ....");
#endregion

Console.ReadKey();

