using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HeroProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : Controller
    {
        DataService _dataService;

        public HeroController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("")]
        
        public List<Hero> Index()
        {
            return _dataService.GetHeros();
        }
    }
}