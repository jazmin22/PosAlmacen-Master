﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo01.models;

namespace WebAppDemo01.viewmodels
{
    public class ListaUsuariosViewModel
    {
        public IEnumerable<Usuarios> Usuarios { get; set; }
        public string CategoriasUsuarios { get; set; }
    }
}
