using System;
using System.Collections.Generic;
using iPAS.Services.Registration.Domain.Seedwork;

namespace iPAS.Services.Registration.Domain.AggregatesModel.PatientAggregate
{
    public class PatientAddress : ValueObject
    {
        public String StreetAddress { get; private set; }
        public String StreetAddress2 { get; private set; }
        public String City { get; private set; }
        public String State { get; private set; }
        public String Country { get; private set; }
        public String ZipCode { get; private set; }

        public PatientAddress() { }

        public PatientAddress(string streetAddress, string streetAddress2, string city, string state, string country, string zipcode)
        {
            StreetAddress = streetAddress;
            StreetAddress2 = streetAddress2;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return StreetAddress;
            yield return StreetAddress2;
            yield return City;
            yield return State;
            yield return Country;
            yield return ZipCode;
        }

    }
}