using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSystem.Models
{
    [Table("Users")]
    public class User
    {
        public int CustomerNo { get; set; }

        public string Password { get; set; }
    }
}
