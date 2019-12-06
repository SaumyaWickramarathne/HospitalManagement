using HM.Data.Context;
using HM.Data.Interfaces;
using HM.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HM.Data.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private HMDbContext _HMdbcontext;
        public DoctorRepository(HMDbContext HMdbcontext)
        {
            this._HMdbcontext = HMdbcontext;
        }

        public IActionResult AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteDoctor(int Id)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetAllDoctors()
        {
            throw new NotImplementedException();

        }

        public IActionResult GetDoctorById(int Id)
        {
            throw new NotImplementedException();
        }

        public IActionResult UpdateDoctor(int Id, Doctor doctor)
        {
            throw new NotImplementedException();
        }

        void IDoctorRepository.AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        void IDoctorRepository.DeleteDoctor(int Id)
        {
            throw new NotImplementedException();
        }

        ICollection<Doctor> IDoctorRepository.GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        Doctor IDoctorRepository.GetDoctorById(int Id)
        {
            throw new NotImplementedException();
        }

        void IDoctorRepository.UpdateDoctor(int Id, Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
