using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Dominio
{
    class login : Comparacion
    {
        private String user;
        private String pass;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
