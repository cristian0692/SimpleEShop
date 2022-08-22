using EShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EShopSystem.DAL
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            //categories
            var categories = new List<Category>()
            {
                new Category{ CategoryName = "Mobile"},
                new Category{ CategoryName = "Sport"},
                new Category{ CategoryName = "Books"},
            };
            //foreach (var c in categories)
            //{
            //    context.Categories.Add(c);
            //}

            //categories.ForEach(c => context.Categories.Add(c));
            context.Categories.AddRange(categories);
            context.SaveChanges();
            //products
            var products = new List<Product>()
            {
                new Product {ProductName = "Galaxy Note 6",ProductPrice = 2500f,ProductStock = 2100,CategoryId = 1},
                new Product {ProductName = "Asus Note N73",ProductPrice = 11800f,ProductStock = 9100,CategoryId = 1},
                new Product {ProductName = "Samsung Buds S4",ProductPrice = 500f,ProductStock = 350,CategoryId = 1},
                new Product {ProductName = "Ball",ProductPrice = 500f,ProductStock = 70,CategoryId = 2},
                new Product {ProductName = "T-Shirt",ProductPrice = 100f,ProductStock = 750,CategoryId = 2},
                new Product {ProductName = "Box Gloves",ProductPrice = 820f,ProductStock = 750,CategoryId = 2},
                new Product {ProductName = "WarZ",ProductPrice = 220f,ProductStock = 150,CategoryId = 3},
                new Product {ProductName = "Putin and others",ProductPrice = 320f,ProductStock = 250,CategoryId = 3},
                new Product {ProductName = "SSSR 2.0 Origin",ProductPrice = 520f,ProductStock = 750,CategoryId = 3},
            };
            context.Products.AddRange(products);
            context.SaveChanges();
            //departaments
            var departaments = new List<Departament>()
            {
                new Departament{ DepartamentName = "IT",DepartamentIsActtive = true},
                new Departament{ DepartamentName = "Administration",DepartamentIsActtive = true},
                new Departament{ DepartamentName = "Sales",DepartamentIsActtive = true},
                new Departament{ DepartamentName = "Security",DepartamentIsActtive = true},
                new Departament{ DepartamentName = "Accounting",DepartamentIsActtive = true},
            };
            context.Departaments.AddRange(departaments);
            context.SaveChanges();


            //employees
            var employees = new List<Employee>()
            {
                new Employee {EmployeeName = "Jon Doe",EmployeeMobile="12345",EmployeeEmail="JonD@mail.ru",DepartamentId= 2},
                new Employee {EmployeeName = "Will Smith",EmployeeMobile="78345",EmployeeEmail="WillS@mail.ru",DepartamentId= 2},
                new Employee {EmployeeName = "Julia Dove",EmployeeMobile="22387",EmployeeEmail="JuliaD@mail.ru",DepartamentId= 2},
                new Employee {EmployeeName = "Grace Dolloris",EmployeeMobile="57945",EmployeeEmail="Grace@mail.ru",DepartamentId= 2},
                new Employee {EmployeeName = "Kristof Kraft",EmployeeMobile="94345",EmployeeEmail="K2@mail.ru",DepartamentId= 2},
            };
            context.Employees.AddRange(employees);
            context.SaveChanges();
        }


    }
}