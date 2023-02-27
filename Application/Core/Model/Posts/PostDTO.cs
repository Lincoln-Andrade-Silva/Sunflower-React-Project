using Application.Core.Model.Profiles;
using Application.Core.Model.Attendee;

namespace Application.Core.Model.Posts
{
    public class PostDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
        public string HostUsername { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<AttendeeDTO> Attendees { get; set; }
    }
}