using HM.Data.Context;
using HM.Data.Interfaces;
using HM.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HM.Data.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private HMDbContext _HMdbcontext;
        public PatientRepository(HMDbContext HMdbcontext)
        {
            this._HMdbcontext = HMdbcontext;
        }
        public void AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void DeletePatient(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Patient> GetAllPatients()
        {
            var patients = _HMdbcontext.Patients.ToList();
            return patients;
        }

        public Patient GetPatientById(int Id)
        {
            var patient = _HMdbcontext.Patients.Where(c => c.Id == Id).SingleOrDefault();
            return patient;
        }

        public void UpdatePatient(int Id, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
