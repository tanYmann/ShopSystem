using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystem.Models
{
    [Table("Positions")]
    public class Position
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("ItemId")]
        public string ItemId { get; set; }        
        [Column("Qty")]
        public int Qty { get; set; }
        [Column("VersionId")]
        public string VersionId { get; set; }
        [Column("PricePerUnit")]
        public double PricePerUnit { get; set; }
        [Column("Price")]
        public double Price { get; set; }

        public double setPrice()
        {
            double price;
            price = this.Qty * this.PricePerUnit;
            return price;
        }
    }
}
