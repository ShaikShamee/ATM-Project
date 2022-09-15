using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public delegate void GetAllEmployeeDel();
    public delegate void InsertEmployeeDel();
    public class Employees : IEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public string EmpAddress { get; set; }

        public int EmpSalary { get; set; }

        public double Empphone { get; set; }
        public string EmpEmail { get; set; }
        public int DailyHour { get; set; }
        public int ExtraHour { get; set; }
        public int ExtraAmount { get; set; }
        public int PerDayAmount { get; set; }
        public int WorkingDay { get; set; }

        public int EmpCount { get; set; }
        public int TotalMonthSalary;
        SqlConnection scon = new SqlConnection("server=localhost;database=BhavnaCrop;Integrated Security=true;");
        public int GetTotalSalary()
        {
            Console.Write("Enter the EmployeeDailyHours:");
            int DailyHour = int.Parse(Console.ReadLine());
            Console.Write("Enter the EmployeeExtraHours:");
            int ExtraHour = int.Parse(Console.ReadLine());
            Console.Write("Enter the EmployeePerDayAmount:");
            int PerDayAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter the WorkingDays:");
            int WorkingDay = int.Parse(Console.ReadLine());
            int perHourAmount = (PerDayAmount / DailyHour);
            int ExtraAmount = 2 * (ExtraHour * perHourAmount);
            TotalMonthSalary = (PerDayAmount * DailyHour * WorkingDay) + ExtraAmount;
            return TotalMonthSalary;

        }

        public void GetAllEmployee()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee_Table", scon);
                scon.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "Employee_Table");
                int Count = ds.Tables["Employee_Table"].Rows.Count;
                for (int i = 0; i < Count; i++)
                {

                    Console.WriteLine("Employee id: " + ds.Tables["Employee_Table"].Rows[i][0].ToString());
                    Console.WriteLine("Employee Name: " + ds.Tables["Employee_Table"].Rows[i][1].ToString());
                    Console.WriteLine("Employee Address: " + ds.Tables["Employee_Table"].Rows[i][2].ToString());
                    Console.WriteLine("Employee Salary: " + ds.Tables["Employee_Table"].Rows[i][3].ToString());
                    Console.WriteLine("Employee Phone: " + ds.Tables["Employee_Table"].Rows[i][4].ToString());
                    Console.WriteLine("Employee Email: " + ds.Tables["Employee_Table"].Rows[i][5].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void InsertEmployee()
        {
            Employees emp = new Employees();
            try
            {
                Console.Write("Enter the EmployeeId:");
                int EmpId = int.Parse(Console.ReadLine());
                Console.Write("Enter the EmployeeName:");
                string EmpName = Console.ReadLine();
                Console.Write("Enter the EmployeeAddress:");
                string EmpAddress = Console.ReadLine();
                int EmpSalary = emp.GetTotalSalary();
                Console.WriteLine("Total Salary:" + EmpSalary);
                Console.Write("Enter the EmployeePhoneNumber:");
                string Empphone = Console.ReadLine();
                Console.Write("Enter the EmployeeEmail:");
                string EmpEmail = Console.ReadLine();
                string query1 = "INSERT INTO Employee_Table VALUES(" + EmpId + ",'" + EmpName + "','" + EmpAddress + "'," + EmpSalary + "," + Empphone + ",'" + EmpEmail + "')";
                SqlCommand scmd1 = new SqlCommand(query1, scon);
                scon.Open();
                scmd1.ExecuteNonQuery();
                scon.Close();
                Console.WriteLine("Inserted Employee Data Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        


    }
}
