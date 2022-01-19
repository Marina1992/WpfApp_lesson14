using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public enum ProductTypes
    {
        Food,
        Tech
    }



    public class Product
    {
        public string Name { get; set; }

        public int Sale { get; set; }

        public int Pict { get; set; }

        public ProductTypes ProductType { get; set; }


    }
}
