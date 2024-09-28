using FreeLancer.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}
