namespace Day10_List_statments_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1. Define DataSource
            string[] fruits = { "Apple", "Banana", "Mango", "Cherry", "Avacado", "Grapes", "Lichi", "Watermelon", "Guava", "Pineapple" };
            //Standard process
            //foreach (var item in fruits)
            //{
            //    if (item.StartsWith('A'))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Using list queries
            //Step 2. Write Query
            var query1 = from f in fruits where f.StartsWith('A') select f; //returns elements starts with A
            var query2 = from f in fruits where f.Length%2== 0 select f;//returns element with even chars
            var query3 = from f in fruits orderby f select f;//sort in accending order
            var query4 = from f in fruits orderby f descending select f;//sort in descending order
            var query5 = from f in fruits where f.StartsWith('A') & f.EndsWith('e') select f;//gives element starts with A and ends with e 
            var query6 = from f in fruits where f.StartsWith('A') || f.EndsWith('e') select f;//gives element starts with A or ends with e 

            foreach (var f in query6)
            {
                Console.WriteLine(f);
            }
        }
    }
}