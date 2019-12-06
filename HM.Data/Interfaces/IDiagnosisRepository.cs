using HM.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace HM.Data.Interfaces
{
    public interface IDiagnosisRepository
    {
        public IActionResult AddDiagnosis(Diagnosis diagnosis);
    }
}
