using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07__Datatable_Example_6__Update_Rows_
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

            Console.WriteLine("\nEmployees List :\n");

            foreach (DataRow RecordRow in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4} \t",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            // Update Employee ID 4
            DataRow[] Results = EmployeesDataTable.Select("ID=4");

            foreach(var ResultRow in Results)
            {
                ResultRow["Name"] = "Alae Jaber";
                ResultRow["Salary"] = 9000;
            }

            Console.WriteLine("\nEmployees List After Updating Employee ID 4\n");

            foreach (DataRow RecordRow in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4} \t",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }
        }
    }
}
