using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatesPrac obj = new DelegatesLearning.DelegatesPrac();
            //obj.Test();
            //obj.Test2();

            /*
            EmployeeManagement empObj = new EmployeeManagement();

            empObj.MyLogger = LogDataInFile;
            empObj.MyLogger += ConsoleWriter;

            empObj.SaveData();
            */

            /*
            NotificationManagement notObj = new NotificationManagement();
            notObj.InventoryToZero = delegate () {
                Console.WriteLine("You are trying without inventory");
            };
            notObj.InventoryToTen = delegate (int count)
            {
                Console.WriteLine("Your inventory is {0}", count);
            };
            notObj.SaleProduct();
            for (int i = 0; i < 15; i++)
            {
                notObj.PurchaseProduct();
            }
            */



            //Delegate Usage Examples
            int[] data = { 5, 10, 20, 30 };
            var result = Array.Find(data, (x => x % 4 == 0));

            System.Console.ReadKey();

        }

        public static void LogDataInFile(String s)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"d:\a.txt"))
            {
                writer.WriteLine(s);
            }
        }

        public static void ConsoleWriter(String s)
        {
            System.Console.WriteLine(s);
        }
    }
}
