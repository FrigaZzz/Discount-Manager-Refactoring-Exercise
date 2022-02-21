using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v4.model
{
    public class Item
    {
        private readonly decimal _price;

        public Item(int price)
        {
            _price = price;
        }
        public decimal Price
        {
            get { return _price; }
        }
    }
}
