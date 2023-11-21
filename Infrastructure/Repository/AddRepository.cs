using Domain.IRepository;
using Domain.Models;
using Infrastructure;
using Infrastructure.LibraryDB;
using Infrastructure.Migrations;

namespace Infrastructure.Interfacies
{
    public class AddRepository<T> : IAddRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public AddRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public T Add(T entity)
        {
            dBContext.Set<T>().Add(entity);
            return entity;
        }


    }
}
