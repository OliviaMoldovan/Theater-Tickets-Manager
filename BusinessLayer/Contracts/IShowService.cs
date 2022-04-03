using BusinessLayer.Contracts;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IShowService
    {
        List<ShowModel> GetAllShows();
        void AddShowModel(ShowModel show);

        void UpdateShowModel(ShowModel show);

        void DeleteShowModel(ShowModel show);


    }
}
