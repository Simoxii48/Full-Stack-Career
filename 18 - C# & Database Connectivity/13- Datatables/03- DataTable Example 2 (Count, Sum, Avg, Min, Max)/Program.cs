using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a DataTable to hold employee data
            DataTable EmployeesDataTable = new DataTable();

            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));


            EmployeesDataTable.Rows.Add(1, "John Doe", "USA", 50000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Jane Smith", "UK", 60000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Sam Brown", "Canada", 55000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Nancy White", "Australia", 70000, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Mike Green", "USA", 65000, DateTime.Now);

            int EmployeesCount = EmployeesDataTable.Rows.Count;
            double TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty));
            double AverageSalary = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
            double MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", string.Empty));
            double MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("MAX(Salary)", string.Empty));

            Console.WriteLine("\nEmployees List :\n");

            foreach (DataRow RecordRow in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4} \t",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            Console.WriteLine("\nTotal Employees : {0}", EmployeesCount);
            Console.WriteLine("Total Salaries : {0}", TotalSalaries);
            Console.WriteLine("Average Salary : {0}", AverageSalary);
            Console.WriteLine("Minimum Salary : {0}", MinSalary);
            Console.WriteLine("Maximum Salary : {0}", MaxSalary);

        }
    }
}
