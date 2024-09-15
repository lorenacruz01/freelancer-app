using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeLancer.Core.Entities;

namespace FreeLancer.Infraestructure.Persistence
{
    public class FreeLancerDbContext
    {
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> Comments { get; set; }

        public FreeLancerDbContext()
        {
            Projects = new List<Project>()
            {
                new Project ("Projeto teste 1", "descrição do projeto de teste 1", 1, 1, 1000),
                new Project ("Projeto teste 2", "descrição do projeto de teste 2", 1, 1, 2000),
                new Project ("Projeto teste 3", "descrição do projeto de teste 3", 1, 1, 3000)
            };
            Users = new List<User>()
            {
                new User("Jonh Smith", "john@teste.com", new DateTime(1997, 10, 5)),
                new User("Mary Miller", "mary@teste.com", new DateTime(1999, 6, 15)),
                new User("Ben Anderson", "ben@teste.com", new DateTime(1987, 1, 11)),
            };
            Skills = new List<Skill>()
            {
                new Skill("Javascript"),
                new Skill("Springboot"),
                new Skill("MySQL")
            };
        }
    }
}
