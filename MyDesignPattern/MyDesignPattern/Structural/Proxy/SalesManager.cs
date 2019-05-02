using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Structural.Proxy
{
    public class SalesManager : IManager
    {
        public string Work()
        {
            return "Sales Manager ready to Talk";
        }
    }
}
