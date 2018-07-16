using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication5.Model;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (mcsContext db = new mcsContext())
            {
                foreach (var stopReason in db.TableStopReason)
                {
                    Console.WriteLine(stopReason.intStopReason + " " + stopReason.strReason);
                }
            }
        }
    }
}
