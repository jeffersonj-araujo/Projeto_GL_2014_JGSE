    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GL_CamadaDados.Negocio
{
    public class Cliente
    {
        private int intCodigo;
        private string strNome;
        private string strCPF;
        private string strCNPJ;
        private string strEndereco;
        private string strEmail;
        private string strTelefone;


        Cliente(int _Codigo, string _Nome, string _CPF, string _CNPJ, string _Endereco, string _Email, string _Telefone)
        {
            Codigo = _Codigo;
            Nome = _Nome;
            CPF = _CPF;
            CNPJ = _CNPJ;
            Endereco = _Endereco;
            Email = _Email;
            Telefone = _Telefone;
        }

        
        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public string Nome
        {
            get { return strNome; }
            set { strNome = value; }
        }
        
        public string CPF
        {
            get { return strCPF; }
            set { strCPF = value; }
        }

        public string CNPJ
        {
            get { return strCNPJ; }
            set { strCNPJ = value; }
        }

        public string Endereco
        {
            get { return strEndereco; }
            set { strEndereco = value; }
        }

        public string Telefone
        {
            get { return strTelefone; }
            set { strTelefone = value; }
        }
        
        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
       
    }
}
