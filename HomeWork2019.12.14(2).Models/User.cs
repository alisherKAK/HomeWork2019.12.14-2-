using HomeWork2019._12._14_2_.AbstractModels;
using System.Collections.Generic;

namespace HomeWork2019._12._14_2_.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual List<Post> Posts { get; set; } = new List<Post>();
    }
}