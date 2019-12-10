using HomeWork2019._12._14_2_.AbstractModels;

namespace HomeWork2019._12._14_2_.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Content { get; set; }
        public int LikeCount { get; set; }
        public int UserId { get; set; }
    }
}
