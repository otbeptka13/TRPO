using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbPankovES.DomainObject
{
    public class  Login
    {

        public int? TryLogin(string Login, string Password)
        {
            using (var db = new Models.baseDataDataContext())
            {
                var result = db.TryLogin(Login, Password);
                return result;
            }
        }
    }
}
