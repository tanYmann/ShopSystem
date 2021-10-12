using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ShopSystem.Models
{   
    [Table("Items")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [Column("ItemNo")]
        public string ItemNo { get; set; }
        [Column("ItemName")]
        public string ItemName { get; set; }
        [Column("VersionId")]
        public int? VersionId { get; set; }
        [Column("Ean")]
        public string Ean { get; set; }
        [Column("OnStock")]
        public bool OnStock { get; set; }
        [Column("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }
    }
}
