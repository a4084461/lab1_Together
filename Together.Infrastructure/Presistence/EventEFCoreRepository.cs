using System.Data.Common;
using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Infrastructure.Presistence;

public class EventEFCoreRepository(EventContext pdb) : IEventRepository
{
    public readonly EventContext db = pdb;
    public void AddEvent(Event e)
    {
        db.Add(e);
        db.SaveChanges();
    }

    public Event[] GetAll()
    {
        return db.Events!.ToArray();
    }
}