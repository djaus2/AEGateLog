using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace BlazorQRCode.Data
{
    public class HomeController : Controller
    {
        private static List<Admin> Admins = null;
        private bool _state { get; set; } = false;
        // GET: HomeController
        public bool GetState()
        {
            return _state;
        }

        public void  LogOut()
        {
            ClearState();
        }

        public int Pin { get {return (int)(DateTime.Today.Ticks % 997);} }

        private void SetState()
        {
            _state = true;
        }

        private void ClearState()
        {
            _state = false;
        }

        public bool Authenticate (string name, string pwd)
        {
            _state = false;
            var admins = from ad in Admins where (ad.Name == name) && (ad.Pwd == pwd) select ad;
            if (admins.Count() != 0)
                _state = true;
            return _state;
        }

        public HomeController()
        {
            System.Diagnostics.Debug.WriteLine("5.1");
            if (Admins == null)
            {
                Admins = new List<Admin>();
                Admins.Add( new Admin{Name= "Admin",Pwd ="PWD"} );
            }
            System.Diagnostics.Debug.WriteLine("5.10");
        }

    }
}
