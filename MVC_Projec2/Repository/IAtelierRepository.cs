﻿using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface IAtelierRepository:IGenericRepository<Atelier>
    {
        IEnumerable<Atelier> SearchByName(string name);
    }
}
