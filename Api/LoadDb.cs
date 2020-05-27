using ClassLibrary4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.API
{
    public class LoadDb
    {
        public (List<string>, List<string>, List<string>, List<string>) Load(List<string> paths, List<string> locatie, List<string> evenimente, List<string> persons, string persons2,string locatie2,string evenimente2)
        {
            ModelContainer dbContext = new ModelContainer();
            var query = (from p in dbContext.Pictures
                         select p);
            IEnumerable<Picture> pictures = query.ToList();
            foreach (Picture p in pictures)
            {
                paths.Add(p.Path);
                var query2 = (from p2 in dbContext.People
                              where p2.PictureId == p.Id
                              select p2);
                foreach (Person p2 in query2)
                { persons2 = p2.person_name; }
                var query3 = (from p3 in dbContext.Details
                              where p3.PictureId == p.Id
                              select p3);
                foreach (Details p3 in query3)
                {
                    evenimente2 = p3.eveniment;
                    locatie2 = p3.location;
                }
                locatie.Add(locatie2);
                evenimente.Add(evenimente2);
                persons.Add(persons2);
            }
            return (paths, locatie, evenimente, persons);
        }
    }
}
