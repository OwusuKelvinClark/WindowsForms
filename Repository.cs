using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace JBPanel
{
    public class Repository
    {
        private static Repository instance;
        private static SQLiteConnection dbConnection;
        private static SQLiteCommand sqliteCommand;

        private Repository() { }

        /// <summary>Initializes the repository.</summary>
        /// <returns>Repository</returns>
        public static Repository initRepo()
        {
            if (instance == null)
            {
                instance = new Repository();
                instance.initialiseDB();
            }
            return instance;
        }

        /// <summary>Updates the employee data.</summary>
        /// <param name="emp">emp</param>
        public void updateEmployee(Employee emp)
        {
            dbConnection.Open();
            sqliteCommand.CommandText = @"
            update employees set nom = @nom, prenom = @prenom, email = @email, tel = @tel
            where id = @id";
            sqliteCommand.Parameters.AddWithValue("@nom",emp.Nom);
            sqliteCommand.Parameters.AddWithValue("@prenom",emp.Prenom);
            sqliteCommand.Parameters.AddWithValue("@email",emp.Email);
            sqliteCommand.Parameters.AddWithValue("@tel",emp.Tel);
            sqliteCommand.Parameters.AddWithValue("@id",emp.ID);
            sqliteCommand.Prepare();
            sqliteCommand.ExecuteNonQuery();
            dbConnection.Close();
        }

        /// <summary>Gets the employees.</summary>
        /// <returns>List&lt;Employee&gt;</returns>
        public List<Employee> GetEmployees()
        {
            dbConnection.Open();
            sqliteCommand.CommandText = "select * from employees";
            SQLiteDataReader dataReader = sqliteCommand.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while(dataReader.Read())
            {
                employees.Add(new Employee(id: dataReader.GetInt32(0),
                nom: dataReader.GetString(1), prenom: dataReader.GetString(2),
                email: dataReader.GetString(3), tel: dataReader.GetString(4)));
            }
            dataReader.Close();
            dbConnection.Close();
            return employees;
        }

        /// <summary>Gets the employee by id.</summary>
        /// <param name="employeId">The employe identifier.</param>
        /// <returns>Employee</returns>
        public Employee getEmployee(int employeId)
        {
            dbConnection.Open();
            sqliteCommand.CommandText = @"SELECT * FROM employees WHERE id = @id";
            sqliteCommand.Parameters.AddWithValue("@id", employeId);
            sqliteCommand.Prepare();
            SQLiteDataReader dataReader = sqliteCommand.ExecuteReader();
            dataReader.Read();
            Employee emp = new Employee(id: dataReader.GetInt32(0), 
                nom: dataReader.GetString(1), prenom: dataReader.GetString(2),
                email: dataReader.GetString(3), tel: dataReader.GetString(4));
            dataReader.Close();
            dbConnection.Close();
            return emp;
        }

        /// <summary>Inserts a new employee.</summary>
        /// <param name="employee">employee</param>
        public void insertEmployee(Employee employee)
        {
            dbConnection.Open();
            sqliteCommand.CommandText = @"
            INSERT INTO employees(nom, prenom, email, tel) 
            values(@nom, @prenom, @email, @tel)";
            sqliteCommand.Parameters.AddWithValue("@nom", employee.Nom);
            sqliteCommand.Parameters.AddWithValue("@prenom", employee.Prenom);
            sqliteCommand.Parameters.AddWithValue("@email", employee.Email);
            sqliteCommand.Parameters.AddWithValue("@tel", employee.Tel);
            sqliteCommand.Prepare();
            sqliteCommand.ExecuteNonQuery();
            dbConnection.Close();
        }

        /// <summary>Deletes an employee.</summary>
        /// <param name="employeeId">The employee identifier.</param>
        public void deleteFromEmployee(int employeeId)
        {
            dbConnection.Open();
            sqliteCommand.CommandText = @"DELETE FROM employees WHERE id = @id";
            sqliteCommand.Parameters.AddWithValue("@id", employeeId);
            sqliteCommand.Prepare();
            sqliteCommand.ExecuteNonQuery();
            dbConnection.Close();
        }

        /// <summary>Initialises the database.</summary>
        private void initialiseDB()
        {
            dbConnection = new SQLiteConnection("Data Source=app.db");
            dbConnection.Open();
            sqliteCommand = new SQLiteCommand(dbConnection);
            sqliteCommand.CommandText = @"CREATE TABLE IF NOT EXISTS 
            employees(id INTEGER PRIMARY KEY AUTOINCREMENT, nom TEXT NOT NULL,
            prenom TEXT NOT NULL, email TEXT, tel TEXT)";
            sqliteCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}
