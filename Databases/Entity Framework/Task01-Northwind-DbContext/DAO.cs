namespace Task01_Northwind_DbContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 1. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
    /// 2. Create a DAO class with static methods which provide functionality for inserting, modifying and 
    /// deleting customers. Write a testing class.
    /// 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
    /// 5. Write a method that finds all the sales by specified region and period (start / end dates).

    /// </summary>
    class DAO
    {
        static void Main()
        {

            //add item with name and id
            //AddEntry("LOLBG", "League of Legends Bulgaria");

            //delete item by id
            //DeleteEntry("LOLBG");
          
            //modify an item's name by it's id
            //ModifyEntry("LOLBG", "DOTA 2 Bulgaria");

            //ShipmentsToCanada();



            //var startDate = new DateTime(1990, 10, 20);
            //var endDate = new DateTime(2014, 8, 10);
            //string region = "RJ";
            //FindSalesByRegionAndDate(region, startDate, endDate);
        }

        static void AddEntry(string id, string name)
        {
            var database = new NorthwindEntities();

            using (database)
            {
                if (EntryExists(database, id))
                {
                    Console.WriteLine("There is already an entry with the same ID");
                }
                else
                {
                    var newCustomer = new Customer()
                    {
                        CustomerID = id,
                        CompanyName = name
                    };

                    database.Customers.Add(newCustomer);
                    database.SaveChanges();
                    Console.WriteLine("Entry successfully added.");
                }
            }
        }

        static void DeleteEntry(string id)
        {
            var database = new NorthwindEntities();

            using (database)
            {
                if (EntryExists(database, id))
                {
                    var itemToDelete = database.Customers.Where(c => c.CustomerID == id).First();
                    database.Customers.Remove(itemToDelete);
                    database.SaveChanges();
                    Console.WriteLine("Entry successfully deleted.");
                }
                else
                {
                    Console.WriteLine("Item with the id \"{0}\" does not exist in the database.", id);
                }
            }
        }

        static void ModifyEntry(string id, string newName)
        {
            var database = new NorthwindEntities();

            using (database)
            {
                if (EntryExists(database, id))
                {
                    var itemToDelete = database.Customers.Where(c => c.CustomerID == id).First();
                    itemToDelete.CompanyName = newName;
                    database.SaveChanges();
                    Console.WriteLine("Entry successfully modified.");
                }
                else
                {
                    Console.WriteLine("Item with the id \"{0}\" does not exist in the database.", id);
                }
            }
        }

        static bool EntryExists(NorthwindEntities database, string id)
        {
            return database.Customers.Where(c => c.CustomerID == id).Any();
        }


        private static void ShipmentsToCanada()
        {
            var database = new NorthwindEntities();

            using (database)
            {
                var groupedCustomersAndOrders = database.Customers.Join(
                    database.Orders,
                    c => c.CustomerID,
                    d => d.CustomerID,
                    (c, d) => new
                    {
                        Name = c.CompanyName,
                        OrderDate = d.OrderDate,
                        ShipmentCountry = d.ShipCountry
                    });

                var items = groupedCustomersAndOrders
                    .Where(i => i.OrderDate.Value.Year == 1997)
                    .Where(i => i.ShipmentCountry == "Canada");

                foreach (var item in items)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        private static void FindSalesByRegionAndDate(string region, DateTime start, DateTime end)
        {
            var database = new NorthwindEntities();

            using (database)
            {
                var sales = database.Orders.Where(
                        o => o.ShipRegion == region &&
                            o.OrderDate > start &&
                            o.OrderDate < end
                    ).Select(
                        o => new
                        {
                            ShipName = o.ShipName,
                            OrderDate = o.OrderDate
                        });

                foreach (var item in sales)
                {
                    Console.WriteLine("Ship Name: {0}", item.ShipName);
                    Console.WriteLine("Order Date: {0}", item.OrderDate);
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
}
