using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ConcertBookingApp1.Data;

namespace ConcertBookingApp1.Data
{
	public class EventContext : DbContext
    {   //Set connection string for  Connect sql database
        public static string strConnectionStringTemplate = @"Data Source=localhost;Initial Catalog=Assignment;Integrated Security=True";

		public EventContext()
        : base(strConnectionStringTemplate)
        {
			// Disable database initialization
			Database.SetInitializer<EventContext>(null);
        }

		public virtual DbSet<Event> events { get; set; }

     
    }
}
