using System;
using System.Collections.Generic;
using System.Linq;
using iPAS.Services.Registration.Domain.Seedwork;

namespace iPAS.Services.Registration.Domain.AggregatesModel.PatientAggregate
{
    public class Patient
        : Entity, IAggregateRoot
    {
        public PatientAddress PatientAddress { get; private set; }

        public Int64 PatientId { get; set; }
        public DateTime BirthDate { get; private set; }
        public string Gender { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }

        public Patient(Int64 patientId, DateTime birthDate, string gender, string firstName, string middleName, string lastName) :this()
        {
            PatientId = patientId;
            BirthDate = birthDate;
            Gender = gender;
            FirstName = FirstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Patient()
        {
        }
    }
}
