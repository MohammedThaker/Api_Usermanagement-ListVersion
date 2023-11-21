using Application.Interfaces;
using Domain.Models;

using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class DeleteRepository<T> : IDeleteRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public DeleteRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public void RemoveById(T entity)
        {
            dBContext.Set<T>().Remove(entity);
        }

      
    }
}
