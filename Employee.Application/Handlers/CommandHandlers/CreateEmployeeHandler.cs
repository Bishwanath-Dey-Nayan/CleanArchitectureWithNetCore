using Employee.Application.Commands;
using Employee.Application.Responses;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers.CommandHandlers
{

    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
