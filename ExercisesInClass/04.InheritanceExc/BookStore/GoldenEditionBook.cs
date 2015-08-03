using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore
{
    public class GoldenEditionBook:Book
    {
        private const double OverValue = 0.3;
        public GoldenEditionBook(string title, string author, double price) 
            : base(title, author, price)
        {
        }

        public override double Price
        {
            get { return base.Price + OverValue*base.Price; }
        }
    }
}
