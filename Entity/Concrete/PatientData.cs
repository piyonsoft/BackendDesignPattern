using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class PatientData
    {
        public int Id { get; set; }
        public long IdentityNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public long PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Nationality { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string Job { get; set; }
        public bool UsingSmoke { get; set; }
        public bool UsingAlcohol { get; set; }
        public bool MaritalStatus { get; set; }
        public bool SmsConfirm { get; set; }
        public bool GDPRConfirm { get; set; }
        [StringLength(250)]
        public string Note { get; set; }
        public bool IsTrobule { get; set; }
        public string PhotoUrl { get; set; }

    }
}
