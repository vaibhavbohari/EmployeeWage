// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to EmployeWage!");

Random random = new Random(); 
const int   present = 1,
              absent = 0,
              empWorkingHrs = 8,
              ratePerHr = 20;


int isPresent  = random.Next(2), //0,1
    empWage = 0;


if(isPresent  == present)
{
    Console.WriteLine(" Employee is Present ");
    empWage = empWorkingHrs * ratePerHr;


}
else
{
    Console.WriteLine(" Employee is Absent"); 
}

Console.WriteLine("Employee Wage : "+ empWage);




