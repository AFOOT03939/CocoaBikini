﻿using CapaDato;
using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_permiso
    {
        private CD_PERMISO objcd_permiso = new CD_PERMISO();
        public List<Permisos> Listar(int idUsuario)
        {
            return objcd_permiso.Listar(idUsuario);
        }
    }
}