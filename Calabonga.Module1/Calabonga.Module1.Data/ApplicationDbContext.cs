using Calabonga.Module1.Data.Base;
using Calabonga.Module1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Calabonga.Module1.Data
{
    /// <summary>
    /// Database for application
    /// </summary>
    public class ApplicationDbContext : DbContextBase<ApplicationDbContext>, IApplicationDbContext
    {
        /// <inheritdoc />
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #region System

        public DbSet<Log> Logs { get; set; }

        public DbSet<TEntity> Query<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }


        #endregion
    }
}