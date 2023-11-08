using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces;
public interface IEventRepository
{
    void Add(Event e);

    bool Update(Event e);

    bool Delete(int id);

    Event GetById(int id);
}
