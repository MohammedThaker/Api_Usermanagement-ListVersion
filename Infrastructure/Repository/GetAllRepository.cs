using Application.Interfaces;
using Domain.Models;

using System.Threading.Tasks;
using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class GetAllRepository<T>: IGetRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public GetAllRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }



       public IEnumerable<T> GetAll()
        {
            return dBContext.Set<T>().ToList();
        }
    }
}
