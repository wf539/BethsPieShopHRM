

using BethsPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

bethany.firstName = "John";
bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();
bethany.ReceiveWage();

string fn = bethany.firstName;

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (Message from program): {receivedWageBethany}");

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");
//Here we are using new without specifying the type since it's known on the left-hand side

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

//Dan methods aanroepen
george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);