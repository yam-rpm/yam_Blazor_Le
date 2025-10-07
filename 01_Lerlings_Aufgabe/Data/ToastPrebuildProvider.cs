namespace _01_Lerlings_Aufgabe.Data
{
    public class TostPrebuildPorvider
    {
        public TostPrebuildPorvider() { }

        public static List<ToastPrebuild> GetToastPrebuilds() {
            return new List<ToastPrebuild> {
            new ("Positioning", "Hey", "This is a Tost"),
            new ("Positioning", "What", "This is Great right?"),
            new ("Positioning", "Rent", "Rent is due"),
            new ("Positioning", "Joke", "Scientist: “My findings are meaningless if taken out of context.”\r\nMedia: Scientist claims “Findings are meaningless.”")
            };
        }

    }
}
