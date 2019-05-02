using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Structural.Proxy
{
    public class ProxyManager : IManager
    {
        private bool bBusy = false;
        private SalesManager salesMgrObj = null;

        public string Work()
        {
            Console.WriteLine("Proxy checking for sales manager availability...");

            if (!this.bBusy)
            {
                this.salesMgrObj = new SalesManager();
                System.Threading.Thread.Sleep(2000);
                return this.salesMgrObj.Work();
            }
            else
            {
                System.Threading.Thread.Sleep(2000);
                return "Sales manager is busy";
            }
        }
    }
}
