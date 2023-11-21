using Application.Interfaces;
using Domain.Models;
using Domain.IRepository;
using Infrastructure.LibraryDB;
using Domain.Entities;
using Infosturcture.Repository;

namespace Infrastructure.Interfacies
{
    public class BaseUnitOfWork : IBaseUnitOftWork
    {
        protected LibraryDBContext dBContext;
  


        public IAddRepository<User> AddUsers { get; private set; }

        public IGetRepository<User> getuser { get; private set; }
        //add

        public IAddRepository<Role> AddRole { get; set; }

        //gat
        public IGetRepository<User> GetAllUser { get; set; }

        public IGetRepository<Role> GetAllRole { get; set; }

        public IGetRepositoryById<User> GetUserById { get; set; }

        public IGetRepositoryById<Role> GetRoleById { get; set; }

        //update
        public IUpdateRepository<User> UpdateUser { get; set; }
        public IUpdateRepository<Role> UpdateRole { get; set; }
        //Delete
        public IDeleteRepository<User> DeleteUser { get; set; }
        public IDeleteRepository<Role> DeleteRole { get; set; }
        //IAuthenticate
        public IAuthenticate authenticate { get; set; }
        public BaseUnitOfWork(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
         
          
           
            AddUsers = new AddRepository<User>(dBContext);
            getuser = new GetAllRepository<User>(dBContext);
            //
            AddUsers = new AddRepository<User>(dBContext);
            AddRole = new AddRepository<Role>(dBContext);
            //
            GetUserById = new GetRepositoryById<User>(dBContext);
            GetRoleById = new GetRepositoryById<Role>(dBContext);
            //
            GetAllUser = new GetAllRepository<User>(dBContext);
            GetAllRole = new GetAllRepository<Role>(dBContext);

            //
            UpdateUser = new UpdateRepository<User>(dBContext);
            UpdateRole = new UpdateRepository<Role>(dBContext);

            //
            DeleteUser = new DeleteRepository<User>(dBContext);
            DeleteRole = new DeleteRepository<Role>(dBContext);

            //
            authenticate = new Authenticate(dBContext);
        }



        public int Complete()
        {
            return dBContext.SaveChanges();
        }

        public void Dispose()
        {
            dBContext.Dispose();
        }
    }
}