using PosTest.Proxy;
using System;
using System.Linq;

namespace PosTest.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new PosDeploymentDefaultProxy();
            string x = "";
            if (args.Count() == 0)
            {
                x = "0";
            }
            else
            {
                x = args[0];
            }
            c.ClientDataValue = Convert.ToInt32(x);
            Console.WriteLine(c.GetData);
        }
    }
}
