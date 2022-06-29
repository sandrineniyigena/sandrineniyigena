// this is the Main class program that will execute our next class employee
using System.Diagnostics.Contracts;
using C_shrp_payroll;

class program
{
    static void Main(string[] org)
    { //this is the object tha will help to access the fields of our class
        var emplo = new MonthlyEmloyee();
        var emplo1 = new HourEmployee();
        emplo.enum_values_permanent = Employee.Contract.Permanent.ToString();
        emplo.enum_values_casual = Employee.Contract.Casual.ToString();
        //user inputs
       
        
        
            Console.WriteLine($"Name:"); 
            emplo.Name = Console.ReadLine();
            Console.WriteLine($"enter the Employee hours:");
            emplo.hours = Console.ReadLine();
            Console.WriteLine("enter the departiment");
            emplo.EmployeDepartment = Console.ReadLine();
            Console.WriteLine("Enter the type of contract: permanent/casual");
            emplo.EmployeContract = Console.ReadLine(); 
            Console.WriteLine("enter the hired date/(year)");
            emplo.hired_date = Convert.ToInt32(Console.ReadLine());
            //this condition will check the type of contract entered from user if is permanent
            if (emplo.EmployeContract =="permanent")
            {
                Console.WriteLine("enter grossalary:");
                emplo.gross_salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(emplo.get_name());
            
                Console.WriteLine("netpay:"+emplo.CalculateSalary_permanent(emplo.gross_salary));
            
            }
            ////this condition will check the contract entered from user if is casual
            else if (emplo1.EmployeContract=="casual")
            {
                Console.WriteLine("enter the hourrate:");
                emplo1.hourPayLyrate =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the hours worked");
                emplo1.hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(emplo1.get_name());
                Console.WriteLine("net pay:"+emplo1.CalculateSalary_casual(double hours, double payrate));
                Console.WriteLine("overtime pay amount:"+emplo1.overtime);
            }
        }
    
}