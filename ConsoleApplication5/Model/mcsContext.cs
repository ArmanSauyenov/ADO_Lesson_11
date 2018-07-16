using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication5.Model
{
    class mcsContext : DbContext
    {
        public mcsContext() : base("name=MCS")
        {
                
            
        }

        public virtual DbSet<TableStopReason> TableStopReason { get; set; }
    }
}
