namespace _01_Lerlings_Aufgabe.Data
{
    public class CalcService
    {
        private List<calcItem> calcItems;

        public CalcService() {
        calcItems = CreateCalcItems();
        }

        private List<calcItem> CreateCalcItems() {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(i => {
                var id = i;
                return new calcItem
                {
                    Id = id,
                    Item = "Item" + id.ToString(),
                    Amount = rng.Next(1, 10),
                    Price = rng.Next(1, 10),
                    Result = 0
                };
            }).ToList();
        }

        public List<calcItem> GetCalcItems() {  return calcItems; }

    }
}
