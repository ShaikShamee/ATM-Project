using System;
using System.Data.SqlClient;
using System.IO;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            string answer = "y";
            for (; answer == "y";)
            {

                string filepath = @"D:\\Employee.txt";
                    if (!File.Exists(filepath))
                    {

                        using (StreamWriter streamWriter = File.CreateText(filepath))
                        {
                            streamWriter.WriteLine($"Record : EmpId - {employee.EmpId}, Name - {employee.EmpName}, Age - {employee.Age}, Gender - {employee.Gender}, Salary - {employee.Salary}");
                            Console.WriteLine("file created successfully");
                        }
                    }
                    else
                    {
                        using (StreamWriter streamWriter = File.AppendText(filepath))
                        {
                            streamWriter.WriteLine($"Record : Id - {employee.EmpId}, Name - {employee.EmpName}, Age - {employee.Age}, Gender - {employee.Gender}, Salary - {employee.Salary}");
                            Console.WriteLine("file appended successfully");
                        }
                    }
                


                Console.Write("Enter employee's id:");
                employee.EmpId = int.Parse(Console.ReadLine());

                Console.Write("Enter employee's name:");
                employee.EmpName = Console.ReadLine();

                Console.Write("Enter employee's age:");
                employee.Age = int.Parse(Console.ReadLine());

                Console.Write("Enter employee's gender:");
                employee.Gender = Console.ReadLine();

                Console.Write("Enter employee's salary:");
                employee.Salary = double.Parse(Console.ReadLine());

                SqlConnection scon = new SqlConnection("server=localhost;database=CURD Angular;integrated security=true");
                //insertion command creation
                SqlCommand scmd = new SqlCommand("insert into Employee_Table values( " + employee.EmpId + "  , '" + employee.EmpName + "' , " + employee.Age + " , ' " + employee.Gender + " ' ," + employee.Salary + ")", scon);
                scon.Open();
                scmd.ExecuteNonQuery();
                scon.Close();
                Console.WriteLine("Record Inserted Successfully");

                Console.WriteLine("Do you want to repeat? Y or N");
                answer = Console.ReadLine();


            }
        }

    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
}
