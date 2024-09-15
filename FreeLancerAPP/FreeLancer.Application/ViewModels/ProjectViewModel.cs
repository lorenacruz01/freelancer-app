using FreeLancer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.ViewModels
{
    public class ProjectViewModel
    {
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public ProjectViewModel(string title, DateTime createdAt)
        {
            Title = title;
            CreatedAt = createdAt;
        }
    }
}
