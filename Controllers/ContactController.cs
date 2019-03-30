using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            Regex regexName = new Regex(@"\w{3,30}[1-9]?\s?\w{3,30}[1-9]?");
            Regex regexNumber = new Regex(@"([+]359)|(0)?\s?[0-9]");

            if (contact.Name.Length>=3)
            {
                DataAccess.Contacts.Add(contact);
            }
            else
            {
                TempData["ErrorMessage"] = "Name or number are required!";
            }
            
            return RedirectToAction("Index","Home");
        }
    }
}