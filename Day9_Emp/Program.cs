Console.WriteLine("Welcome to Employee Wage Computation Program");

int empAbsent = 0;
int empPresent = 1;
int empPartTime = 2;
int numWorkingDays = 20;
int empWrkHrs = 0;
int empSalary = 50;

Random num = new Random();
int attendance = num.Next(0, 3);

switch (attendance)
{
    case 0:
        Console.WriteLine("Is Absent");
        empWrkHrs = 0;
        break;
    case 1:
        Console.WriteLine("Is Present");
        empWrkHrs = 8;
        break;
    case 2:
        Console.WriteLine("Is PartTime");
        empWrkHrs = 4;
        break;
}

int empWage = (empWrkHrs * empSalary);
int monthlyWage = (empWage * numWorkingDays);
Console.WriteLine("Per Day salary is :" + empWage);
Console.WriteLine("The Monthly salary is :" + monthlyWage);