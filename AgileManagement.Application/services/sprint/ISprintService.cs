using AgileManagement.Application.dtos.project;
using AgileManagement.Core;
using AgileManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.services.sprint
{
    public interface ISprintService : IApplicationService<string, ProjectDto>
    {
       
    }
}
