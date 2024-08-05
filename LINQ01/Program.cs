using static LINQ01.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region 1.Find all products that are out of stock.
            //var products = ProductsList.Where(P => P.UnitsInStock == 0);
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 2.Find all products that are in stock and cost more than 3.00 per unit.
            var products = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            #endregion

            #endregion
        }
    }
}
