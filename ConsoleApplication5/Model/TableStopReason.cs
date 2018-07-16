using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication5.Model
{
    [Table("TablesStopReason")]
    public class TableStopReason
    {
        [Key]
        public int intStopReason { get; set; }

        [StringLength(255)]
        public string strReason { get; set; }
    }
}
