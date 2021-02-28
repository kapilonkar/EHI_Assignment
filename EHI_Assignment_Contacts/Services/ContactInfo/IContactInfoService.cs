using EHI_Assignment_Contacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHI_Assignment_Contacts.Services.ContactInfo
{
    /// <summary>
    /// An interface to invoke CRUD operatopn for contact
    /// </summary>
    public interface IContactInfoService
    {
        /// <summary>
        /// List all contacts
        /// </summary>
        /// <returns>contacts</returns>
        List<ContactViewModel> ListContacts();

        /// <summary>
        /// Get contact with unique identifier
        /// </summary>
        /// <param name="id">unique identifier code</param>
        /// <returns>existing contact</returns>
        ContactViewModel GetById(int id);

        /// <summary>
        /// Save new contact information
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>unique identifier code</returns>
        int SaveContact(ContactViewModel model);

        /// <summary>
        /// Update existing contact information
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>unique identifier</returns>
        int UpdateContact(ContactViewModel model);


        /// <summary>
        /// Delete existing contact information
        /// </summary>
        /// <param name="id">unique identifier code</param>
        /// <returns>Is deleted flag</returns>
        bool DeleteContact(int id);
    }
}
