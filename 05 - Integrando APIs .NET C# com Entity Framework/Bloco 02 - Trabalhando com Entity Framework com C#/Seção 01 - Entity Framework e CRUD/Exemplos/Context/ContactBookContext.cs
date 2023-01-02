using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exemplos.Entities;

namespace Exemplos.Context
{
    public class ContactBookContext : DbContext
    {
        public ContactBookContext(DbContextOptions<ContactBookContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}