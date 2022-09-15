using Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacture
{
    public delegate void GetManfactureListDel();
    public delegate void InsertManfactureDataDel();
    public class CarManufactures:ICarManufacture
    {
        SqlConnection scon = new SqlConnection("server=localhost;database=BhavnaCrop;Integrated Security=true;");
        public int CarId { get; set; }
        public string CarModelName { get; set; }

        public string CarColor { get; set; }

        public double CarEstimatedCost { get; set; }
        public int CarParts { get; set; }
        public int Amount { get; set; }
        public int ManPowerCost { get; set; }
        public int NumberCount { get; set; }
        
        public int StockIn { get; set; }
        public int StockOut { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int ProfitandLoss { get; set; }

        public int TotalProfitandLoss;

        public int EstimatedCost;

        public int Value;
        public void CarPrice()
        {
            Employees employees = new Employees();
            int Distribution= employees.GetTotalSalary();
            int Total = employees.EmpCount;
            int TotalSal = (Distribution * Total);
             Value = TotalSal + EstimatedCost;
            Console.WriteLine("Total CarPrice:"+Value);
        }
        public int TotalStock()
        {
            Console.Write("Enter the StockIn:");
            int StockIn = int.Parse(Console.ReadLine());
            Console.Write("Enter the StockOut:");
            int StockOut = int.Parse(Console.ReadLine());
            int TotalStock = StockIn - StockOut;
            return TotalStock;
        }
        public int GetProfitandLoss()
        {
            TotalProfitandLoss =Value-EstimatedCost;
            return TotalProfitandLoss;
        } 
        public int TotalCostPrice()
        {
            Console.Write("Enter the CarParts:");
            int CarParts = int.Parse(Console.ReadLine());
            Console.Write("Enter the Amount:");
            int Amount = int.Parse(Console.ReadLine());
            Console.Write("Enter the ManPowerCost:");
            int ManPowerCost = int.Parse(Console.ReadLine());
            Console.Write("Enter the NumberCount:");
            int NumberCount = int.Parse(Console.ReadLine());
             EstimatedCost = (CarParts * Amount) + (ManPowerCost*NumberCount);
            return EstimatedCost;
        }
        public void GetManfactureList()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from CarManufature_Table ", scon);
                scon.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "CarManufature_Table");
                int Count = ds.Tables["CarManufature_Table"].Rows.Count;
                for (int i = 0; i < Count; i++)
                {

                    Console.WriteLine("Car id: " + ds.Tables["CarManufature_Table"].Rows[i][0].ToString());
                    Console.WriteLine("CarModel Name: " + ds.Tables["CarManufature_Table"].Rows[i][1].ToString());
                    Console.WriteLine("Car Color: " + ds.Tables["CarManufature_Table"].Rows[i][2].ToString());
                    Console.WriteLine("Car TotalPrice: " + ds.Tables["CarManufature_Table"].Rows[i][3].ToString());
                    Console.WriteLine("Stock: " + ds.Tables["CarManufature_Table"].Rows[i][4].ToString());
                    Console.WriteLine("ProfitandLoss: " + ds.Tables["CarManufature_Table"].Rows[i][5].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertManfactureData()
        {
            CarManufactures carManufacture = new CarManufactures();
            try
            {
                Console.Write("Enter the CarId:");
                int CarId = int.Parse(Console.ReadLine());
                Console.Write("Enter the CarName:");
                string CarModelName = Console.ReadLine();
                Console.Write("Enter the CarColor:");
                string CarColor = Console.ReadLine();
                int CarEstimatedCost = carManufacture.TotalCostPrice();
                Console.WriteLine("Total Price:" + CarEstimatedCost);
                int Stock = carManufacture.TotalStock();
                Console.WriteLine("Stock:"+Stock);
                int ProfitandLoss = carManufacture.GetProfitandLoss();
                Console.WriteLine("profit and loss:"+ ProfitandLoss);
                string query1 = "INSERT INTO CarManufature_Table VALUES(" + CarId + ",'" + CarModelName + "','" + CarColor + "'," + CarEstimatedCost + "," + Stock + ","+ProfitandLoss+")";
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
