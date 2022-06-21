Console.WriteLine("Welcome to Employee Wage Computation Program");

int empPresent = 1;
int empWrkHrs = 0;
int empSalary = 50;
Random num = new Random();
int attendance = num.Next(0, 2);
if (attendance == empPresent)
{
    Console.WriteLine("Is Present");
    empWrkHrs = 8;
    empSalary = 50;
}

else
{
    Console.WriteLine("Is Absent");
    empWrkHrs = 0;
    empSalary = 0;
}

int empWage = (empWrkHrs * empSalary);
Console.WriteLine("The total salary is :" + empWage);