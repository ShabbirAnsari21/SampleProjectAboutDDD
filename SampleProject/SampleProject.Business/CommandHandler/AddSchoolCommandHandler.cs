using MediatR;
using SampleProject.Business.Command;
using SampleProject.Domain.IRepository;
using SampleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Business.CommandHandler
{
    public class AddSchoolCommandHandler : IRequestHandler<AddSchoolCommand, ResponseMessage>
    {
        private readonly ISchoolRepository _schoolRepository;
        public AddSchoolCommandHandler(ISchoolRepository schoolRepository)
        {
            _schoolRepository= schoolRepository;
        }
        public async Task<ResponseMessage> Handle(AddSchoolCommand request, CancellationToken cancellationToken)
        {
            var school = await _schoolRepository.AddSchoolAsync(request);
            throw new NotImplementedException();
        }
    }
}
