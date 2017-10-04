using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dents.Controller
{
    public class UserController
    {
        Model.UserModel user = new Model.UserModel();

        public DataTable getUserByCredential(string username, string password)
        {
            try
            {
                return user.getUserByCredential(username,password);
            }

            catch
            {
                throw;
            }
        }

        public DataTable getUserById(int id)
        {
            try
            {
                return user.getUserById(id);
            }

            catch
            {
                throw;
            }
        }

        public DataTable getOtherUsers()
        {
            try
            {
                return user.getOtherUsers();
            }

            catch
            {
                throw;
            }
        }

        public Boolean deleteUser(int id)
        {
            try
            {
                return user.deleteUser(id);
            }
            catch
            {
                return false;
            }
        }

        public Int32 addUser(string username, string password, string firstname, string lastname)
        {
            try
            {
                return user.addUser(username, password, firstname, lastname);
            }
            catch
            {
                throw;
            }
        }

        public Boolean updateUser(string id, string username, string firstname, string lastname)
        {
            try
            {
                return user.updateUser(id, username, firstname, lastname);
            }
            catch
            {
                return false;
            }
        }

        public Boolean changePassword(string id, string password)
        {
            try
            {
                return user.changePassword(id, password);
            }
            catch
            {
                return false;
            }
        }
    }
}
