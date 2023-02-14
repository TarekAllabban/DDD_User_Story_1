using DDD_User_Story_1.Domain.Entitys;
using DDD_User_Story_1.Domain.Repository;

namespace DDD_User_Story_1._2Application
{
    public class RoomService : IRoomRepository
    {       
        public Room GetRoomById(int id)
        {
            var room = new Room();
            return room;
        }

        public Room SaveRoom(Room room)
        {
            throw new NotImplementedException();
        }       
    }
}
