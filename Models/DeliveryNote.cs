using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystem.Models
{
    [Table("DeliveryNotes")]
    public class DeliveryNote
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Column("DeliveryNoteNo")]
        public int DeliveryNoteNo { get; set; }       
        
        [Column("CustomerId")]        
        public int CustomerId { get;  }
       
        [Column("OrderId")]
        public int OrderId { get;  }
       

      
    }
}
