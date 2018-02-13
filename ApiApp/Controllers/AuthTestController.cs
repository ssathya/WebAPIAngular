using System;
using System.Collections.Generic;
using ApiApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiApp.Controllers
{
    [Route(("api/[controller]"))]
    public class AuthTestController : Controller
    {
        private List<Message> _messages;
        private static readonly Random RandValue = new Random();

        public AuthTestController()
        {
            _messages = new List<Message>();

            PopulateMessages();
        }

        private void PopulateMessages()
        {
            _messages.Add(new Message { Identifier = "Name", Value = "George Washington" });
            _messages.Add(new Message { Identifier = "Name", Value = "John Adams" });
            _messages.Add(new Message { Identifier = "Name", Value = "Thomas Jefferson" });
            _messages.Add(new Message { Identifier = "Presidency", Value = "1789-1797" });
            _messages.Add(new Message { Identifier = "Presidency", Value = "1797-1801" });
            _messages.Add(new Message { Identifier = "Presidency", Value = "1801-1809" });
        }

        [HttpGet]
        [Authorize]
        public ActionResult Get()
        {
            var index = RandValue.Next(_messages.Count);
            return Ok(_messages[index]);
        }
    }
}