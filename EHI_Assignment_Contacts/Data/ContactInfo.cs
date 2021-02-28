using EHI_Assignment_Contacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EHI_Assignment_Contacts.Data
{
    public class ContactInfoDataModel
    {
        /// <summary>
        /// List all contacts
        /// </summary>
        /// <returns>contacts</returns>
        public List<ContactViewModel> ListContacts()
        {   
            JSONReadWrite readWrite = new JSONReadWrite();
            List<ContactViewModel> contacts = JsonConvert.DeserializeObject<List<ContactViewModel>>(readWrite.Read("contacts.json", "data"));


            if (contacts == null)
            {
                contacts = new List<ContactViewModel>();
            }

            return contacts;
        }

        /// <summary>
        /// Get contact with unique identifier
        /// </summary>
        /// <param name="id">unique identifier code</param>
        /// <returns>existing contact</returns>
        public ContactViewModel GetById(int id)
        {
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            JSONReadWrite readWrite = new JSONReadWrite();
            contacts = JsonConvert.DeserializeObject<List<ContactViewModel>>(readWrite.Read("contacts.json", "data"));

            return contacts.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Save new contact information
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>unique identifier code</returns>
        public int SaveContact(ContactViewModel model)
        {   
            JSONReadWrite readWrite = new JSONReadWrite();
            List<ContactViewModel> contacts = JsonConvert.DeserializeObject<List<ContactViewModel>>(readWrite.Read("contacts.json", "data"));

            if (contacts == null)
            {
                contacts = new List<ContactViewModel>();
            }

            int index = contacts.Max(c => c.Id);

            model.Id = index + 1;

            contacts.Add(model);

            string jSONString = JsonConvert.SerializeObject(contacts);
            readWrite.Write("contacts.json", "data", jSONString);

            return model.Id;

        }

        /// <summary>
        /// Update existing contact information
        /// </summary>
        /// <param name="model">contact view model</param>
        /// <returns>unique identifier</returns>
        public int UpdateContact(ContactViewModel model)
        {
            JSONReadWrite readWrite = new JSONReadWrite();
            List<ContactViewModel> contacts = JsonConvert.DeserializeObject<List<ContactViewModel>>(readWrite.Read("contacts.json", "data"));

            if (contacts == null)
            {
                contacts = new List<ContactViewModel>();
            }

            int index = contacts.FindIndex(x => x.Id == model.Id);
            contacts[index] = model;

            string jSONString = JsonConvert.SerializeObject(contacts);
            readWrite.Write("contacts.json", "data", jSONString);

            return model.Id;
        }

        /// <summary>
        /// Delete existing contact information
        /// </summary>
        /// <param name="id">unique identifier code</param>
        /// <returns>Is delete flag</returns>
        public bool DeleteContact(int id)
        {
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            JSONReadWrite readWrite = new JSONReadWrite();
            contacts = JsonConvert.DeserializeObject<List<ContactViewModel>>(readWrite.Read("contacts.json", "data"));

            int index = contacts.FindIndex(x => x.Id == id);
            contacts.RemoveAt(index);

            string jSONString = JsonConvert.SerializeObject(contacts);
            readWrite.Write("contacts.json", "data", jSONString);

            return true;

        }
    }
}
