using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public int UserId { get; private set; }
        public int SkillId  { get; private set; }

        public UserSkill(int userId, int skillId)
        {
            UserId = userId;
            SkillId = skillId;
        }
    }
}
