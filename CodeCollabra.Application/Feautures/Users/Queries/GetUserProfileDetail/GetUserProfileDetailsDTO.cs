using CodeCollabra.Domain;

namespace CodeCollabra.Application.Feautures.Users.Queries.GetUserProfileDetail
{
    public class GetUserProfileDetailsDTO
    {
        public string Username { get; set; } 
        public string UserEmail { get; set; }
        public int PointValue { get; set; }
        public IReadOnlyList<Achievements> Achievements { get; set; }
    }
}
