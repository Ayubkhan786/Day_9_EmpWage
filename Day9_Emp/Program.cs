public class Companies_Salary
{
    public const int empAbsent = 0;
    public const int empPresent = 1;
    public const int empPartTime = 2;

    //Using Class Method with function parameters instead of Class Variables
    public void EmployeeWage(string Companyname, int empSalary, int MAX_DAYS, int MAX_HRS)
    {


        int empHrs = 0, maxDays = 0, empWrkHrs = 0;

        while (empWrkHrs <= MAX_HRS && maxDays < MAX_DAYS)
        {
            maxDays++;

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
            empWrkHrs += empHrs;
            Console.WriteLine("Day : " + maxDays + "\n " + "Hours : " + empWrkHrs);


            int empWage = (empWrkHrs * empSalary);

            Console.WriteLine("Per Day salary is :" + empWage);

        }

        int monthlyWage = (empWrkHrs * MAX_DAYS * empSalary);
        Console.WriteLine("The Monthly salary for "+ Companyname + " " + "is :" + monthlyWage);
    }
    static void Main(String[] args)
    {
        Companies_Salary salary = new Companies_Salary();
        salary.EmployeeWage("TCS",30,28,56);
        salary.EmployeeWage("CTS",40,30, 70);
    }
}