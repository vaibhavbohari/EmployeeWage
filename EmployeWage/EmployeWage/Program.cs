// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to EmployeWage!");

Random random = new Random();
const int absent = 0,
              present = 1,
              halfday = 2,
              ratePerHr = 20,
              fullTime = 8,
              partTime = 4;


int isPresent  = random.Next(3), 
    empWage = 0;


if(isPresent  == present)
{
    Console.WriteLine(" Employee is Present fullTime ");
    empWage = ratePerHr * fullTime;
    int fullTimeHr = 8;

}

else if (isPresent == halfday)
{
    Console.WriteLine(" Employee is Present partTime ");
    empWage = ratePerHr * partTime;

}

else
{
    Console.WriteLine(" Employee is Absent"); 
}

Console.WriteLine("Employee Wage : "+ empWage);




