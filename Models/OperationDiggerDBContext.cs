using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OperationDigger.Models
{
    public class OperationDiggerDBContext : DbContext
    {
        public OperationDiggerDBContext()
        {
        }

        public OperationDiggerDBContext(DbContextOptions<OperationDiggerDBContext> options) :
            base(options)
        {
        }
    }
}
