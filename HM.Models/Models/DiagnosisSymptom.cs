using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HM.Models.Models
{
    public class DiagnosisSymptom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("DiagnosisId")]
        public Diagnosis ParentDiagnosis { get; set; }
        public int DiagnosisId { get; set; }

        [ForeignKey("SymptomId")]
        public Symptom ParentSymptom { get; set; }
        public int SymptomId { get; set; }
    }
}
