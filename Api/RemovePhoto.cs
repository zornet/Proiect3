using ClassLibrary4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.API
{
    public class RemovePhoto
    {
        public bool Remove(string imglocation)
        {
            ModelContainer dbContext = new ModelContainer();
            var query = from p in dbContext.Pictures
                        where p.Path == imglocation
                        select p;
            foreach (Picture p in query)
            {
                var query2 = from p2 in dbContext.People
                             where p2.PictureId == p.Id
                             select p2;
                foreach (Person p2 in query2)
                { dbContext.People.Remove(p2); }

                var query3 = from p3 in dbContext.Details
                             where p3.PictureId == p.Id
                             select p3;

                foreach (Details p3 in query3)
                { dbContext.Details.Remove(p3); }
                dbContext.Pictures.Remove(p);

            }
            dbContext.SaveChanges();
            return true;
        }
        }
}
