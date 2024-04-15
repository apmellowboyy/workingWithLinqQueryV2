using System;
namespace bruh
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            var twentiethCentury = stemPeople.Where(t => t.BirthYear > 1900)
                                              .OrderByDescending(t => t.BirthYear).ToList<famousPeople>();


            var twentiethCentury2 = stemPeople.Where(t => t.BirthYear > 1950)
                                  .OrderByDescending(t => t.Name).ToList<famousPeople>();


            var twentiethCentury3 = stemPeople.Where(t => t.BirthYear > 1920 && t.BirthYear <2000)
                                  .OrderByDescending(t => t.BirthYear).ToList<famousPeople>();

            //MISSING E CODE
            var twentiethCentury5 = stemPeople.Where(t => t.BirthYear > 1700 && t.BirthYear <2020)
                .OrderByDescending(t => t.BirthYear).ToList<famousPeople>();
            //MISSING C CODE
            var twentienthCentury6 = stemPeople.Where(t => t.BirthYear < 1950 )
                .OrderByDescending(t => t.BirthYear).ToList<famousPeople>();

            var twentiethCentury4 = stemPeople.Where(t => t.DeathYear > 1960 && t.DeathYear < 2015)
                                  .OrderBy(t => t.Name).ToList<famousPeople>();
            //MISSING B CODE
            var twentiethCentury7 = stemPeople.Where(t => t.Name.Contains('l') && t.Name.Contains('l')
                                .OrderByDescending(t => t.Name).ToList<famousPeople>());
            //How can I display this? 


            Console.WriteLine("20th Century Stem Influencers");
            foreach (var t in twentiethCentury)
            {
                Console.WriteLine($"{t.Name}\nBorn: {t.BirthYear}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("After 1950");
            foreach (var t in twentiethCentury2)
            {
                Console.WriteLine($"{t.Name}\nBorn: {t.BirthYear}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Between years 1920 and 2000");
            foreach (var t in twentiethCentury3)
            {
                Console.WriteLine($"{t.Name}\nNumber: {t.BirthYear}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Death by Ascending");
            foreach (var t in twentiethCentury4)
            {
                Console.WriteLine($"{t.Name}\nDate: {t.DeathYear}");
            }
            Console.WriteLine();
        }
    }
}