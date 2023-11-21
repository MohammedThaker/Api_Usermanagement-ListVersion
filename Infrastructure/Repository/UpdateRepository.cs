using Domain.Models;

using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class UpdateRepository<T> : IUpdateRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public UpdateRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public void Update(T entity)
        {


             dBContext.Set<T>().Update(entity);

        }
    }
}
