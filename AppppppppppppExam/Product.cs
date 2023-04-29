using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AppppppppppppExam
{
    public class Product
    {
        private double _price;
        private string _name;
        private string _description;
        public Product(double price, string name, string description)
        {
            _price = price;
            _name = name;
            _description = description;
        }
        public double Price
        { 
            get => _price;
        }
        public string Name
        { 
            get => _name; 
        }
        public string Description
        {
            get => _description;
        }
    }
}
