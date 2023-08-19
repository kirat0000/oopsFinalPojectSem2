
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcertBookingApp1.Data
{
    public class EventManager : IEventManager
    {
        EventContext DBContext = new EventContext();
        //Read data of all Flights
        public async Task<List<Event>> GetAll(string genre)
        {
            List<Event> data = new List<Event>();
            try
            {
                if (!string.IsNullOrEmpty(genre))
                {
                    var row = await DBContext.events.Where(x => x.genre.Contains(genre)).ToListAsync();
                    if (row != null)
                    {
                        data = row;
                    }
                }
                else
                {
                    var row = await DBContext.events.ToListAsync();
                    if (row != null)
                    {
                        data = row;
                    }
                }
            }

            catch (Exception e)
            {

            }
            return data;
        }
        public async Task<Event> GetById(int concertId)
        {
            try
            {

                var row = await DBContext.events.FindAsync(concertId);
                return row;

            }

            catch (Exception e)
            {

            }
            return null;
        }
        public async Task<bool> InsertEvent(Event eventData)
        {
            var response = false;
            if (eventData != null)
            {
                DBContext.events.Add(eventData);
                await DBContext.SaveChangesAsync();
                response = true;
            }
            return response;
        }
        public async Task<bool> UpdateEvent(Event eventData)
        {
            var response = false;
            if (eventData != null)
            {
                var data = DBContext.events.Find(eventData.Concert_Id);

                DBContext.Entry(data).State = System.Data.Entity.EntityState.Detached;
                DBContext.Entry(eventData).State = System.Data.Entity.EntityState.Modified;

                await DBContext.SaveChangesAsync();
                response = true;
            }
            return response;
        }

        public async Task<bool> Delete(int concertId)
        {
            var data = DBContext.events.Find(concertId);

            DBContext.Entry(data).State = System.Data.Entity.EntityState.Deleted;          
            await DBContext.SaveChangesAsync();
            return true;
        }
    }
}
