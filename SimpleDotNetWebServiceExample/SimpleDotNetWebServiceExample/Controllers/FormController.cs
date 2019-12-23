using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleDotNetWebServiceExample.Models;
using SimpleDotNetWebServiceExample.Services;

namespace SimpleDotNetWebServiceExample.Controllers
{
    [ApiController]
    [Route("form")]
    public class FormController : Controller
    {
        private DataPersistenceService _dataService;
        private EmailService _emailService;

        public FormController(DataPersistenceService dataService, EmailService emailService)
        {
            _dataService = dataService;
            _emailService = emailService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] FormData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                _dataService.SendData("enter url here", data);
                _emailService.SendEmail(data);

                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }
    }
}