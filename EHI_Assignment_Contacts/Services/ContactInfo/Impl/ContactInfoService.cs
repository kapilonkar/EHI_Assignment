using EHI_Assignment_Contacts.Data;
using EHI_Assignment_Contacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHI_Assignment_Contacts.Services.ContactInfo.Impl
{
    public class ContactInfoService : IContactInfoService
    {
        /// <summary>
        /// List all contacts
        /// </summary>
        /// <returns>contacts</returns>
        public List<ContactViewModel> ListContacts()
        {
            return new ContactInfoDataModel().ListContacts();
        }

        /// <summary>
        /// Get contact with unique identifier
        /// </summary>
        /// <param name="id">unique identifier code</param>
        /// <returns>existing contact</returns>
        public ContactViewModel GetById(int id)
        {
            return new ContactInfoDataModel().GetById(id);
        }

        /// <summary>
        /// Save new contact information
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>unique identifier code</returns>
        public int SaveContact(ContactViewModel model)
        {
            return new ContactInfoDataModel().SaveContact(model);
        }

        /// <summary>
        /// Update existing contact information
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>unique identifier</returns>
        public int UpdateContact(ContactViewModel model)
        {
            return new ContactInfoDataModel().UpdateContact(model);
        }

        /// <summary>
        /// Delete existing contact information
        /// </summary>
        /// <param name="id">unique identifier code</param>
        /// <returns>Is delete flag</returns>
        public bool DeleteContact(int id)
        {
            return new ContactInfoDataModel().DeleteContact(id);
        }
    }
}
