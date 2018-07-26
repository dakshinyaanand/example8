using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class LoginDAL
    {
        public bool Authenticate(LoginEntity le)
        {
            try
            {
                TrainingDBEntities db = new TrainingDBEntities();
                var data = (from t in db.RegisterShoppings
                            where t.Id == le.UserID && t.Password == le.password
                            select t).SingleOrDefault();
                if (data == null)
                    throw new Exception("invalid credentials");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
