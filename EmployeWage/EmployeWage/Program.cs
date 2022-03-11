// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to EmployeWage!");

Random random = new Random(); //it is using to generate random number
const int     absent = 0,
              present = 1,
              halfday = 2,
              fullMonth = 3,
              ratePerHr = 20,
              fullTime = 8,
              partTime = 4,
              perMonthDays=20;


int isPresent = random.Next(4), // 0= absent , 1=fullTime/present, 2=halfday/partTime , 3 = fullMonth
    empWage = 0;
   
switch ( isPresent )
{
    case present:
        Console.WriteLine("Employee is Present fullTime");
        empWage = ratePerHr * fullTime;
        break;
    case halfday:
        Console.WriteLine(" Employee is Present partTime ");
        empWage = ratePerHr * partTime;
        break;
    case fullMonth:
        Console.WriteLine(" Employee per Month Wage ");
        empWage = perMonthDays * (ratePerHr * fullTime);
        break;

    default:
        Console.WriteLine(" Employee is Absent");
        break;


}

Console.WriteLine("Employee Wage : "+ empWage);




