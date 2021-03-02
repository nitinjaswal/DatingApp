namespace API.Entities
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; } // The user that is liking the another user.
        public int SourceUserId { get; set; }

        public AppUser LikedUser { get; set; }
        public int LikedUserId { get; set; }

    }
}