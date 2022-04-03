using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository repository;

        public ShowService(IShowRepository repository)
        {
            this.repository = repository;
        }
        public void AddShowModel(ShowModel show)
        {
            repository.Add(new ShowEntity { ShowId = show.ShowId, Genre = show.Genre, Title = show.Title, Distribution = show.Distribution, Date = show.Date, NrTickets = show.NrTickets });
        }
        public void UpdateShowModel(ShowModel show)
        {
            repository.Update(new ShowEntity { ShowId = show.ShowId, Genre = show.Genre, Title = show.Title, Distribution = show.Distribution, Date = show.Date, NrTickets = show.NrTickets });
        }
        public void DeleteShowModel(ShowModel show)
        {
            repository.Delete(new ShowEntity { ShowId = show.ShowId, Genre = show.Genre, Title = show.Title, Distribution = show.Distribution, Date = show.Date, NrTickets = show.NrTickets });

        }

        public List<ShowModel> GetAllShows()
        {
            List<ShowModel> result = new List<ShowModel>();
            foreach (var x in repository.GetAll())
            {
                result.Add(new ShowModel { ShowId = x.ShowId, Genre = x.Genre, Title = x.Title, Distribution=x.Distribution, Date = x.Date, NrTickets=x.NrTickets });
            }

            return result;
        }

    }
}
