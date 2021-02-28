using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EHI_Assignment_Contacts.Models;
using EHI_Assignment_Contacts.Services.ContactInfo;

namespace EHI_Assignment_Contacts.Controllers
{
    /// <summary>
    /// Controller class for contact information
    /// </summary>
    public class ContactInfoController : Controller
    {   
        private readonly IContactInfoService _contactInfoService;

        public ContactInfoController(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        // GET: ContactViewModels
        public IActionResult Index()
        {            
            return View(_contactInfoService.ListContacts());
        }

        // GET: ContactViewModels/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactViewModel = _contactInfoService.GetById(id.Value);
            if (contactViewModel == null)
            {
                return NotFound();
            }

            return View(contactViewModel);
        }

        // GET: ContactViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,FirstName,LastName,Email,Phone,IsActive")] ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {   
                _contactInfoService.SaveContact(contactViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(contactViewModel);
        }

        // GET: ContactViewModels/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactViewModel = _contactInfoService.GetById(id.Value);

            if (contactViewModel == null)
            {
                return NotFound();
            }
            return View(contactViewModel);
        }

        // POST: ContactViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,Email,Phone,IsActive")] ContactViewModel contactViewModel)
        {
            if (id != contactViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                   
                    _contactInfoService.UpdateContact(contactViewModel);
                }
                catch (Exception)
                {
                    
                    throw;
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactViewModel);
        }

        // GET: ContactViewModels/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactViewModel = _contactInfoService.GetById(id.Value);
            if (contactViewModel == null)
            {
                return NotFound();
            }

            return View(contactViewModel);
        }

        // POST: ContactViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {   
            _contactInfoService.DeleteContact(id);
            return RedirectToAction(nameof(Index));
        }       
    }
}
