using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using libraries.DAL;
using libraries.DTL;
namespace CSharpProject
{
    /// <summary>
    /// Summary description for eosWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public bool CheckLogin(User user)
        {
            return true;
        }

    }
}
