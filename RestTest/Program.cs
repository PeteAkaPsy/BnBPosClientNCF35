using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestTest
{
    class Program
    {

        bool hasRunLogin = false;
        bool hasRunTest = false;
        bool hasRunLogout = false;

        static void Main(string[] args)
        {
            string testIP = "http://192.168.178.67:8081/";

            RetroLab.REST.RestClient restClient = new RetroLab.REST.RestClient(testIP);

            LoginData loginData;
            loginData.userName = "Admin";
            loginData.passwd = "Admin";

            restClient.RequestAuth("r/login", loginData, 
                result => {
                    Console.WriteLine("LoginResult: " + result);
                    restClient.Get<bool>("r/testlogin", null, 
                        result2 => { 
                            Console.WriteLine("Authenticated: " + result2);
                            restClient.DiscardAuth("r/logout");
                        }, errors => { });
                }, errors => { });

            while (true)
            {
            }
        }

        [Serializable]
        public struct LoginData
        {
            public string userName;
            public string passwd;
        }
    }
}
