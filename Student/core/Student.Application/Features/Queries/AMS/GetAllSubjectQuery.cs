﻿using AMS.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Application.Features.Queries.AMS
{
    public class GetAllSubjectQuery: IRequest<IEnumerable<SubjectViewDto>>
    {
    }
}
