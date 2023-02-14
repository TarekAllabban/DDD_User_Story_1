namespace DDD_User_Story_1.Domain.Entitys.ValueObject
{
    public class Namenszusatz
    {
        private readonly string _nz;
        private List<string> zusatzListe = new List<string> 
        {
            "von",
            "van",
            "de"
        }; 


        public Namenszusatz(string nz)
        {
            // prüfen ob Namenzusatz leer
            if (string.IsNullOrEmpty(nz)) return;
            
            // prüfen ob Namenzusatz in Liste
            if (!zusatzListe.Contains(nz.ToLower())) throw new ArgumentException("Namenzusatz nicht in der Liste enthalten");
            // zuordnen
            _nz = nz;
        }
    }
}