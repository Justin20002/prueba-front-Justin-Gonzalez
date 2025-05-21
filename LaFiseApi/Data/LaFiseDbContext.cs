using LaFiseApi_.Data.LafiseApi.Data;
using LaFiseApi_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LaFiseApi_.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaFiseDbContext : ControllerBase
    {

    }
    public class DbContext(DbContextOption<DbContext.LaFiseDbContext> options) : object
        {
        public class LaFiseDbContext : DbContext
        {
            public LaFiseDbContext(DbContextOption<LaFiseDbContext> options) : base(options)
            {
            }
        }

        public required DbSet<Cliente> Cliente { get; set; }
        public required DbSet<CuentaBancaria> CuentaBancaria { get; set; }
        public DbContextOption<LaFiseDbContext> Options { get; } = options;
    }
    
       
    }



    
    

