using FreeLancer.Application.InputModels;
using FreeLancer.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.Services.Interfaces
{
    internal interface IUserService
    {
        List<UserViewModel> GetAll();
        UserViewModel GetById(int id);
        int Create(NewUserInputModel inputModel);
        void Update(UpdateUserInputModel inputModel);
        void Delete(int id);
    }
}
