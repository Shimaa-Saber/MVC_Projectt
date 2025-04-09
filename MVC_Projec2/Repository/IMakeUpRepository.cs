using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface IMakeUpRepository:IGenericRepository<MakeUp_Service>
    {
        IEnumerable<MakeUp_Service> SearchByName(string name);
    }
}
