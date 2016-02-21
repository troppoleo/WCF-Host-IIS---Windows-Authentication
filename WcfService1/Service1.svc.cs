using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetInformation()
        {
            //return string.Format("You entered: {0}", value);
            StringBuilder mySB = new StringBuilder("");
            mySB.AppendLine(string.Format("Is authenticated: {0}", ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated));

            mySB.AppendLine(string.Format("Authentication Type: {0}", ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType));

            mySB.AppendLine(string.Format("Authentication Name: {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name));

            return mySB.ToString();
        }

    }
}
