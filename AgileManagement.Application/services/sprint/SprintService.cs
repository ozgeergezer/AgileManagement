using AgileManagement.Application.dtos.project;
using AgileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.services.sprint
{
    public class SprintService :ISprintService
    {
        private readonly IProjectRepository _projectRepository;

        public SprintService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public SprintProjectResponseDto OnProcess(string projectId)
        {
            var query = _projectRepository.GetQuery();

            var sprint = query.Where(x => x.Id == projectId).Include(x => x.Sprints).Select(a => new ProjectSprintDto
            {
                ProjectId = a.Id,
                Name = a.Name,
                Description = a.Description,
                Sprints = a.Sprints.Select(o => new SprintDto
                {
                    SprintName = o.SprintName,
                    //SprintNo = x.SprintNo,
                    StartDate = o.StartDate,
                    EndDate = o.EndDate
                }).ToList()
            }).FirstOrDefault();

            var response = new SprintProjectResponseDto
            {
                Projects = sprint
            };

            return response;
        }
    }
}

