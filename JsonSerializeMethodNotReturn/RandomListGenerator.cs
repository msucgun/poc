using Bogus;

namespace JsonSerializeMethodNotReturn
{
    internal class RandomListGenerator
    {
        public List<Dto> GenerateDtoList(int itemCount)
        {
            var faker = new Faker<Dto>("tr").Rules((f, x) => {
                x.Field1 = f.Random.Int(1, int.MaxValue);
                x.Field2 = f.Random.Int(1, int.MaxValue);
                x.Field3 = f.PickRandom(new List<string> { "AA", "AB", "AC", "AD", "AE", "AF", "BA", "BB", "BC", "BD", "BE", "BF", "CA", "CB", "CC", "CD", "CE", "CF", "DA", "DB", "DC", "DD", "DE", "DF", "EA", "EB", "EC", "ED", "EE", "EF", "FA", "FB", "FC", "FD", "FE", "FF" });
                x.Field4 = f.Random.Int(1, 1000);
                x.Field5 = f.Random.Long(1, int.MaxValue);
                x.Field6 = Math.Round(f.Random.Decimal(15.0M, 8000.99M), 2);
                x.Field7 = Math.Round(f.Random.Decimal(15.0M, 8000.99M), 2);
                x.Field8 = Math.Round(f.Random.Decimal(15.0M, 8000.99M), 2);
                x.Field9 = Math.Round(f.Random.Decimal(15.0M, 8000.99M), 2);
                x.Field10 = Math.Round(f.Random.Decimal(15.0M, 8000.99M), 2);
                x.Field11 = Math.Round(f.Random.Decimal(15.0M, 8000.99M), 2);
                x.Field12 = Math.Round(f.Random.Decimal(0.0M, 0.8M), 1);
                x.Field13 = DateTimeOffset.Now.AddSeconds(f.Random.Int(0, 5184000));
                x.Field14 = DateTimeOffset.Now.AddSeconds(f.Random.Int(0, 7776000));
                x.Field15 = DateTimeOffset.Now.AddSeconds(f.Random.Int(0, 5184000));
                x.Field16 = DateTimeOffset.Now.AddSeconds(f.Random.Int(0, 7776000));
                x.Field17 = f.PickRandom(new List<int> { 1, 2, 3, 4 });
                x.Field18 = DateTime.Now.AddSeconds(-1 * f.Random.Int(0, 86400));
                x.Field19 = DateTime.Now.AddSeconds(-1 * f.Random.Int(0, 86400));
                x.Field20 = f.Random.Int(1, 50000);
                x.Field21 = DateTime.Now.AddSeconds(-1 * f.Random.Int(0, 7776000));
            });

            var dtoList = faker.Generate(itemCount);
            return dtoList;
        }
    }
}
