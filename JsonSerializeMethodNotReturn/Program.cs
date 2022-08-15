using System.Text;
using System.Text.Json;

namespace JsonSerializeMethodNotReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomListGenerator = new RandomListGenerator();
            var itemCount = 2000000;
            Console.WriteLine($"Generating list for {itemCount:N0} items...");
            var prices = randomListGenerator.GenerateDtoList(itemCount);
            Console.WriteLine("Done.");

            Console.WriteLine("Performing serialization...");
            var priceJson = JsonSerializer.Serialize(prices);
            var priceJsonByteCount = Encoding.UTF8.GetByteCount(priceJson);
            Console.WriteLine($"Done. Byte count = {priceJsonByteCount:N0}");
        }
    }
}