using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Models;

namespace MovieCatalog.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var movies = new List<Movie>
        {
            new() { Title = "Гангстерленд", Image = "mobland.jpg", Genre = "Кримінал, серіал", Rating = 8.4,
                Description = "Дві лондонські кримінальні родини на межі війни, а Гаррі Да Соуза рятує імперію Гарріганів від краху." },
            new() { Title = "Бджоляр", Image = "beekeeper.jpg", Genre = "Бойовик", Rating = 6.3,
                Description = "Колишній агент таємної організації «Бджолярі» мстить шахраям за загибель близької людини." },
            new() { Title = "Я — легенда", Image = "legend.jpg", Genre = "Фантастика", Rating = 7.2,
                Description = "Вірус знищив людство. Останній мешканець Нью-Йорка разом із собакою шукає ліки та вцілілих." },
            new() { Title = "Оппенгеймер", Image = "oppenheimer.jpg", Genre = "Біографія, драма", Rating = 8.3,
                Description = "Історія фізика, який очолив Мангеттенський проєкт і створив зброю, що змінила світ." },
            new() { Title = "Джон Уік 4", Image = "john-wick.jpg", Genre = "Бойовик", Rating = 7.6,
                Description = "Джон Уік шукає спосіб здобути свободу від Правління кланів і проходить через пів світу." },
            new() { Title = "Дюна: Частина друга", Image = "dune.jpg", Genre = "Фантастика", Rating = 8.5,
                Description = "Пол Атрід об'єднується з фрименами Арракіса, щоб помститися за знищену родину." },
            new() { Title = "Дедпул і Росомаха", Image = "deadpool.jpg", Genre = "Бойовик, комедія", Rating = 7.5,
                Description = "Балакучий найманець і похмурий напарник змушені разом рятувати всесвіт." },
            new() { Title = "F1", Image = "f1.jpg", Genre = "Спорт, драма", Rating = 7.7,
                Description = "Ветеран перегонів повертається у Формулу-1, щоб урятувати команду-аутсайдера." },
            new() { Title = "Грішники", Image = "sinners.jpg", Genre = "Жахи", Rating = 7.5,
                Description = "Брати-близнюки відкривають блюзовий клуб у Міссісіпі 1930-х, але там на них чекає давнє зло." },
            new() { Title = "Одіссея", Image = "odyssey.jpg", Genre = "Пригоди", Rating = 8.3,
                Description = "Після Троянської війни цар Ітаки Одіссей вирушає в довгу й небезпечну дорогу додому." },
            new() { Title = "Людина-павук: Абсолютно новий день", Image = "spider-man.jpg", Genre = "Бойовик, фантастика", Rating = 7.8,
                Description = "Світ забув Пітера Паркера. Він починає з нуля й наодинці захищає Нью-Йорк." },
            new() { Title = "Проєкт «Аве Марія»", Image = "hail-mary.jpg", Genre = "Фантастика", Rating = 8.2,
                Description = "Шкільний учитель прокидається на космічному кораблі й розуміє, що має врятувати Землю." }
        };

        return View(movies);
    }
}
