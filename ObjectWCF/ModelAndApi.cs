using System;
using ModelAndApi;

namespace ObjectWCF
{
    public class ModelAndApi : Contracts
    {
        void Contracts.LoadDb(string path, string events, string persons, string peisaj, string locatie, string altele, DateTime creationDate)
        {
            API api = new API.LoadDb();
            api.Load(paths,locatie,evenimente,persons, persons2, locatie2, evenimente2);
        }

        void Contracts.RemovePhoto(string path)
        {
            API api = new API.RemovePhoto();
            api.DeleteMedia(path);
        }

        object Contracts.UploadPhoto(string imglocation, string fullname, string date, string location, string eveniment, string person)
        {
            API api = new API.UploadPhoto();
            return api.AddPhoto(imglocation,fullname,date, location, eveniment,  person);
        }
    }
}
