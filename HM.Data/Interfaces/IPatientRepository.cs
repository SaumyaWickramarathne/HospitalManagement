using HM.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace HM.Data.Interfaces
{
    public interface IPatientRepository
    {
        public IActionResult GetAllPatients();
        public IActionResult GetPatientById(int Id);
        public IActionResult AddPatient(Patient patient);
        public IActionResult UpdatePatient(int Id, Patient patient);
        public IActionResult DeletePatient(int Id);
    }
}
