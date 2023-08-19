namespace ConcertBookingApp1.Data;

public class EventController
{
	private readonly IEventManager _eventManager;
	public EventController(IEventManager eventManager)
	{
		_eventManager = eventManager;
	}
    public async Task<List<Event>>  GetEvents(string search) { return await _eventManager.GetAll(search); }	
    public async Task<bool> AddEvent(Event eventData)
	{
		return await _eventManager.InsertEvent(eventData);

    }
    public async Task<bool> UpdateEvent(Event eventData)
    {
        return await _eventManager.UpdateEvent(eventData);

    }
    public async Task<Event> GetEventById(int concertId)
    {
        return await _eventManager.GetById(concertId);

    }
    public async Task<bool> Delete(int concertId)
    {
        return await _eventManager.Delete(concertId);

    }
}

