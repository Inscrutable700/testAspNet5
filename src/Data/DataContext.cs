using Data.Models;
using Microsoft.Data.Entity;

namespace Data
{
    /// <summary>
    /// The Data context.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
