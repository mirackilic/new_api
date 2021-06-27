using TodoApi.Base;

namespace TodoApi.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}