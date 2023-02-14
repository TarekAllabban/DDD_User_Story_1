using DDD_User_Story_1.Domain.Entitys;

namespace DDD_User_Story_1.Domain.Repository
{
    public interface IPersonRepository
    {
        Person GetPerson(Person person);
        Person SetPerson(Person person);
    }
}
