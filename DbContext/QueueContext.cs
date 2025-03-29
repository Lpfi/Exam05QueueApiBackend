using Microsoft.EntityFrameworkCore;
using QueueApi.Models;

public class QueueContext : DbContext
{
    public QueueContext(DbContextOptions<QueueContext> options) : base(options) { }

    public DbSet<QueueTicket> QueueTickets { get; set; }
}
