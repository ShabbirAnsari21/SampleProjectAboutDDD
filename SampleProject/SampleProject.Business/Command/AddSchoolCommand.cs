using MediatR;
using SampleProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Business.Command
{
    public class AddSchoolCommand : IRequest<ResponseMessage>
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
