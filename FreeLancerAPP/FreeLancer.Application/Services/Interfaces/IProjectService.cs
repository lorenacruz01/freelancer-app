﻿using FreeLancer.Application.InputModels;
using FreeLancer.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll();
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void CreateComment(CreateCommentInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void Start(int id);
        void Finish(int id);
    }
}
