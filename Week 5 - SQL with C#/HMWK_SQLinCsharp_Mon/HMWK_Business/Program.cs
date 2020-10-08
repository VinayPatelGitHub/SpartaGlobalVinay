using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using HMWK_SQLinCsharp_Mon;

namespace HMWK_Business
{
    public class CRUDManager
    {
        static void Main(string[] args)
        {
            using (var db = new Eng65Context())
            {
                //var newFilmEntry = new FilmTable()
                //{
                //    FilmName = "Tarzan",
                //    FilmType = "Kids",
                //    //Director = "",
                //    //PlotSummart = ""
                //};
                //db.FilmTable.Add(newFilmEntry);

                //var selectedFilm = db.FilmTable.Where(c => c.FilmName == "Tarzan").FirstOrDefault();
                //selectedFilm.PlotSummart = "man thinks he is Ape";

                //var selectedFilm = db.FilmTable.Where(c => c.FilmId == 2).FirstOrDefault();
                //db.FilmTable.Remove(selectedFilm);

                //db.SaveChanges();

                foreach (var item in db.FilmTable)
                {
                    Console.WriteLine($"{item.FilmName}, {item.Director}, {item.PlotSummart}");
                }



            }




            
        }
    }
}
