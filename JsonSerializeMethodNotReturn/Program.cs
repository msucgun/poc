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
            var items = randomListGenerator.GenerateDtoList(itemCount);
            Console.WriteLine("Done.");

            Console.WriteLine("Performing serialization...");
            var itemsJson = JsonSerializer.Serialize(items);
            var itemsJsonByteCount = Encoding.UTF8.GetByteCount(itemsJson);
            Console.WriteLine($"Done. Byte count = {itemsJsonByteCount:N0}");
        }
    }
}