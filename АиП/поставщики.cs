using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Postavhick
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}

public class ProductMove
{
    public int ProductId { get; set; }
    public int PostavhickId { get; set; }
    public string DeliverDate { get; set; }
    public int Kolvo { get; set; }
    public int Price { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "хачапури" },
            new Product { Id = 2, Name = "чурчхелла" }
        };

        var suppliers = new List<Postavhick>
        {
            new Postavhick { Id = 1, Name = "узбек", Phone = "8945346111" },
            new Postavhick { Id = 2, Name = "ахмед", Phone = "5345765233" }
        };

        var productMovements = new List<ProductMove>
        {
            new ProductMove { ProductId = 1, PostavhickId = 1, DeliverDate = "20.01.2011", Kolvo = 50, Price = 1500 },
            new ProductMove { ProductId = 1, PostavhickId = 2, DeliverDate = "31.03.2020", Kolvo = 20, Price = 300 },
            new ProductMove { ProductId = 2, PostavhickId = 1, DeliverDate = "22.03.2021", Kolvo = 10, Price = 100 }
        };

        //товары по поставщикам с общей суммой
        var productsBySuppliers = productMovements
            .Join(products, 
                movement => movement.ProductId, 
                product => product.Id, 
                (movement, product) => new { movement, product })
            .Join(suppliers, 
                temp => temp.movement.PostavhickId, 
                supplier => supplier.Id, 
                (temp, supplier) => new { temp.movement, temp.product, supplier })
            .GroupBy(x => new 
            { 
                PostavhickId = x.supplier.Id, 
                SupplierName = x.supplier.Name, 
                ProductId = x.product.Id, 
                ProductName = x.product.Name 
            })
            .Select(g => new 
            { 
                Postavhick = g.Key.SupplierName, 
                Product = g.Key.ProductName, 
                TotalAmount = g.Sum(x => x.movement.Kolvo * x.movement.Price) 
            });

        Console.WriteLine("Товары по поставщикам:");
        foreach (var item in productsBySuppliers)
        {
            Console.WriteLine($"Поставщик: {item.Postavhick}, Товар: {item.Product}, Сумма: {item.TotalAmount}");
        }

        // суммарная стоимость товаров по дате поставки
        var totalByDeliveryDate = from movement in productMovements
                                  group movement by movement.DeliverDate into grouped
                                  select new
                                  {
                                      DeliverDate = grouped.Key,
                                      TotalAmount = grouped.Sum(x => x.Kolvo * x.Price)
                                  };

        Console.WriteLine("\nСуммарная стоимость товаров по дате поставки:");
        foreach (var item in totalByDeliveryDate)
        {
            Console.WriteLine($"Дата: {item.DeliverDate}, Сумма: {item.TotalAmount}");
        }

        // поставщик с наибольшей суммой товаров
        var supplierWithMaxAmount = (from movement in productMovements
                                    join Postavhick in suppliers on movement.PostavhickId equals Postavhick.Id
                                    group movement by new { Postavhick.Id, Postavhick.Name } into grouped
                                    select new
                                    {
                                        Postavhick = grouped.Key.Name,
                                        TotalAmount = grouped.Sum(x => x.Kolvo * x.Price)
                                    })
                                    .OrderByDescending(x => x.TotalAmount)
                                    .FirstOrDefault();

        if (supplierWithMaxAmount != null)
        {
            Console.WriteLine($"\nПоставщик с наибольшей суммой товаров: {supplierWithMaxAmount.Postavhick}, Сумма: {supplierWithMaxAmount.TotalAmount}");
        }
    }
}