using AgileManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.dtos.project
{
    public class SprintProjectResponseDto
    {
        public string SprintName { get; set; }
        public int SprintNo { get; set; } = 1;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(14);

    }




    public class ProjectWithContributorsResponseDto
    {

        public List<ProjectDto> Projects = new List<ProjectDto>();

    }
}