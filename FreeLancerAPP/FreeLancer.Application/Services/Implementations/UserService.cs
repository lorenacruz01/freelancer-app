using FreeLancer.Application.InputModels;
using FreeLancer.Application.Services.Interfaces;
using FreeLancer.Application.ViewModels;
using FreeLancer.Core.Entities;
using FreeLancer.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly FreeLancerDbContext _dbContext;

        public UserService(FreeLancerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            User newUser = new User(inputModel.Name, inputModel.Email, inputModel.BirthDate);
            _dbContext.Users.Add(newUser);
            return newUser.Id;
        }

        public void Delete(int id)
        {
            User? user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            if(user != null)
                _dbContext.Users.Remove(user);
        }

        public List<UserViewModel> GetAll()
        {
            List<User> users = _dbContext.Users;
            List<UserViewModel> usersViewModel = users.Select(x => new UserViewModel(x)).ToList();
            return usersViewModel;
        }

        public UserViewModel? GetById(int id)
        {
            User? user = _dbContext.Users.SingleOrDefault(x => x.Id == id);
            UserViewModel? userViewModel = null;
            if(user != null)
                userViewModel = new UserViewModel(user);

            return userViewModel;
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            User? user = _dbContext.Users.SingleOrDefault(x => x.Id == inputModel.Id);
            user?.Update(inputModel.Name, inputModel.Email, inputModel.Active);
        }
    }
}
