using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystem.Models
{
    [Table("Customers")]
    public class Customer 
    {   
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }        
        [Column("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }       
        [Column("AddressId")]
        public int AddressId { get; }
        [ForeignKey("AddressId")]
        public virtual Address Addresses { get; set; }
        [Column("Options")]
        public int Options { get; set; }
        [Column("Gln")]
        public string Gln { get; set; }
        [Column("GrpStat5")]
        public string GrpStat5 { get; set; }
       

    }
}