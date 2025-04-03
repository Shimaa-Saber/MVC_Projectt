﻿using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface IHallRepository : IGenericRepository<Hall>
    {
        Hall GetByIdWithImages(int id);

        List<Hall> GetAllWithImages();
    }
}
