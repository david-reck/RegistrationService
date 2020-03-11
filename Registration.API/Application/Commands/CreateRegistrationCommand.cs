using System;
using MediatR;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Collections;
using System.Linq;
using iPAS.Services.Registration.API.Application.Models;

namespace iPAS.Services.Registration.API.Application.Commands
{
 
    [DataContract]
    public class CreateRegistrationCommand : IRequest<bool>
    {
        
        [DataMember]
        public Int64 PatientId { get; set; }
        [DataMember]
        public DateTime BirthDate { get; private set; }
        [DataMember]
        public string Gender { get; private set; }
        [DataMember]
        public string FirstName { get; private set; }
        [DataMember]
        public string MiddleName { get; private set; }
        [DataMember]
        public string LastName { get; private set; }

        public CreateRegistrationCommand() { }

        public CreateRegistrationCommand(Int64 patientId, DateTime birthDate, string gender, string firstName, string middleName, string lastName) : this()
        {
            PatientId = patientId;
            BirthDate = birthDate;
            Gender = gender;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
