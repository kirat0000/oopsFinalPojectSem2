using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingApp1.Data
{
    public interface IEventManager
    {
        Task<List<Event>> GetAll(string genre);
        Task<Event> GetById(int concertId);
        Task<bool> Delete(int concertId);
        Task<bool> InsertEvent(Event eventData);
        Task<bool> UpdateEvent(Event eventData);
    }
}
