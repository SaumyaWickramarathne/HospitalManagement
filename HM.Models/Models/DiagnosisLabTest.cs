using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HM.Models.Models
{
    public class DiagnosisLabTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("DiagnosisId")]
        public Diagnosis ParentDiagnosis { get; set; }
        public int DiagnosisId { get; set; }

        [ForeignKey("LabTestId")]
        public LabTest ParentLabTest { get; set; }
        public int LabTest { get; set; }
    }
}
