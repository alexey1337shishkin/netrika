using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.ServiceReference1;

namespace test
{
    class AddPatient
    {
        static void Main()
        {
            BirthPlaceDto birthPlaceDto = new BirthPlaceDto { City = "test", Country = "test", Region = "test" };
            ContactDto contactDto = new ContactDto { ContactValue = "test", IdContactType = 1 };
            AddressDto addressDto = new AddressDto { Appartment = "1", Building = "1", City = "32", GeoData = "53.2521, 34.3717", IdAddressType = 1, PostalCode = 240000, Street = "32000001000014500", StringAddress = "test" };
            DocumentDto documentDto = new DocumentDto { DocN = "test", DocS = "test", DocumentName = "test", ExpiredDate = new DateTime(2024, 10, 10), IdDocumentType = 1, IdProvider = "10001", IssuedDate = new DateTime(2014, 10, 10), ProviderName = "test", RegionCode = "32", StartDate = new DateTime(2015, 10, 10) };
            AddressDto[] addressDtos = new AddressDto[] { addressDto };
            PatientDto patientDto = new PatientDto { BirthDate = new DateTime(2010, 10, 10), Addresses = addressDtos, BirthPlace = birthPlaceDto, FamilyName = "test6", GivenName = "test6", IdBloodType = 1, IdLivingAreaType = 1, IdPatientMIS = "test6", MiddleName = "test", Sex = 1, SocialGroup = 1, SocialStatus = "1" };

            
        }

        public void TryAddPatient(PatientDto patientDto)
        {
            PixServiceClient client = new PixServiceClient("Soap12_PixService");
            
            client.AddPatient("0310C7A6-BDF3-4124-B9D4-5FD5C72FA066", "8bbb2c42-77b1-4c75-97aa-0af48dc15238", patientDto);
            client.Close();
        }
    }
}
