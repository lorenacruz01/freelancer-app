using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public decimal? TotalCost { get; set; }

        public ProjectDetailsViewModel(int id, string title, string description, DateTime? startedAt, DateTime? finishedAt, decimal? totalCost)
        {
            Id = id;
            Title = title;
            Description = description;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            TotalCost = totalCost;
        }
    }
}
