using Application.DTOs.RequestDTO;
using Application.Interfaces.IUserService;
using Domain.IRepository;

using Domain.Entities;
namespace Application.service.UsersService
{
    public class UpdateUserService: IUpdateUserService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public UpdateUserService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public string Update_User(User user)
        {
            try
            {


                if (String.IsNullOrEmpty(user.Name))
                {
                    return "error to update";
                }
                if (String.IsNullOrEmpty(user.Email))
                {
                    return "error to update";
                }
                if (String.IsNullOrEmpty(user.Phone))
                {
                    return "error to  update";
                }
                

                var createorder = addUnitOfWork.UpdateUser.Update(user);

                addUnitOfWork.Complete();
                return   "Updated user";
            }
            catch (Exception )
            {

                return "Erorr to Updated User";
            }
        }
    }
}
