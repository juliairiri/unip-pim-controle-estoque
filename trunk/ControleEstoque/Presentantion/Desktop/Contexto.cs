using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desktop
{
    public static class Contexto
    {
        static Entidades.Usuario _usuario;
        public static Entidades.Usuario Usuario
        {
            get { return Contexto._usuario; }
            set { Contexto._usuario = value; }
        }
    }
}
