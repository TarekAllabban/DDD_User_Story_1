
namespace DDD_User_Story_1.Domain.Entitys
{
    // [Aggregat]
    public class Room
    {
        public int Id { get; private set; }
        public string Number { get; private set; }
        public string Name { get; private set; }
        public List<int> PersonInRoom { get; private set; }

        public string returnKurzname(Person pers)
        {            
            return $"{pers.Titel} {pers.Vorname} {pers.Namenszusatz} {pers.Nachname} ({pers.LDAP})";
        }

        public void addPerson(int personId)
        {
            if (!PersonInRoom.Contains(personId))
            {
                PersonInRoom.Add(personId);
            }
        }
    }
}
