using INTEX.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INTEX.DAL
{
    public class IntexContext : DbContext
    {
        public IntexContext() : base("IntexContext")
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Compound> Compound { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<PaymentInfo> PaymentInfo { get; set; }
        public DbSet<Samples> Samples { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }
    }
}