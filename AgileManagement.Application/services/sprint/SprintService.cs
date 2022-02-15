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
    public class SprintService 
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUserRepository _userRepository;

        public SprintService(IProjectRepository projectRepository,IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _projectRepository = projectRepository;
        }



        public ProjectDto OnProcess(string projectId)
        {
            var query = _projectRepository.GetQuery();

            var sprint = query.Where(x => x.Id == projectId).Include(x => x.Sprints).Select(a => new ProjectDto
            {
                ProjectId = a.Id,
                Name = a.Name,
                Description = a.Description,
                Sprints = a.Sprints.Select(x => new SprintProjectResponseDto
                {

                    SprintName = x.SprintName,
                    SprintNo = x.SprintNo,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate

                }).ToList()

            }).FirstOrDefault();


            return sprint;
        }
    }
}

