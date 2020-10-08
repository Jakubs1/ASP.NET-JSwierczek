using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class TestRepository : ITestRepository
    {
        public IEnumerable<TestModel> GetItems()
        {
            return new List<TestModel>() {

            new TestModel {ProductName = "banan", ProductDescription = "owoc", ProductPrice = 2.50m },
            new TestModel { ProductName = "pomidor", ProductDescription = "warzywo", ProductPrice = 1m },
            new TestModel { ProductName = "pieprz", ProductDescription = "przyprawa", ProductPrice = 1.50m },
            new TestModel { ProductName = "tabasko", ProductDescription = "sos", ProductPrice = 4.50m },

            };
        }
    }
}
