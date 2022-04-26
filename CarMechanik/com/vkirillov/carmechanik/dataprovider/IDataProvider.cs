using CarMechanik.com.vkirillov.carmechanik.obj;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarMechanik.com.vkirillov.carmechanik.dataprovider
{
    public interface IDataProvider
    {
        Task<IEnumerable<Servise>> GetAllServises();
        Task<bool> DeleteServise(Servise servise);
        Task<IEnumerable<ArrangedService>> GetAllArrangedServices();
        Task<bool> EditArrangedServise(ArrangedService arrangedService);
        Task<bool> EditServise(Servise servise);
        Task<bool> AddServise(Servise servise);
        Task<Staff> Login(string login, string password);
    }
}
