using AdminPage;
using CarManufacture;
using Department;
using Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection scon = new SqlConnection("server=localhost;database=BhavnaCrop;integrated security = true");
            AdminSite adminPage = new AdminSite();
            adminPage.ShowMainPage();
            Console.WriteLine("Enter the Admin Credentials to login");
            Console.Write("Enter the username :");
            string UserName = Console.ReadLine();
            Console.Write("Enter the passwordd:");
            string passwordd = Console.ReadLine();
            SqlDataAdapter da = new SqlDataAdapter("select * from Admin_Table", scon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Admin_Table");
            int Count = ds.Tables["Admin_Table"].Rows.Count;

            for (int i = 0; i < Count; i++)
            {
                if (UserName == ds.Tables["Admin_Table"].Rows[i][0].ToString() && passwordd == ds.Tables["Admin_Table"].Rows[i][1].ToString())
                {

                    Console.WriteLine("Logged in Successfully");
                    Console.WriteLine("welcome to car manufature unit");
                    
                    string success = "Y";

                    while (success.ToUpper() == "Y")
                    {

                        Console.WriteLine("Enter 1 to  get inserted");
                        Console.WriteLine("Enter 2 to  get GetAllEmployee");
                        Console.WriteLine("Enter 3 to get   TotalSalary");
                        Console.WriteLine("Enter 4 to get  GetDepart");
                        Console.WriteLine("Enter 5 to get  InsertDepart");
                        Console.WriteLine("Enter 6 to get  CarManufactureList");
                        Console.WriteLine("Enter 7 to get  InsertCarManufacture");
                        Employees employee = new Employees();
                        Departments department = new Departments();
                        CarManufactures carManufacture = new CarManufactures();
                        
                        
                        int process = int.Parse(Console.ReadLine());

                        switch (process)
                        {
                            case 1:
                                InsertEmployeeDel insertEmployeeDel = new InsertEmployeeDel(employee.InsertEmployee);
                                insertEmployeeDel.Invoke();
                            break;
                            case 2:
                                GetAllEmployeeDel getAllEployeeDel = new GetAllEmployeeDel(employee.GetAllEmployee);
                                getAllEployeeDel.Invoke();
                                break;
                            case 3:
                                Console.WriteLine("Total Salary:" + employee.GetTotalSalary());
                                break;
                            case 4:
                                GetDepartmentDel getDepartmentDel = new GetDepartmentDel(department.GetDepartment);
                                getDepartmentDel.Invoke();
                                break;
                            case 5:
                                InsertDepartmentDel insertDepartmentDel = new InsertDepartmentDel(department.InsertDepartment);
                                insertDepartmentDel.Invoke();
                                break;
                            case 6:
                               GetManfactureListDel getManfactureList = new GetManfactureListDel(carManufacture.GetManfactureList);
                                getManfactureList.Invoke();
                                break;
                            case 7:
                                InsertManfactureDataDel insertManfactureDataDel = new InsertManfactureDataDel(carManufacture.InsertManfactureData);
                                insertManfactureDataDel.Invoke();
                             
                                break;
                            default:
                                Console.WriteLine("None of the Operations performance here");
                                break;

                        }
                        Console.WriteLine("Do you want to Continue Y/N");
                        success = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Credentials");
                }
              
            }

            Console.ReadLine();
            }

        }
    }

