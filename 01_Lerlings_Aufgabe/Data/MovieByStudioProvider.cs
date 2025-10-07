namespace _01_Lerlings_Aufgabe.Data
{
    public class MovieByStudioProvider
    {
        public MovieByStudioProvider() { }
        public static List<MovieByStudio> GenerateList()
        {
            return new List<MovieByStudio> {
        new (1, 0, "DreamWorks", "Movies", 983),
        new (2, 1, "DreamWorks Animation", "The Prince of Egypt", 218000000),
        new (3, 1, "DreamWorks Animation", "Shrek", 484400000),
        new (4, 1, "DreamWorks Animation", "How to Train Your Dragon", 494900000),
        new (5, 0, "Pixar", "Movies", 1001),
        new (6, 5, "Pixar", "Toy Story", 373600000),
        new (7, 5, "Pixar", "Finding Nemo", 940300000),
        new (8, 5, "Pixar", "Inside Out", 857600000),
        new (9, 0, "Warner Bros", "Movies", 1500),
        new (10, 9, "Warner Bros", "The Dark Knight", 1005000000),
        new (11, 9, "Warner Bros", "Inception", 829900000),
        new (12, 9, "Warner Bros", "The Matrix", 466400000),
        new (13, 0, "Universal Pictures", "Movies", 1200),
        new (14, 13, "Universal Pictures", "Jurassic Park", 1043000000),
        new (15, 13, "Universal Pictures", "Despicable Me", 543100000),
        new (16, 13, "Universal Pictures", "Fast & Furious 7", 1516000000)
    };
        }

    }
}
