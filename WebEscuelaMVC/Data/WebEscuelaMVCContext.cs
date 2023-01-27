using Microsoft.EntityFrameworkCore;
using WebEscuelaMVC.Models;
namespace WebEscuelaMVC.Data
{
    public class WebEscuelaMVCContext : DbContext
    {
        public WebEscuelaMVCContext(DbContextOptions<WebEscuelaMVCContext> options) : base(options) { }
        public DbSet<Aula> Aulas { get; set; }
    }
}
