using DDD_User_Story_1.Domain.Entitys;

namespace DDD_User_Story_1.Infrastructure.Dto
{
    public class RoomDto
    {
        public string number = String.Empty;
        public string name = String.Empty; 
        public List<Person> personInRoom = new List<Person>();

    }
}
