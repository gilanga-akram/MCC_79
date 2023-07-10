using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Client.Controllers
{
    public class Fundamental: Controller
    {
        public IActionResult index() 
        
        { 
            return View(); 
        }
    }
}