using ClassLibrary4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.API
{
    public class UploadPhoto
    {
        public bool AddPhoto(string imglocation,string fullname,string date,string location,string eveniment,string person)
        {
            ModelContainer context = new ModelContainer();
            var query = from p5 in context.Pictures
                        where p5.Path == imglocation
                        select p5;
            bool ok = true;
            try
            {
                foreach (Picture p5 in query)
                { ok = false; }
            }
            catch { }

            if (ok == false)
            { return false; }
            else
            {
                Picture p = new Picture()
                {
                    Name = fullname,
                    Path = imglocation,
                    Date = date,
                };


                context.Pictures.Add(p);
                if (location != null || eveniment != null)
                {
                    Details p1 = new Details()
                    {
                        eveniment = location,
                        location = eveniment,
                        Picture = p
                    };
                    context.Details.Add(p1);
                }
                if (person != null)
                {
                    Person p2 = new Person()
                    {
                        person_name = person,
                        Picture = p

                    };
                    context.People.Add(p2);
                    context.SaveChanges();
                }
                return true;
            }
        }   
    }
}
