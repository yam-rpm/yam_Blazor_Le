using DevExpress.Blazor.Internal.ComponentStructureHelpers;

namespace _01_Lerlings_Aufgabe.Data
{
    public class MovieByStudio
    {
        public MovieByStudio(int id, int producerId, string producer,  string name, decimal boxoffice) 
        {
            ID = id;
            ProducerID= producerId;
            Producer= producer;
            Name = name;
            Boxoffice = boxoffice;
        }
        public int ID { get; set; }
        public int ProducerID { get; set; }
        public string Producer { get; set; }
        public string Name { get; set; }
        public decimal Boxoffice { get; set; }
    }
}
