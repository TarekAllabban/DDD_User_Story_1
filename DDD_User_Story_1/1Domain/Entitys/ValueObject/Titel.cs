namespace DDD_User_Story_1.Domain.Entitys.ValueObject
{
    public class Titel
    {
        private readonly string _doktor;

        public Titel(string doktor)
        {
            if (String.IsNullOrEmpty(doktor)) return; // optional

            if (doktor != "Dr.") throw new ArgumentException("Titel darf nur Dr. sein");
            
            _doktor = doktor;
        }

    }
}