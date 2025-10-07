namespace _01_Lerlings_Aufgabe.Data
{
    public class ToastPrebuild
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public ToastPrebuild(string name, string title, string content ) {
            {
                 Name = name;
                 Title = title;
                 Text = content;
            };
        }

    }
}
