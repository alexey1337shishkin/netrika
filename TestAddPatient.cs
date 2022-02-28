using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.ServiceReference1;

namespace test
{
    [TestFixture]
    class TestAddPatient
    {
        [Test, Category("pass")]
        public void FullData()
        {
            BirthPlaceDto birthPlaceDto = new BirthPlaceDto { City = "test", Country = "test", Region = "test" };
            ContactDto contactDto = new ContactDto { ContactValue = "test", IdContactType = 1 };
            AddressDto addressDto = new AddressDto { Appartment = "1", Building = "1", City = "32", GeoData = "53.2521, 34.3717", IdAddressType = 1, PostalCode = 240000, Street = "32000001000014500", StringAddress = "test" };
            DocumentDto documentDto = new DocumentDto { DocN = "test", DocS = "test", DocumentName = "test", ExpiredDate = new DateTime(2024, 10, 10), IdDocumentType = 1, IdProvider = "10001", IssuedDate = new DateTime(2014, 10, 10), ProviderName = "test", RegionCode = "32", StartDate = new DateTime(2015, 10, 10) };
            AddressDto[] addressDtos = new AddressDto[] { addressDto };
            PatientDto patientDto = new PatientDto { BirthDate = new DateTime(2010, 10, 10), Addresses = addressDtos, BirthPlace = birthPlaceDto, FamilyName = "test6", GivenName = "test6", IdBloodType = 1, IdLivingAreaType = 1, IdPatientMIS = "test6", MiddleName = "test", Sex = 1, SocialGroup = 1, SocialStatus = "1" };

            AddPatient add = new AddPatient();
            add.TryAddPatient(patientDto);
            
        }

    }
}
