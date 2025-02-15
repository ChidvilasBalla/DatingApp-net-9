using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

//a simplified version of constructor.
public class DataContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<AppUser> Users {get; set;}
}
