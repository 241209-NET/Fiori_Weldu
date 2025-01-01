using Microsoft.EntityFrameworkCore;
using NANNYAGENCY.API.Model;

namespace NANNYAGENCY.API.Data;

public class NannyContext : DbContext
{
    public NannyContext(){}
    public NannyContext(DbContextOptions<NannyContext> options) : base(options){}

    public DbSet<Client> Clients { get; set; }
}