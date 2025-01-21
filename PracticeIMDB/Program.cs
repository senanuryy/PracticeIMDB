using PracticeIMDB;

class Program
{
    static void Main(string[] args)
    {
        List<Film> filmler = new List<Film>();

        string filmAdi;
        double imdbPuani;
        string filmEkle;
        do
        {
            Console.Write("\nFilmin adını giriniz: ");
            filmAdi = Console.ReadLine();

            Console.Write("Filmin IMDb puanını giriniz: ");
            imdbPuani = Convert.ToDouble(Console.ReadLine());

            filmler.Add(new Film(filmAdi,imdbPuani));

            Console.Write("\nBaşka bir film eklemek istiyor musunuz? (Evet/Hayır): ");
            filmEkle = Console.ReadLine().ToLower();

        } while (filmEkle == "evet");


        Console.WriteLine("\n-----------------Bütün Filmler----------------");
        foreach (Film film in filmler)
        {
            Console.WriteLine("Film Adı: " + film.FilmAdi + " IMDb: " + film.ImdbPuani);
        }

        Console.WriteLine("\n--------IMDb 4-9 Arasında Olan Filmler--------");
        foreach (Film film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine("Film Adı: " + film.FilmAdi + " IMDb: " + film.ImdbPuani);
            }            
        }

        Console.WriteLine("\n--------İsmi 'A' ile Başlayan Filmler---------");
        foreach (Film film in filmler)
        {
            if (film.FilmAdi.StartsWith("A") || film.FilmAdi.StartsWith("a"))
            {
                Console.WriteLine("Film Adı: " + film.FilmAdi + " IMDb: " + film.ImdbPuani);
            }
        }

    }
}

