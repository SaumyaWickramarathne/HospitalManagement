using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HM.Models.Models
{
    public class DoctorPatient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("DoctorId")]
        public Doctor ParentDoctor { get; set; }
        public int DoctorId { get; set; }

        [ForeignKey("PatientId")]
        public Patient ParentPatient { get; set; }
        public int PatientId { get; set; }
    }
}
