using Domain.Repositories;
using Domain.Salaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class SalaryRepository : BaseRepository<Domain.Salaries.Salary>, ISalaryRepository
    {
        public static string ClassName => "SalaryRepository";
        public SalaryRepository(CoreDbContext dbContext) : base(dbContext) { }


    }
}
