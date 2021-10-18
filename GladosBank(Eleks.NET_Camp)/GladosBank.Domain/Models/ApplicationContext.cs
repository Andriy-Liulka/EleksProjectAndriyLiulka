﻿using GladosBank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladosBank;
using Microsoft.Extensions.Configuration;

namespace GladosBank.Domain
{
    public class ApplicationContext : DbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Currency> Currency { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Documentation> Documentations { get; set; }
        DbSet<Information> Informations { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Worker> Workers { get; set; }


        public ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

       //Connection string @"Server=ANDRIJ-PC\SQLSERVER2021;Database=EleksDOTNETCamp2021DataBase_GladosBank;User Id=andriy;Password=Fylhsq;  Trusted_Connection=True"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("MyConnectionString");
        }
    }
}
