using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystem.Models
{
    [Table("Addresses")]

    public class Address
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("AddressType")]
        public string AddressType { get; set; }
        [Column("Salutation")]
        public string Salutation { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Street")]
        public string Street { get; set; }
        [Column("HouseNo")]
        public int HouseNo { get; set; }
        [Column("Zip")]
        public int Zip { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("Country")]
        public string Country { get; set; }
        [Column("SavedFrom")]
        public int SavedFrom { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CustomerNo")]
        public int CustomerNo { get; set; }
    }
}
