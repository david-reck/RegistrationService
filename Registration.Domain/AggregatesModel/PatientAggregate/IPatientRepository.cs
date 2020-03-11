using System;
using System.Threading.Tasks;
using iPAS.Services.Registration.Domain.Seedwork;

namespace iPAS.Services.Registration.Domain.AggregatesModel.PatientAggregate
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Patient Add(Patient patient);

        void Update(Patient patient);

        Task<Patient> GetAsync(Int64 patientId);
    }
}
