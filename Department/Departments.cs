using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public delegate void GetDepartmentDel();
    public delegate void InsertDepartmentDel();  
     public class Departments:IDepartment
     {
        SqlConnection scon = new SqlConnection("server=localhost;database=BhavnaCrop;Integrated Security=true;");
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int EmpId { get; set; }

        public void GetDepartment()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Department_Table", scon);
                scon.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "Department_Table");
                int Count = ds.Tables["Department_Table"].Rows.Count;
                for (int i = 0; i < Count; i++)
                {

                    Console.WriteLine("Department id: " + ds.Tables["Department_Table"].Rows[i][0].ToString());
                    Console.WriteLine("Deaprtment Name: " + ds.Tables["Department_Table"].Rows[i][1].ToString());
                    Console.WriteLine("Employee Id: " + ds.Tables["Department_Table"].Rows[i][2].ToString());

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        public void InsertDepartment()
        {
            try
            {
                Console.Write("Enter the DepartmentId:");
                int DeptId = int.Parse(Console.ReadLine());
                Console.Write("Enter the DepartName:");
                string DeptName = Console.ReadLine();
                Console.Write("Enter the EmpId:");
                int EmpId = int.Parse(Console.ReadLine());
                string query1 = "INSERT INTO Department_Table VALUES(" + DeptId + ",'" + DeptName + "'," + EmpId + ")";
                SqlCommand scmd1 = new SqlCommand(query1, scon);
                scon.Open();
                scmd1.ExecuteNonQuery();
                scon.Close();
                Console.WriteLine("Inserted Department Data Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
