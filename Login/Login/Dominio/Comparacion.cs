using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Dominio
{
    class Comparacion
    {
        private String userComparer;
        private String passComparer;

        public string UserComparer { get => userComparer; set => userComparer = value; }
        public string PassComparer { get => passComparer; set => passComparer = value; }
    }
}
