using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystem.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [Column("AddressId")]
        public int AddressId { get; set; }    
        [Column("Project")]
        public string Project{ get; set; }
        [Column("SaveDate")]
        public DateTime? SaveDate { get; set; }
        [Column("PositionId")]
        public List<Position> Positions { get; set; }

        static void auftragErstellen(int CUSTOMER_ID, int artikelNr)
        {

        }

        static void alleAuftraegeKundenId(int CUSTOMER_ID)
        {

        }

        static void auftragLesen(int CUSTOMER_ID,int ID)
        {

        }

        static void auftragLöschen(int CUSTOMER_ID,long auftragsNr)
        {

        }
    }      
}
   