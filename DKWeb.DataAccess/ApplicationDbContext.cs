using DKWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DKWeb.DataAccess
{
    /// <summary>
    /// Some sample DTO
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        #region Tables
        /// <summary>
        /// Sample DbSet
        /// </summary>
        public DbSet<UserDTO> Users { get; set; }
        #endregion

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Default functionality for populating the database
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDTO>().HasKey(x => x.Id);
        }
    }
}
