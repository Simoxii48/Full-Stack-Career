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
            DataTable EmployeesDataTable = new DataTable("EmployeesDataTable"); // Add a name to the constructor to easy access later
            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "Mohammed Abu-Hadhoud", "Jordan", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Ali Maher", "KSA", 525.5, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Lina Kamal", "Jordan", 730.5, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Fadi JAmeel", "Egypt", 800, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Omar Mahmoud", "Lebanon", 7000, DateTime.Now);

            Console.WriteLine("\n Employees List : \n");
            foreach (DataRow RecordRow in EmployeesDataTable.Rows)
            {
                Console.WriteLine("EmployeeID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            DataTable DepartmentsDataTable = new DataTable("DepartmentsDataTable");
            DepartmentsDataTable.Columns.Add("DepartmentID", typeof(int));
            DepartmentsDataTable.Columns.Add("Name", typeof(string));

            DepartmentsDataTable.Rows.Add(1, "Marketing");
            DepartmentsDataTable.Rows.Add(2, "IT");
            DepartmentsDataTable.Rows.Add(3, "HR");

            Console.WriteLine("\n Departments List : \n");
            foreach (DataRow RecordRow in DepartmentsDataTable.Rows)
            {
                Console.WriteLine("DepartmentID: {0}\t Name : {1} ",
                    RecordRow["DepartmentID"], RecordRow["Name"]);
            }

            // Create DataSet
            DataSet DataSet1 = new DataSet();

            // Add DataTables to the DataSet
            DataSet1.Tables.Add(EmployeesDataTable);
            DataSet1.Tables.Add(DepartmentsDataTable);

            // Print Employees List from DataSet
            Console.WriteLine("\n Employees List from the DataSet: \n");
            foreach (DataRow RecordRow in DataSet1.Tables["EmployeesDataTable"].Rows) // Access it by the name initialized with the constructor
            {
                Console.WriteLine("EmployeeID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            // Print Departments list from DataSet
            Console.WriteLine("\n Departments List from the DataSet: \n");
            foreach (DataRow RecordRow in DataSet1.Tables["DepartmentsDataTable"].Rows)
            {
                Console.WriteLine("DepartmentID: {0}\t Name : {1} ",
                    RecordRow["DepartmentID"], RecordRow["Name"]);
            }

            Console.ReadLine();
        }
    }
}
