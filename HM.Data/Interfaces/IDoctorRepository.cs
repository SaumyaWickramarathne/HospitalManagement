using HM.Models.Models;
using System.Collections.Generic;

namespace HM.Data.Interfaces
{
    public interface IDoctorRepository
    {
       

        ICollection<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int Id);
        void AddDoctor(Doctor doctor);
        void UpdateDoctor(int Id, Doctor doctor);
        void DeleteDoctor(int Id);
    }
}
