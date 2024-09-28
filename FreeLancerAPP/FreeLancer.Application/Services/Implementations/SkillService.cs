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
    public class SkillService : ISkillService
    {
        private readonly FreeLancerDbContext _dbContext;

        public SkillService(FreeLancerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillViewModel> GetAll()
        {
            List<Skill> skills = _dbContext.Skills;
            List<SkillViewModel> skillsViewModel = skills.Select(x => new SkillViewModel(x.Id, x.Description)).ToList();
            return skillsViewModel;
        }
    }
}
