using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HM.Models.Models
{
    public class PatientDiagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("PatientId")]
        public Patient ParentPatient { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("DiagnosisId")]
        public Diagnosis ParentDiagnosis { get; set; }
        public int DiagnosisId { get; set; }
    }
}
