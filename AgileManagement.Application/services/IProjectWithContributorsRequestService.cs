﻿using AgileManagement.Application.dtos.user;
using AgileManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.services
{
    public interface IProjectWithContributorsRequestService: IApplicationService<ProjectWithContributorRequestDto, ProjectWithContributorsResponseDto>
    {

    }
}
