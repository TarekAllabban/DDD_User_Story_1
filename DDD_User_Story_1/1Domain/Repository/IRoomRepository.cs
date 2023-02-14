using DDD_User_Story_1.Domain.Entitys;

namespace DDD_User_Story_1.Domain.Repository
{
    public interface IRoomRepository
    {
      Room GetRoomById(int id);
      Room SaveRoom(Room room);        
    }
}
