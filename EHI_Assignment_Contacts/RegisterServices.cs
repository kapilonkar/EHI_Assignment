using EHI_Assignment_Contacts.Services.ContactInfo;
using EHI_Assignment_Contacts.Services.ContactInfo.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHI_Assignment_Contacts
{
    public class RegisterServices
    {
        /// <summary>
        /// Register Services
        /// </summary>
        /// <param name="services"></param>
        public void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IContactInfoService, ContactInfoService>();
        }
    }
}
