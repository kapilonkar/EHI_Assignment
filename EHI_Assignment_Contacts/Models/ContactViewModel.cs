using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EHI_Assignment_Contacts.Models
{
    /// <summary>
    /// Class to hold contact related information
    /// </summary>
    public class ContactViewModel
    {
        /// <summary>
        /// Unique identifier code of contact record
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Contact's first name
        /// </summary>
        [DisplayName("First Name")]
        public string FirstName { get; set;  }

        /// <summary>
        /// Contact's last name
        /// </summary>
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Contact's email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contact's phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Contact's status - Active/ Inactive
        /// </summary>
        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
