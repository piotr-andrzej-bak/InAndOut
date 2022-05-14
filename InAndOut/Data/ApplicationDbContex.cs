using InAndOut.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Data
{
    public class ApplicationDbContex :DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) :base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
