using DDD_User_Story_1.Domain.Entitys.ValueObject;

namespace DDD_User_Story_1.Domain.Entitys
{
    // [Aggregat]
    public class Person
    {
        public int Id { get; private set; }
        
        public Titel Titel { get; private set; }
        
        public string Vorname { get; private set; }
        
        public string Nachname { get; private set; }
        
        public string LDAP { get; private set; }
        
        public Namenszusatz Namenszusatz { get; private set; }
    }
    
    
}