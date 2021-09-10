using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace MysqlConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<========== Establishing MYSQL database connection =======>");
            string conString = "Server=localhost;Database=sample;uid=kym;pwd=Kym_2021*";
            MySqlConnection conn = new MySqlConnection(conString);

            try {
                MySqlCommand command = new MySqlCommand("SELECT * FROM employee e");
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                conn.Open();

                MySqlDataReader dataAdapter = command.ExecuteReader();
                Console.WriteLine("IDENTITY \t EMPLOYEE NAME \t SALARY \t DATE CREATED ");
                while (dataAdapter.Read())
                {
                    Console.WriteLine($"{dataAdapter.GetString("id")} \t\t {dataAdapter.GetString("name")} \t\t {dataAdapter.GetString("salary")} \t\t {dataAdapter.GetString("date_added")}");
                }
                dataAdapter.Close();
                Console.WriteLine("<========= Done Reading records ========>");
                
            } catch (Exception e) {
                Console.WriteLine("!!!! Could not open database connection !!!!!" + e);
            } finally {
                conn.Close();
            }
        }
    }
}