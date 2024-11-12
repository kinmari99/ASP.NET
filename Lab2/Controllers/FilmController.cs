using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Film> films = new List<Film>
        {

            new Film(){Id =1, Name="Film1", Description="opis filmu1", Price=4},
            new Film(){Id = 2, Name = "Film2", Description = "opis filmu2", Price=5},
            new Film(){Id = 3, Name = "Film3", Description = "opis filmu3", Price=3}


        };

        // GET: FilmyController
        public ActionResult Index()
        {
            return View(films);
        }

        // GET: FilmyController/Details/5
        public ActionResult Details(int id)
        {
            return View(films.FirstOrDefault(x=>x.Id==id));
        }

        // GET: FilmyController/Create
        public ActionResult Create()
        {
            return View(new Film());
        }

        // POST: FilmyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            film.Id = films.Count + 1;
            films.Add(film);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: FilmyController/Edit/5
        public ActionResult Edit(int id)
        {
            Film film = films.FirstOrDefault(x => x.Id == id);
         return View(film);
        }

        // POST: FilmyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save( int id, Film newFilm)
        {
            Film film = films.FirstOrDefault(x => x.Id == id);
            film.Name = newFilm.Name;
            film.Description = newFilm.Description;
            film.Price = newFilm.Price;
            return RedirectToAction(nameof(Index));
        }

        // GET: FilmyController/Delete/5
        public ActionResult Delete(int id)
        {
            Film film = films.FirstOrDefault(x => x.Id == id);
            return View(film);
        }

        // POST: FilmyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Film film)
        {
            Film film2 = films.FirstOrDefault(x => x.Id == id);
            films.Remove(film2);
            return RedirectToAction(nameof(Index));
        }
    }
}
