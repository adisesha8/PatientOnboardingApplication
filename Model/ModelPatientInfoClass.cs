using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// Assignment 2
     public class ModelPatientInfoClass
    {
        [DisplayName("Salutation :")]
        public string Prefix { get; set; }

        [DisplayName("First Name :")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name :")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name :")]
        public string LastName { get; set; }

        [DisplayName("Suffix :")]
        public string Suffix { get; set; }

        [DisplayName("Gender :")]
        public string Sex { get; set; }

        [DisplayName("Date of Birth :")]
        public DateTime DOB { get; set; }

        [DisplayName("Age :")]
        public int Age { get; set; }

        [DisplayName("Locale :")]
        public string Locality { get; set; }

        [DisplayName("Marital Status :")]
        public string MaritalStatus { get; set; }
    }

}
