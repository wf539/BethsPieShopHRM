

using BethsPieShopHRM;

//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.PerformWork(25);

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

//int minimumBonus = 100;
//int bonusTax = 0;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//bethany.firstName = "John";
//bethany.hourlyRate = 10;

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(12);
//bethany.PerformWork();
//bethany.ReceiveWage();

//string fn = bethany.firstName;

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (Message from program): {receivedWageBethany}");

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");
////Here we are using new without specifying the type since it's known on the left-hand side

//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

////Dan methods aanroepen
//george.DisplayEmployeeDetails();
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(3);
//george.PerformWork();
//george.PerformWork(8);

//var receivedWageGeorge = george.ReceiveWage(true);