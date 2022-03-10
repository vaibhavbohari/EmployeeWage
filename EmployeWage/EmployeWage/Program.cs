// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to EmployeWage!");

Random random = new Random(); 
const int present = 1;
const int absent = 0;


int ispresent  = random.Next(2);  

if(ispresent  == present)
{
    Console.WriteLine(" Employee is Present ");

}
else
{
    Console.WriteLine(" Employee is Absent"); 
}





