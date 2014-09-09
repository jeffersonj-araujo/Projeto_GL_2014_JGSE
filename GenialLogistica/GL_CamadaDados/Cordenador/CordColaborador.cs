using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GL_CamadaDados.Dados;
using GL_CamadaDados.Negocio;

namespace GL_CamadaDados.Cordenador
{
    class CordColaborador
    {
        public void Cadastrar(Colaborador ObjColaborador)
        {
            DalColaborador.getInstance().Cadastrar(ObjColaborador);

        }
    }
}
