using DDD_User_Story_1.Domain.Entitys.ValueObject;

namespace DDD_User_Story_1._3Infrastructure.Dto
{
    public class PersonDto
    {
        
        public Titel Titel { get; set; }
        
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public string LDAP { get; set; }

        public Namenszusatz Namenszusatz { get; set; }

    }
}
