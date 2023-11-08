using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces;
public interface IEventTypeRepository
{
    void Add(EventType e);

    bool Update(EventType e);

    bool Delete(int id);

    EventType GetById(int id);

    IQueryable<EventType> GetAll();
}
