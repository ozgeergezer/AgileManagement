using AgileManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.dtos.project
{
    public class SprintDto
    {
        public string SprintName { get; set; }
      //  public int SprintNo { get; set; } = 1;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(14);
    }
    public class ProjectSprintDto
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SprintDto> Sprints { get; set; } = new List<SprintDto>();
    }

    public class SprintProjectResponseDto
    {
        public ProjectSprintDto Projects = new ProjectSprintDto();
    }
}