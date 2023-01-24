using SampleProject.Domain.Domain;
using SampleProject.Domain.IRepository;
using SampleProject.Infrastructure.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Infrastructure.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly AppDbContext _appDbContext;
        public SchoolRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }
        public async Task<int> AddSchoolAsync(School school)
        {
            await _appDbContext.Schools.AddAsync(school);
            await _appDbContext.SaveChangesAsync();
            return school.Id;
        }
    }
}
