using AsianCollege.Class;
using AsianCollege.Others;
using System.Net;
using System.Reflection;
using static AsianCollege.Others.Delegates;

Console.WriteLine("Hello, World!");
// Child child = new Child("name");
// child.Display();



// Account acc = new Account();
// acc.Balance = 100000;
// Console.WriteLine($"Current Balance: {acc.Balance}");

// Constructor
// FileName filename = new FileName();

// Polymorphism poly = new Polymorphism();
// poly.Display();

// Animal anm = new Dog();
// anm.Sound();
// 
// Dog dg = new Dog();
// dg.Sound();
// Console.ReadKey();
// 
// 
// Child chd = new Child("Hari");


// Encapsulation example
// Account acc = new Account();
// acc.SetBalance(2000);
// Console.WriteLine("Current Balance: {0}", acc.GetBalance());
// Console.ReadKey();

// Abstraction Example
// NabilBank nrb = new NabilBank();
// nrb.GetUserDetails();


// Struct & Enums
// GetStudentDetails details = new GetStudentDetails();
// details.DisplayStudentDetails();


// Abstraction Example
// NabilBank nabil = new NabilBank();
// nabil.ChargeServiceFee();

// GlobalIme ime = new GlobalIme();
// ime.ChargeServiceFee();


// delegate calling way
// MyDelegate myDelegate = Welcome;
// myDelegate();

// event calling way

// class object intialize
// Events env = new Events();
// ClosedEvents closedEvents = new ClosedEvents();
// Security sc = new Security();

// event subscription
// env.BellRang += closedEvents.School;
// env.BellRang += sc.OpenGate;
// env.BellRang -= closedEvents.School;

// main method calling
// env.RingBell();

// calling partial class
// BankingCore bk = new BankingCore();
// bk.GetName();
// bk.GetMobileNumber();


// File IO Operations
// FileIO fileoperation = new FileIO();
// fileoperation.WriteFile();
// fileoperation.ReadFile();

// Collections collections = new Collections();
// collections.DisplayCollections();

//Linq linq = new Linq();
// linq.Display();

// LambdaExpression lambda = new LambdaExpression();
// lambda.add(2,3);
// lambda.greet();
// var data = lambda.isEven(3);
// Console.WriteLine("Is Even Number : {0}", data);




// custom implementations
// TestValidation testval = new TestValidation();
// testval.Name = "HelloWorld11";


// custom attribute check
// Type? type = testval.GetType();
// foreach (PropertyInfo t in type.GetProperties())
// {
//     if(t.Name == "Name")
//     {
//         var attr = t.GetCustomAttribute<CheckLength>();
//         if (attr != null)
//         {
//             if (testval.Name.Length > attr.MaxLength)
//                 Console.WriteLine("Name is too long");
//             Console.WriteLine("Name is valid");
//         }
//     }
// }

