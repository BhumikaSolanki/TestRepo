using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoList.Model;

namespace ToDoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor that accepts DbContextOptions and passes it to the base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet representing the Tasks table in the database
        public DbSet<AddTaskModel> Tasks { get; set; }


    }
}