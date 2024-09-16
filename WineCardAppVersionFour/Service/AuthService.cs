using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCardAppVersionFour.Service
{
    public class AuthService
    {
        private static AuthService _instance;

        private AuthService()
        {

        }

        /// <summary>
        /// Singleton instance of authservice
        /// </summary>
        public static AuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthService();
                }
                return _instance;
            }
        }

        public bool IsAuth { get; set; } = false;
        public string Username { get; set; }

        public void Login(string username)
        {
            Username = username;
            IsAuth = true;
        }

        public void Logout()
        {
            IsAuth = false;
            Username = null;
        }
    }
}
