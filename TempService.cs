using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfLibrary
{
    [ServiceContract]
    public interface ITempService
    {
        [OperationContract]
        String GetTest();
        [OperationContract]
        String GetDelbertTest(String pName);
    }

    public class TempService : ITempService
    {
        public String GetTest()
        {
            return "Bonjour " + this.ToString();
        }

        public String GetDelbertTest(String pName)
        {
            return "Non mwen sé Delbert " + pName + " : " + DateTime.Now.ToString();
        }
    }
}
