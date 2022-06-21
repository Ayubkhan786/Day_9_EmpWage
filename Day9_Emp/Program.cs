Console.WriteLine("Welcome to Employee Wage Computation Program");
int empPresent = 1;
Random num = new Random();
int attendance = num.Next(0, 2);
if (attendance == empPresent)
{


    Console.WriteLine("Is Present");


}

else
{
    Console.WriteLine("Is Absent");
}