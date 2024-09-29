using FreeLancer.Application.InputModels;
using FreeLancer.Application.Services.Interfaces;
using FreeLancer.Application.ViewModels;
using FreeLancer.Core.Entities;
using FreeLancer.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly FreeLancerDbContext _dbContext;
        public ProjectService(FreeLancerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewProjectInputModel inputModel)
        {
            Project project = new Project(inputModel.Title, inputModel.Description, inputModel.ClientId, inputModel.FreelancerId, inputModel.TotalCost);
            _dbContext.Projects.Add(project);
            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            ProjectComment comment = new ProjectComment(inputModel.Content, inputModel.ProjectId, inputModel.UserId, DateTime.Now);
            _dbContext.Comments.Add(comment);
        }

        public void Delete(int id)
        {
            Project? project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            if (project != null) 
                project.Cancel();
        }

        public void Finish(int id)
        {
            Project? project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            if (project != null)
                project.Finish();
        }

        public void Start(int id)
        {
            Project? project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            if (project != null)
                project.Start();
        }

        public List<ProjectViewModel> GetAll()
        {
            IEnumerable<Project> projects = _dbContext.Projects.Where(x => x.Status != Core.Enums.ProjectStatus.Canceled);
            List<ProjectViewModel> projectViewModels = projects.Select(x => new ProjectViewModel(x.Id, x.Title, x.CreatedAt)).ToList();

            return projectViewModels;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            Project? project = _dbContext.Projects.SingleOrDefault(x => x.Id ==id);

            if (project == null)
                return null;

            ProjectDetailsViewModel projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.StartedAt,
                project.FinishedAt,
                project.TotalCost
            );
            return projectDetailsViewModel;
            
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            Project? project = _dbContext.Projects.SingleOrDefault(x => x.Id == inputModel.Id);
            project?.Update(inputModel.Title, inputModel.Description, inputModel.TotalCost);
            
        }
    }
}
