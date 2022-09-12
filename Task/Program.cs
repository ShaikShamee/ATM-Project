using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task
{
    [Serializable]
    public class Employee
    {

       public int Emp_Id;
        public string Emp_Name;

        public Employee(int id, string name)
        {
            Emp_Id = id;
            Emp_Name = name;
        }
    }
        public class Program
        { 
        static void Main(string[] args)
        {

            //DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\\bhavna");
            //try
            //{
            //    if(directoryInfo.Exists)
            //    {
            //        Console.WriteLine("Directory already exsists");
            //        directoryInfo.Delete();
            //        Console.WriteLine("Directory deleted successfully");
            //    }
            //    else
            //    {
            //        directoryInfo.Create();
            //        Console.WriteLine("Directory created ");
            //        Console.WriteLine("no directory is exists");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            FileStream fileStream = new FileStream(@"",FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employee employee = (Employee)binaryFormatter.Deserialize(fileStream);

            Console.WriteLine("Emp Id:"+employee.Emp_Id);
            Console.WriteLine("Emp Name:"+employee.Emp_Name);
            Console.ReadLine();
            
        }
    }
}
