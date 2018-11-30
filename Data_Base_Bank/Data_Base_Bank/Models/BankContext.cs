using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data_Base_Bank.Models
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
        }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Depositor> Depositors { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Typedeposit> Typesdeposits { get; set; }
    }
}
