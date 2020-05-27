using System;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface Contracts
    {
        [OperationCoCntract]
        object LoadDb(List<string> paths, List<string> locatie, List<string> evenimente, List<string> persons, string persons2, string locatie2, string evenimente2);
        [OperationContract]
        object RemovePhoto(string imglocatio);
        [OperationContract]
        object UploadPhoto(string imglocation, string fullname, string date, string location, string eveniment, string person);
 
    }
}
