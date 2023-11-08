using ECTPFinalProject.Data.Interfaces;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECTPFinalProject.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _dataContext;

        public EventRepository(DataContext context)
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Event eventEntity)
        {
            _dataContext.Events.Add(eventEntity);
            _dataContext.SaveChanges();
        }

        public bool Update(Event eventEntity)
        {
            var existingEvent = GetById(eventEntity.Id);
            if (existingEvent == null)
            {
                return false;
            }

            existingEvent.Name = eventEntity.Name;

            existingEvent.Description = eventEntity.Description;

            //probably don't want
            existingEvent.DateUpdated = DateTime.UtcNow;

            _dataContext.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var eventEntity = GetById(id);
            if (eventEntity == null)
            {
                return false;
            }

            _dataContext.Events.Remove(eventEntity);
            _dataContext.SaveChanges();

            return true;
        }

        public Event GetById(int id)
            => _dataContext.Events.Find(id);

        public IQueryable<Event> GetAll()
            => _dataContext.Events;

    }

}
