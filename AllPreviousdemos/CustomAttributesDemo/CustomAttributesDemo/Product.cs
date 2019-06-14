using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
    [DevInfo("SYP", 1.0)]
    public class Product
    {
        private int productCode;
        private string productName;

        public Product()
        {
            productCode = 1;
            productName = "abc";
        }

        public Product(int productCode, string productName)
        {
            this.productCode = productCode;
            this.productName = productName;
        }

        public override string ToString()
        {
            return string.Format("Code -{0}]\t Name-{1}\t", this.productCode, this.productName);
        }
    }
}
