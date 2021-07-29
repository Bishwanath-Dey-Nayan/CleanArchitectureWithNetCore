using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Mapper
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee.Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
