using Assignment_10_Entity_Framework_DML.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Assignment_10_Entity_Framework_DML.Data;
using Assignment_10_Entity_Framework_DML.Models;
namespace Assignment_10_Entity_Framework_DML
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new BikeStoresContext();

            #region 1 - List all customers' first and last names along with their email addresses.
            //var customers1 = context.Customers
            //                        .Select(e => new { e.FirstName, e.LastName, e.Email })
            //                        .ToList();

            //foreach (var customer in customers1)
            //{
            //    Console.WriteLine($"Full Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}");
            //}
            #endregion

            #region 2 - Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).
            //var OrdersWithStaffMember = context.Orders.Where(e => e.StaffId == 3);
            //foreach (var order in OrdersWithStaffMember)
            //    Console.WriteLine($"orderId: {order.OrderId}, stuffId: {order.StaffId}");
            #endregion

            #region 3- Get all products that belong to a category named "Mountain Bikes".
            // If dont have navigation property us this ⬇️
            //var products =
            //    from p in context.Products
            //    join c in context.Categories on p.CategoryId equals c.CategoryId
            //    where c.CategoryName == "Mountain Bikes"
            //    select p;
            //var result = products.ToList();
            // -----------------------------------------------------------------------------------

            //var productWithCategoryMountainBikes = context.Products.Include(e =>  e.Category).Where(e => e.Category.CategoryName == "Mountain Bikes");
            //foreach ( var product in productWithCategoryMountainBikes )
            //    Console.WriteLine($"product: {product.ProductName}, categoryName: {product.Category.CategoryName}");
            #endregion

            #region 4-Count the total number of orders per store.
            //var orderCountByStore = context.Orders.GroupBy(e => e.Store).Select(e => new { store = e.Key.StoreName, count = e.Count() });
            //foreach (var order in orderCountByStore)
            //    Console.WriteLine($"store: {order.store} => Count: {order.count}");
            #endregion

            #region 5- List all orders that have not been shipped yet (shipped_date is null).
            //var ordersNotShipped = context.Orders.Where(e => e.ShippedDate == null);
            //foreach (var order in ordersNotShipped)
            //    Console.WriteLine($"orderId: {order.OrderId}, shippedDate: {order.ShippedDate}");
            #endregion

            #region 6- Display each customer’s full name and the number of orders they have placed.
            //var customerOrderCounts = context.Customers
            //    .Select(c => new
            //    {
            //        FullName = c.FirstName + " " + c.LastName,
            //        OrderCount = c.Orders.Count()
            //    });
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($"Customer: {customer.FullName}, Orders: {customer.OrderCount}");
            //}
            #endregion

            #region 7- List all products that have never been ordered (not found in order_items). what if i have all order_items with spcific customer
            //var productsNoOrder = context.Products.Where(e => !e.OrderItems.Any());
            //foreach (var product in productsNoOrder)
            //{
            //    Console.WriteLine($"product: {product.ProductName}");
            //}
            #endregion

            #region 8- Display products that have a quantity of less than 5 in any store stock.
            //var productLessThenFive = context.Products.Where(e => e.Stocks.Any(e => e.Quantity<5));
            //foreach (var product in productLessThenFive)
            //    Console.WriteLine($"product: {product.ProductName}");
            #endregion

            #region 9- Retrieve the first product from the products table.
            //var firstProduct = context.Products.First();
            //Console.WriteLine($"product: {firstProduct.ProductName}");
            #endregion

            #region 10- Retrieve all products from the products table with a certain model year.
            //int modelYear = 2016;
            //var productWithYear = context.Products.Where(e => e.ModelYear == modelYear);
            //foreach ( var product in productWithYear )
            //    Console.WriteLine($"product: {product.ProductName}, year: {product.ModelYear}");
            #endregion

            #region 11- Display each product with the number of times it was ordered.
            //var productsWithOrderCount = context.Products
            //    .Select(p => new
            //    {
            //        ProductName = p.ProductName,
            //        OrderCount = p.OrderItems.Count()
            //    })
            //    .ToList();
            //foreach ( var product in productsWithOrderCount )
            //    Console.WriteLine($"product: {product.ProductName}, Order Count: {product.OrderCount}");
            #endregion

            #region 12- Count the number of products in a specific category.
            //var productCategory = context.Products.Where(e => e.Category.CategoryName == "Mountain Bikes").GroupBy(e => e.Category.CategoryName).Select(e => new {category = e.Key, count = e.Count()});

            //foreach (var product in productCategory)
            //    Console.WriteLine($"categoryName: {product.category}, count: {product.count}");
            #endregion

            #region 13- Calculate the average list price of products.
            //var productAvgPrice = context.Products.Average(e => e.ListPrice);
            //    Console.WriteLine($"the avg of product is {productAvgPrice}");
            #endregion

            #region 14- Retrieve a specific product from the products table by ID.
            //var productForId = context.Products.Where(e=>e.ProductId == 1);
            //foreach (var product in productForId)
            //    Console.WriteLine($"productName: {product.ProductName}, productId: {product.ProductId}");
            #endregion

            #region 15- List all products that were ordered with a quantity greater than 3 in any order.
            //var products = context.Products
            //    .Where(p => p.OrderItems.Any(oi => oi.Quantity > 5))
            //    ;

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}");
            //    foreach (var item in product.OrderItems.Where(oi => oi.Quantity > 3))
            //    {
            //        Console.WriteLine($"   OrderId: {item.OrderId}, Quantity: {item.Quantity}");
            //    }
            //}
            #endregion

            #region 16- Display each staff member’s name and how many orders they processed.
            //var staffes = context.Staffs.Select(e => new{ fullName = e.FirstName + " " + e.LastName, count = e.Orders.Count() });
            //foreach (var staff in staffes)
            //    Console.WriteLine($"staffName: {staff.fullName}, orderQuantity: {staff.count}");
            #endregion

            #region 17- List active staff members only (active = true) along with their phone numbers.
            //var activeStaff = context.Staffs.Where(e => e.Active == 1).Select(e => e.Phone);
            //foreach (var staff in activeStaff)
            //    Console.WriteLine($"phoneNumber: {staff}");
            #endregion

            #region 18- List all products with their brand name and category name.
            //var productWithBrandAndCategory = context.Products.Select(p => new {productName = p.ProductName, brandName = p.Brand.BrandName, categoryName = p.Category.CategoryName});
            //foreach (var product in productWithBrandAndCategory)
            //    Console.WriteLine($"ProductName: {product.productName}, BrandName: {product.brandName}, CategoryName: {product.categoryName}");
            #endregion

            #region 19- Retrieve orders that are completed.
            //var orderCompleted = context.Orders.Where(e => e.OrderStatus == 1);
            //foreach (var order in orderCompleted)
            //    Console.WriteLine($"order: {order.OrderId}, status: {order.OrderStatus}");
            #endregion

            #region 20- List each product with the total quantity sold (sum of quantity from order_items).
            //var productSales = context.Products
            //    .Select(p => new
            //    {
            //        ProductName = p.ProductName,
            //        TotalQuantitySold = p.OrderItems.Sum(oi => (int?)oi.Quantity) ?? 0
            //    })
            //    .ToList();

            //foreach (var product in productSales)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Total Sold: {product.TotalQuantitySold}");
            //}
            #endregion





        }
    }
}