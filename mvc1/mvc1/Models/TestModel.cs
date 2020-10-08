using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class TestModel
    {
        public string ProductName
        {
            get;
            set;
        }

        public string ProductDescription
        {
            get;
            set;
        }

        public decimal ProductPrice
        {
            get;
            set;
        }
    }
}
