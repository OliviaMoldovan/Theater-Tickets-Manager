using BusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayersOnWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowsController : ControllerBase
    {
        private readonly IShowService showService;
        public ShowsController(IShowService showService)
        {
            this.showService = showService;
        }


        [HttpGet("Read")]
        [Authorize(Roles = "Admin")]
        public IEnumerable<Show> Get()
        {
            var result = new List<Show>();
            foreach (var s in showService.GetAllShows())
            {
                result.Add(new Show { ShowId = s.ShowId, Genre = s.Genre, Title = s.Title, Distribution = s.Distribution, Date = s.Date, NrTickets = s.NrTickets });
            }
            return result;
        }


        [HttpPost("Create")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(Show show)
        {
            showService.AddShowModel(new ShowModel { ShowId = show.ShowId, Genre = show.Genre, Title = show.Title, Distribution = show.Distribution, Date = show.Date, NrTickets = show.NrTickets });
        }

        [HttpPut("Update")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Put(Show show)
        {
            showService.UpdateShowModel(new ShowModel { ShowId = show.ShowId, Genre = show.Genre, Title = show.Title, Distribution = show.Distribution, Date = show.Date, NrTickets = show.NrTickets });
        }

        [HttpDelete("Delete")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Delete(Show show)
        {
            showService.DeleteShowModel(new ShowModel { ShowId = show.ShowId, Genre = show.Genre, Title = show.Title, Distribution = show.Distribution, Date = show.Date, NrTickets = show.NrTickets });
        }
    }
}
