using System.Collections.Generic;

namespace mvc1.Models
{
    public interface ITestRepository
    {
        IEnumerable<TestModel> GetItems();
    }
}