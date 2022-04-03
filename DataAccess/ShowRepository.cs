using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ShowRepository : IShowRepository
    {
        private readonly TheatreDbContext theatreDbContext;
        public ShowRepository(TheatreDbContext theatreDbContext)
        {
            this.theatreDbContext = theatreDbContext;
        }
        public void Add(ShowEntity show)
        {
            theatreDbContext.Add(show);
            theatreDbContext.SaveChanges();
        }

        public void Update(ShowEntity show)
        {
            theatreDbContext.Update(show);
            theatreDbContext.SaveChanges();
        }

        public void Delete(ShowEntity show)
        {
            if (show != null)
            {
                theatreDbContext.Remove(show);
                theatreDbContext.SaveChanges();
            }
        }

        public List<ShowEntity> GetAll()
        {
            return theatreDbContext.ShowEntities.ToList();
        }
    }
}
