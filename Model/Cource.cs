using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_CORE_DEMO.Model
{
    [Table("Cource")]
    public class Cource
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fees { get; set; }
    }
}
