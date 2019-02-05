using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLearning
{
    //Inversion of Control
    //Dependency Injection

    public delegate void LoggerDelegate(String s);
    public class EmployeeManagement
    {
        public LoggerDelegate MyLogger;
        public void SaveData()
        {
            //You are doing something here
            //You want to do logging BUT you want to 
            //give control "back" to "executor"

            if(MyLogger != null)
            {
                MyLogger("I am in SaveData");
            }
        }

        
    }
    
    public class NotificationManagement
    {
        public Action InventoryToZero;
        public Action<int> InventoryToTen;

        static int inventory_count = 0;
        public void SaleProduct()
        {
            if(inventory_count == 0)
            {
                if (InventoryToZero != null)
                    InventoryToZero();
            }
            else
            {
                //Do some activity
                inventory_count--;
            }
        }
        public void PurchaseProduct()
        {
            //Do some activity
            inventory_count++;
            if(inventory_count > 10) {
                if (InventoryToTen != null)
                    InventoryToTen(inventory_count);
            }
        }

    }


}
