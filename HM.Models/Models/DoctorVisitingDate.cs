using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HM.Models.Models
{
    public class DoctorVisitingDate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        [ForeignKey("DoctorId")]
        public Doctor ParentDoctor { get; set; }
        public int DoctorId { get; set; }

        [ForeignKey("VisitingDateId")]
        public VisitingDate ParentVisitingDate { get; set; }
        public int VisitingDateId { get; set; }
    }
}
