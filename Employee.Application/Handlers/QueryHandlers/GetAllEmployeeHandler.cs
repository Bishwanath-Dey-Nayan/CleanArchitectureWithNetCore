using Employee.Application.Queries;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers.QueryHandlers
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee.Core.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public GetAllEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<List<Core.Entities.Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Employee>)await _employeeRepo.GetAllAsync();
        }
    }
}
