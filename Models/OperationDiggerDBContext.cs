using System;
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
