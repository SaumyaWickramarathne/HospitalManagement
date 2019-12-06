using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HM.Models.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int NIC { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string TelephoneNo { get; set; }
        public string EmergencyContact { get; set; }

        [Required]
        public string BloodType { get; set; }

        
    }
}
