namespace _01_Lerlings_Aufgabe.Data
{
    public record calcItem
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int Result { get; set; }
    }
}