using System;
using System.Collections.Generic;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Большие гонки. На шоу Большие гонки собираются 4 команды из разных стран. В команде по 15 человек. Всего за одну игру команда проходит по 6 испытаний (6 разных игр).");
            BigRace superRace = new BigRace("Оливье Ганьян");
            Team RussianTeam = new Team("Россия", "Снежные Волки",
                new Player("Иванов", "Россия"),
                new Player("Петров", "Россия"),
                new Player("Сидоров", "Россия"),
                new Player("Кузнецов", "Россия"),
                new Player("Попов", "Россия"),
                new Player("Смирнов", "Россия"),
                new Player("Васильев", "Россия"),
                new Player("Николаев", "Россия"),
                new Player("Фёдоров", "Россия"),
                new Player("Макаров", "Россия"),
                new Player("Михайлов", "Россия"),
                new Player("Тарасов", "Россия"),
                new Player("Зайцев", "Россия"),
                new Player("Семенов", "Россия"),
                new Player("Григорьев", "Россия"));

            Team ChinaTeam = new Team("Китай", "Летящие Тигры",
                new Player("Ван Ли", "Китай"),
                new Player("Чжан Мин", "Китай"),
                new Player("Лю Ян", "Китай"),
                new Player("Фан Чэн", "Китай"),
                new Player("Сунь Лэй", "Китай"),
                new Player("Чэнь Юй", "Китай"),
                new Player("Го Ши", "Китай"),
                new Player("Хуан Цзе", "Китай"),
                new Player("Ма Фэн", "Китай"),
                new Player("Юань Чжан", "Китай"),
                new Player("Линь Вэй", "Китай"),
                new Player("Цзинь Лун", "Китай"),
                new Player("Чжао Хуа", "Китай"),
                new Player("Сяо Лэй", "Китай"),
                new Player("Дэн Хай", "Китай"));

            Team FranceTeam = new Team("Франция", "Французские Львы",
                new Player("Луи Дюран", "Франция"),
                new Player("Поль Жирар", "Франция"),
                new Player("Марсель Блан", "Франция"),
                new Player("Анри Ламбер", "Франция"),
                new Player("Эмиль Фонтен", "Франция"),
                new Player("Филипп Рено", "Франция"),
                new Player("Клод Морен", "Франция"),
                new Player("Реми Симон", "Франция"),
                new Player("Пьер Фабр", "Франция"),
                new Player("Оливье Бертран", "Франция"),
                new Player("Тома Пуарье", "Франция"),
                new Player("Андре Маршан", "Франция"),
                new Player("Жан Шарпантье", "Франция"),
                new Player("Мишель Бонье", "Франция"),
                new Player("Бенуа Дюпон", "Франция"));

            Team KazakhstanTeam = new Team("Казахстан", "Золотые Орлы",
                new Player("Ермек Жанабаев", "Казахстан"),
                new Player("Бакыт Нургалиев", "Казахстан"),
                new Player("Алмас Кайратов", "Казахстан"),
                new Player("Данияр Абенов", "Казахстан"),
                new Player("Серик Курмангалиев", "Казахстан"),
                new Player("Азамат Сулейменов", "Казахстан"),
                new Player("Мурат Жуманов", "Казахстан"),
                new Player("Айдар Кенжебеков", "Казахстан"),
                new Player("Бахытжан Аргынов", "Казахстан"),
                new Player("Жанибек Сагынов", "Казахстан"),
                new Player("Ерлан Ахметов", "Казахстан"),
                new Player("Шамиль Кумар", "Казахстан"),
                new Player("Кайрат Байжанов", "Казахстан"),
                new Player("Нурлан Ергешев", "Казахстан"),
                new Player("Ербол Сейтказиев", "Казахстан"));

            superRace.AddTeams(RussianTeam);
            superRace.AddTeams(ChinaTeam);
            superRace.AddTeams(FranceTeam);
            superRace.AddTeams(KazakhstanTeam);

            List<Game> gameList = new List<Game>{new Beach(), new Fishing(), new HideNSeek(), new MouseTrap(), new Postman(), new Sea(), new Slide()};
            superRace.SelectRandomGames(gameList);

            superRace.StartCompetition();
        }
    }
}
