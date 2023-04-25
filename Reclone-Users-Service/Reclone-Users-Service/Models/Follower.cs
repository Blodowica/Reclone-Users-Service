namespace Reclone_Users_Service.Models
{
    public class Follower
    {
        public long Id { get; set; }
        public string UserFollowerId { get; set; }// the user that is follwing another user 
        public int UserFollowingId { get; set; }// the user that is being followed
    }
}
