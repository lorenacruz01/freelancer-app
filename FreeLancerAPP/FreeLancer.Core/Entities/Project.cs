using FreeLancer.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Core.Entities
{
    public class Project : BaseEntity
    {

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int ClientId { get; private set; }
        public int FreelancerId { get; private set; }
        public decimal? TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatus Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public Project(string title, string description, int clientId)
        {
        }

        public Project(string title, string description, int clientId, int freelancerId, decimal? totalCost)
        {
            Title = title;
            Description = description;
            ClientId = clientId;
            FreelancerId = freelancerId;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now;
            Comments = new List<ProjectComment>();

        }
    }
}
