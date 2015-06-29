namespace Approach___Code_First_From_Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.vSalesPerson")]
    public partial class vSalesPerson
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        [StringLength(8)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Suffix { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string JobTitle { get; set; }

        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string PhoneNumberType { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmailPromotion { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        [StringLength(60)]
        public string AddressLine2 { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(30)]
        public string City { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string StateProvinceName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(15)]
        public string PostalCode { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string CountryRegionName { get; set; }

        [StringLength(50)]
        public string TerritoryName { get; set; }

        [StringLength(50)]
        public string TerritoryGroup { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesQuota { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal SalesYTD { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal SalesLastYear { get; set; }
    }
}
