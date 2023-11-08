using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

namespace ECTPFinalProject.Data.Repositories
{
    public class EventTypeRepository : IEventTypeRepository
    {
        private readonly DataContext _dataContext;
        public EventTypeRepository(DataContext context) 
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(EventType eventTypeEntity)
        {
            _dataContext.EventTypes.Add(eventTypeEntity);
            _dataContext.SaveChanges();
        }

        public bool Update(EventType eventTypeEntity)
        {
            var existingEventType = GetById(eventTypeEntity.Id);
            if (existingEventType == null)
            {
                return false;
            }

            existingEventType.Name = eventTypeEntity.Name;

            existingEventType.Description = eventTypeEntity.Description;

            _dataContext.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var eventTypeEntity = GetById(id);
            if (eventTypeEntity == null)
            {
                return false;
            }

            _dataContext.EventTypes.Remove(eventTypeEntity);
            _dataContext.SaveChanges();

            return true;
        }

        public EventType GetById(int id)
            => _dataContext.EventTypes.Find(id);

        public IQueryable<EventType> GetAll()
            => _dataContext.EventTypes;
    }
}

