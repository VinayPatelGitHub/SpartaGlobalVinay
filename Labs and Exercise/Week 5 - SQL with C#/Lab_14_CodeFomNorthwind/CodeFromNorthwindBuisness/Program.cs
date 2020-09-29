using CodeFromNorthwindModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFromNorthwindBuisness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //var newCustomer = new Customers()
                //{
                //    CustomerId = "MAND",
                //    ContactName = "Nish Mandal",
                //    CompanyName = "ToysRUs"
                //};

                //db.Customers.Add(newCustomer);

                //db.SaveChanges();

                //Select * FROM customers WHERE CustomerId = 'MAND'; //?

                //var selectedCustomer = db.Customers.Where(c => c.CustomerId == "MAND").FirstOrDefault();

                //selectedCustomer.City = "Paris";

                //db.Customers.Remove(selectedCustomer);

                //db.SaveChanges();



                ////Tuesday 25th August

                ////Query syntax
                //var query1 =
                //    from c in db.Customers
                //    where c.City == "London"
                //    orderby c.ContactName
                //    select c;
                ////Method suntax
                //var query1 = db.Customers.Where(c => c.City == "London").OrderBy(c => c.ContactName);
                ////for both
                //foreach (var item in query1)
                //{
                //    Console.WriteLine(item);
                //}


                //var londBerlinQuery =
                //    from c in db.Customers
                //    where c.City == "London" || c.City == "Berlin"
                //    select new { CustomerID = c.CustomerId, Name = c.ContactName, City = c.City};
                //foreach (var item in londBerlinQuery)
                //{
                //    Console.WriteLine($"{item.CustomerID}, {item.Name}, {item.City}");
                //}


                //// query syntax
                //var ordersPrductsByUniInStockQuesry =
                //    from p in db.Products
                //    group p by p.SupplierId into newGroup
                //    select new //creating and anonymous object
                //    {
                //        SuppierID = newGroup.Key,
                //        UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
                //    };
                //// In SQL:
                ////SELECT SUM(UnitsInStock), SupplierID
                ////FROM Products
                ////GROUP BY SupplierID
                //foreach (var item in ordersPrductsByUniInStockQuesry)
                //{
                //    Console.WriteLine($"{item}");
                //}
                //// method syntax - show us later...


                //var orderby = 
                //    from p in db.Products
                //    orderby p.UnitPrice descending
                //    select new { UnitPrice = p.UnitPrice };
                //    //select new { UnitPrice = MAth.Round(p.UnitPrice) };
                //foreach (var item in orderby)
                //{
                //    Console.WriteLine(item);
                //}


                //var newCustomer = new Customers()
                //{
                //    CustomerId = "LENN",
                //    ContactName = "John Lennon",
                //    CompanyName = "The Beatles"
                //};
                //db.Customers.Add(newCustomer);
                //db.SaveChanges();



                //var selectBeatle =
                //    from c in db.Customers
                //    where c.CustomerId == "LENN"
                //    select c;
                //foreach (var item in selectBeatle)
                //{
                //    item.City = "Livepool";
                //}
                //db.SaveChanges();



                //var selectBeatle =
                //    from c in db.Customers
                //    where c.CustomerId == "LENN"
                //    select c;
                //foreach (var item in selectBeatle)
                //{
                //    db.Customers.Remove(item);
                //}
                //db.SaveChanges();


                //After Lunch - Lambda Expressions
                //goes to?
                //var query1 = db.Customers.Select(c => c.ContactName);
                //foreach (var c in db.Customers)
                //{
                //    Console.WriteLine(aMethod(c));
                //}

                ////querys by methods
                //var custQuery2 = db.Customers.Where(c => c.City == "Berlin");
                //var custQuery1 = db.Products.OrderBy(P => P.ReorderLevel).ThenByDescending(P => P.QuantityPerUnit);


                //var CustomerNish = new Customers()
                //{
                //    CustomerId = "Mamda",
                //    ContactName = "Nish mandal",
                //    CompanyName = "Sparta global"
                //};
                //db.Customers.Add(CustomerNish);                
                //var readCustomer = db.Customers.Where(c => c.CustomerId == "BONAP");
                //foreach(var c in readCustomer)
                //{
                //    Console.WriteLine(c);
                //}
                //var selectedCustomer = db.Customers.Where(c => c.CustomerId == "phil1");
                //foreach (var item in selectedCustomer)
                //{
                //    db.Customers.Remove(item);
                //}
                //db.SaveChanges();
                //db.Remove(db.Customers.Where(c => c.CustomerId == "phil1").FirstOrDefault());
                //db.Remove(selectedCustomer.FirstOrDefault());
                //var selectedCustomer2 = db.Customers.Find("phil1");
                //db.Remove(selectedCustomer2);
                //db.SaveChanges();
                //db.Customers.Find("Phil1").CompanyName = "Sparta Global";
                //var updateQ = db.Customers.Where(c => c.CustomerId == "phil1").FirstOrDefault();
                //updateQ.CompanyName = "Sparta Global";


                ///////JOINS
                // includes are oop
                // joins are relational 
                //var orderQuery =
                //    from o in db.Orders.Include(o => o.Customer).Include(o=>o.Employee)
                //    where o.Freight > 750
                //    select o;
                //foreach (var o in orderQuery)
                //{
                //    Console.WriteLine($"{o.Customer.ContactName} of {o.Customer.City} paid {o.Freight} for shipping, emplyee: {o.Employee.FirstName}" );
                //}

                ////LazyLoading - by default we load 

                //var orderQusingInerJoin =
                //    from order in db.Orders
                //    join customer in db.Customers on order.CustomerId equals customer.CustomerId
                //    where order.Freight > 750
                //    select new { CustomerContactName = customer.ContactName, City = customer.City, Freight = order.Freight };
                //foreach (var o in orderQusingInerJoin)
                //{
                //    Console.WriteLine($"{o.CustomerContactName} of {o.City} paid {o.Freight} for shipping.");
                //}



                /////hmwk
                //var x =
                //    from p in db.Products
                //    group p by p.CategoryId into categProds
                //    select new
                //    {
                //        categProds.Key,
                //        AvgPrice = categProds.Average(C => C.UnitPrice)
                //    };
                //foreach (var result in x)
                //{
                //    Console.WriteLine($"{result.Key} - {result.AvgPrice}");
                //}

                ////HMWK Mini Porject
                //Query Syntex
                var query1 =
                    from c in db.Customers
                    where c.City == "London" || c.City == "Paris"
                    orderby c.ContactName
                    select new { CustomerID = c.CustomerId, Name = c.ContactName, Address = $"{c.Address}, {c.City}, {c.Region}, {c.PostalCode}, {c.Country}" };
                //Display(query1);

                var query2 =
                    from c in db.Products.Where(c => c.QuantityPerUnit.Contains("Bottle"))
                    select new
                    { Product_name = c.ProductName, Quabtity_Per_Unit = c.QuantityPerUnit };
                //Display(query2);

                var query3 =
                    from products in db.Products.Where(c => c.QuantityPerUnit.Contains("Bottle"))
                    join suppliers in db.Suppliers on products.SupplierId equals suppliers.SupplierId
                    select new { Product_name = products.ProductName, Quabtity_Per_Unit = products.QuantityPerUnit, Supplier_Name = suppliers.CompanyName, Supplier_Country = suppliers.Country };
                ////Display(query3);

                var query4 =
                    from products in db.Products
                    join categories in db.Categories on products.CategoryId equals categories.CategoryId
                    group products by categories.CategoryName into newGroup
                    select new { Catergory_Name = newGroup.Key, CountCat = newGroup.Count() };
                //foreach (var item in query4)
                //{
                //    Console.WriteLine($"{item.Catergory_Name}, {item.CountCat}");
                //}

                var query5 =
                    from E in db.Employees
                    select new { Name = $"{E.TitleOfCourtesy} {E.FirstName} {E.LastName} ", Location = E.City };
                //Display(query5);

                //var query6 =
                //    from Region in db.Region
                //    join Territoires in db.Territories on Region.RegionId equals Territoires.RegionId
                //    join EmployeeTerritories in db.EmployeeTerritories on Territoires.TerritoryId equals EmployeeTerritories.TerritoryId
                //    join Orders in db.Orders on EmployeeTerritories.EmployeeId equals Orders.EmployeeId

                //    select new { Catergory_Name = newGroup.Key, CountCat = newGroup.Count() };


                var query7 =
                    from region in db.Region
                    join territoires in db.Territories on region.RegionId equals territoires.RegionId
                    join employeeTerritories in db.EmployeeTerritories on territoires.TerritoryId equals employeeTerritories.TerritoryId
                    join orders in db.Orders on employeeTerritories.EmployeeId equals orders.EmployeeId
                    //var emp2 = db.Orders.Where(o => o.EmployeeId == 2)
                    //group region by region.RegionDescription into newGroup
                    //select new { RegionDescription = newGroup.Key, orders. };
                    select new {orders.OrderId, orders.EmployeeId, region.RegionDescription};
                //foreach (var item in query7)
                //{
                //    Console.WriteLine($"{item.OrderId} {item.EmployeeId} {item.RegionDescription}");
                //}
                //Method Sntex








            }


            ////var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
            //int allCount = nums.Count();  //count 9
            //int countEven = 0;
            //foreach (var item in nums)
            //{
            //    if (isEven(item))
            //    {
            //        countEven++;
            //    }
            //}
            //static string aMethod(Customers c) 
            //{ 
            //    return c.ContactName; 
            //}
            //nums.Count(isEven);



            //List<Person> eng65 = new List<Person>
            //{
            //    new Person {Name = "Fazal", Age = 20},
            //    new Person {Name = "Hithaifa", Age = 55},
            //    new Person {Name = "Vinay", Age = 40}
            //};
            //var youngPeopleCount = eng65.Count(isYoung);
            //static bool isYoung(Person p)
            //{
            //    return p.Age < 30;
            //}

            //var peopleCount = eng65.Count();
            //var youngPeopleCount = eng65.Count(n => n.Age < 30);
            //var ageSum = eng65.Sum(nameof => nameof.Age);            
            //var oldpeeps = eng65.Sum(n => n.Age >= 30 ? n.Age : 0);
            //var oldpeep2s = eng65.Where(n => n.Age > 30).Sum(n => n.Age);



            //var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
            //var evenDCount = nums.Count(delegate (int n) { return n % 2 == 0; }); // don't use anaonomys methods
            //var evenLCount = nums.Count(n => n % 2 == 0);
            //var evenL2Count = nums.Where(n => n % 2 == 0).Count();






        }

        public static void Display(IQueryable query)
        {
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        //private static bool isEven(int n)
        //{
        //    return n % 2 == 0;
        //}
            

    }

    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}


}
