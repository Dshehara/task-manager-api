using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Models;

namespace TaskManagerAPI
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext>options)
         : base(options)
        {
            
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}