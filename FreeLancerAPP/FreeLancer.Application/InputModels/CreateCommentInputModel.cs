using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public string Content { get; private set; }
        public int ProjectId { get; private set; }
        public int UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
