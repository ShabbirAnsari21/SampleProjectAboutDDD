using SampleProject.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Domain.IRepository
{
    public interface ISchoolRepository
    {
        Task<int> AddSchoolAsync(School school);
    }
}
