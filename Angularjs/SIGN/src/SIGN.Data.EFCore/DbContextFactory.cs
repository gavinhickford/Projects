using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Data.EFCore
{
    public class DBContextFactory : IDbContextFactory<SIGNContext>
    {
        public SIGNContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SIGNContext>();
            builder.UseSqlServer("Server=.\\SQLEXPRESS; Database=SIGNGuidelines; Trusted_Connection=true; MultipleActiveResultSets=true;");
            return new SIGNContext(builder.Options);
        }
    }
}
