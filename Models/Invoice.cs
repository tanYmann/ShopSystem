using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystem.Models
{
    [Table("Invoices")]
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int ID { get; set; }
        [Column("InvoiceNo")]
        public int InvoiceNo { get; set; }            
        [Column("OrderId")]
        public int OrderId { get; }     
        [Column("CustomerId")]
        public int CustomerId { get;  }      
        [Column("InvoiceDate")]
        public DateTime InvoiceDate { get; set; }
       
       

    }
}
