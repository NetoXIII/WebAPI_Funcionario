﻿using Microsoft.EntityFrameworkCore;
using WebAPI_Funcionario.Models;

namespace WebAPI_Funcionario.DataContex
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
