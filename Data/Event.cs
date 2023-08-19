using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertBookingApp1.Data;
[Table("Event")]
public class Event
{
    [Key]
    public int Concert_Id { get; set; }
    public string genre { get; set; }
    public string artist { get; set; }
    public DateTime? date { get; set; }
    public string time { get; set; }
    public string venue { get; set; }
    public string city { get; set; }
    public string description { get; set; }
    public int ticket_cost { get; set; }
}
