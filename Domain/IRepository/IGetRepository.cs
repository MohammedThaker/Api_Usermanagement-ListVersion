
using Domain.Models.Request;
namespace Domain.IRepository
{
    public  interface IGetRepository<T> where T : class
    {

        public IEnumerable<T> GetAll();

    }
}
