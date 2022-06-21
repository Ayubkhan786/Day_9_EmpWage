Console.WriteLine("Welcome to Employee Wage Computation Program");

int empAbsent = 0;
int empPresent = 1;
int empPartTime = 2;

int empWrkHrs = 0;
int empSalary = 50;

Random num = new Random();
int attendance = num.Next(0, 3);
if (attendance == empPresent)
{
    Console.WriteLine("Is Present");
    empWrkHrs = 8;
    empSalary = 50;
}

else if (attendance == empAbsent)
{
    Console.WriteLine("Is Absent");
    empWrkHrs = 0;
    empSalary = 0;
}
else
{
    Console.WriteLine("Is PartTime");
    empWrkHrs = 4;
    empSalary = 50;
}

int empWage = (empWrkHrs * empSalary);
Console.WriteLine("The total salary is :" + empWage);