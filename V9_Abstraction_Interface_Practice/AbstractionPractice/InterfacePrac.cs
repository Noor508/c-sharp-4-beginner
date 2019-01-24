using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    //Instance of 'interface' can't be created but 'Reference Variable' can be created
    //Abstract class may have 0 or more 'abstract' methods
    interface IGeneral
    {
        void ShowMe();
    }
    //An interface can inherit andother interface
    interface ICustomDatabase : IGeneral
    {
        void OpenConnection();
        void CloseConnection();
        void ExecuteQuery(String query);

    }

    //CustomSqlDatabase class will implement 'ICustomDatabase' & 'IGeneral'
    class CustomSqlDataBase : ICustomDatabase
    {
        private String _connString;

        public void ShowMe() {
            Console.WriteLine("CustomSqlDataBase.ShowMe");
        }
        public CustomSqlDataBase(String connString)
        {
            Console.WriteLine("CustomSqlDataBase.CustomSqlDataBase()");
            _connString = connString;
        }
        public void OpenConnection()
        {
            Console.WriteLine("CustomSqlDataBase.OpenConnection()");
        }
        public void CloseConnection()
        {
            Console.WriteLine("CustomSqlDataBase.CloseConnection()");
        }
        public void ExecuteQuery(string query)
        {
            Console.WriteLine("CustomSqlDataBase.ExecuteQuery()");
        }

    }

    class CustomMySqlDataBase : ICustomDatabase
    {
        private String _connString;

        public void ShowMe()
        {
            Console.WriteLine("CustomMySqlDataBase.ShowMe");
        }
        public CustomMySqlDataBase(String connString)
        {
            Console.WriteLine("CustomMySqlDataBase.CustomMySqlDataBase()");
            _connString = connString;
        }
        public void OpenConnection()
        {
            Console.WriteLine("CustomMySqlDataBase.OpenConnection()");
            //connection open logic of SqlServer
        }
        public void CloseConnection()
        {
            Console.WriteLine("CustomMySqlDataBase.CloseConnection()");
        }
        public void ExecuteQuery(string query)
        {
            Console.WriteLine("CustomMySqlDataBase.ExecuteQuery()");
        }
    }
    
    //This class will perform database related operations using provided paramter (enum)
    class CustomerDAL
    {
        private ICustomDatabase database;

        public CustomerDAL(DataBaseTypes type)
        {
            Console.WriteLine("CustomerDAL.CustomerDAL()");

            if (type == DataBaseTypes.SqlDatabase)
                database = new CustomSqlDataBase("connection string for sql server db");
            else if (type == DataBaseTypes.MySqlDatabase)
                database = new CustomMySqlDataBase("connection string for sql server db");
        }
        public void SaveCustomer(String data)
        {
            //Here database will call the function based on the object provided to it constructor
            Console.WriteLine("CustomerDAL.SaveCustomer()");
            database.OpenConnection();
            database.ExecuteQuery("Insert into etc etc");
            database.CloseConnection();
        }
        public void DeleteCustomer(String id)
        {
            Console.WriteLine("CustomerDAL.DeleteCustomer()");
            database.OpenConnection();
            database.ExecuteQuery("delete from etc etc");
            database.CloseConnection();
        }
    }

    //Enum to replace numbers as paramters
    enum DataBaseTypes
    {
        SqlDatabase = 1,
        MySqlDatabase = 2
    }

    //This is tester class to Test above classes
    public class Tester4
    {
        public static void Test()
        {
            Console.WriteLine("---------Tester4.Test() Start------------------");

            CustomerDAL[] dals = new CustomerDAL[2];

            dals[0] = new CustomerDAL(DataBaseTypes.SqlDatabase);
            dals[1] = new CustomerDAL(DataBaseTypes.MySqlDatabase);
           
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("-------------------------");
                dals[i].SaveCustomer("data");
            }

            Console.WriteLine("---------Tester4.Test() End------------------");
        }
    }
}
