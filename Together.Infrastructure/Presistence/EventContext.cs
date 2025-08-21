using Microsoft.EntityFrameworkCore;
using Together.Domain.Entity;

namespace Together.Infrastructure.Presistence;

public class EventContext : DbContext
{
    public string DbPath { get; }
    public EventContext()
    {
        Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        string path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "together.sqlite.db");
        Console.WriteLine($"sqlite db path={DbPath}");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    => builder.UseSqlite($"Data Source={DbPath}");
    public DbSet<Event>? Events { get; set; }
}