using FreeLancer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public List<UserSkill> UserSkills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelancerProjects { get; private set; }

        public UserViewModel(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            BirthDate = user.BirthDate;
            CreatedAt = user.CreatedAt;
            Active = user.Active;
            UserSkills = user.UserSkills;
            OwnedProjects = user.OwnedProjects;
            FreelancerProjects = user.FreelancerProjects;
        }
    }
}
