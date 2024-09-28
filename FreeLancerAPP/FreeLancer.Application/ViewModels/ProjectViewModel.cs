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
        public int Id { get; set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public ProjectViewModel(int id, string title, DateTime createdAt)
        {
            Id = id;
            Title = title;
            CreatedAt = createdAt;
        }
    }
}
