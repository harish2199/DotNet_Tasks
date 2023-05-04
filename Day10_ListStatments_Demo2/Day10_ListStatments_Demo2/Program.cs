namespace Day10_ListStatments_Demo2
{
    internal class Program
    {
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Brand { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            // Step 1. Define DataSource
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name="Laptop", Brand="Dell", Quantity=5, Price=46500},
                new Product { Id = 2, Name="Camera", Brand="Canon", Quantity=7, Price=32300},
                new Product { Id = 3, Name="Tablet", Brand="Lenovo", Quantity=2, Price=18500},
                new Product { Id = 4, Name="Desktop", Brand="HP", Quantity=9, Price=78200},
                new Product { Id = 5, Name="Earphones", Brand="Boat", Quantity=3, Price=3000},
                new Product { Id = 6, Name="Mobile", Brand="Apple", Quantity=4, Price=78200},
            };

            //Step 2. Write Query
            //get object by id (using list query)
            var query1 = from p in products where p.Id == 3 select p;
            
            //using lambda expression
            var query2 = products.Where(p => p.Id == 3); //where method gives list of items so we need to loop through it to print 
           
            //using find method 
            var query3 = products.Find(p => p.Id == 3); //find give only one item so we can directly print
            Console.WriteLine($"{query3.Id} {query3.Name} {query3.Brand} {query3.Quantity} {query3.Price}");
            
            //get items which have highest price
            var query4 = products.Where(x => x.Price == products.Max(p => p.Price));
            
            //By using where and we want only one value or first value then;
            var query5 = products.Where(x => x.Price == products.Max(p => p.Price)).FirstOrDefault();
            Console.WriteLine($"{query5.Id} {query5.Name} {query5.Brand} {query5.Quantity} {query5.Price}");


            //By using find give the highest price item
            var query6 = products.Find(x => x.Price == products.Max(p => p.Price));
            //find method gives only one value no matter if more than 1 item with same price
            //It give the first find item
            Console.WriteLine($"{query6.Id} {query6.Name} {query6.Brand} {query6.Quantity} {query6.Price}");

            var query7 = products.Max(p => p.Price);//Here max function only give the maximum price value not entire object
            Console.WriteLine($"{query7}");


            foreach (var item in query1)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
            }
        }
    }
}