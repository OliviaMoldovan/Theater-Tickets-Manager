using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IShowRepository
    {
        List<ShowEntity> GetAll();
        void Add(ShowEntity show);

        void Update(ShowEntity show);

        void Delete(ShowEntity show);


    }
}
