using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.ViewModels
{
    public class SkillViewModel
    {
        public int Id { get; private set; }
        public string Description { get; private set; }

        public SkillViewModel(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
