using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public string Content { get; private set; }
        public int ProjectId {  get; private set; }
        public int UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public ProjectComment(string content, int projectId, int userId, DateTime createdAt)
        {
            Content = content;
            ProjectId = projectId;
            UserId = userId;
            CreatedAt = createdAt;
        }

    }
}
