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

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Compound> Compounds { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<PaymentInfo> PaymentInfo { get; set; }
        public DbSet<Samples> Samples { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
    }
}