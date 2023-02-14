using DDD_User_Story_1.Domain.Repository;
using DDD_User_Story_1.Domain.Entitys;
using DDD_User_Story_1.Infrastructure.Dto;

namespace DDD_User_Story_1.Infrastructure
{
    public class RoomRepositoryImpl : IRoomRepository
    {
        private List<Room> RoomListe = new List<Room>();

        public Room GetRoomById(int id)
        {
            Room retRoom = RoomListe.FirstOrDefault(x => x.Id == id);
            if (retRoom == null) return null;
            return retRoom;
        }

        public Room SaveRoom(Room room)
        {
            //room.Id = RoomListe.Count() + 1;
            RoomListe.Add(room);
            return room;
        }

    }
}
