using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GL_CamadaDados.Negocio
{
   public class Colaborador
    {
        private int intCodigo;
        private string strNome;
        private string strSobrenome;
        private string strSexo;
        private string strCPF;
        private string strEndereco;
        private int strNumero;
        private string strCidade;
        private string strEstado;
        private int intCEP;
        private int intTelefone;
        private string strEmail;
        private string strTransporte;
        private string strUsuario;
        private string strSenha;
        private string strConfSenha;

        Colaborador(int _Codigo, string _Nome, string _Sobrenome, string _Sexo, 
                    string _CPF, string _Endereco, int _Numero, string _Cidade, string _Estado, 
                    int _CEP, int _Telefone, string _Email, string _Transporte, string _Usuario, 
                    string _Senha, string _ConfSenha )
            {
                Codigo = _Codigo;
                Nome = _Nome;
                Sobrenome = _Sobrenome;
                Sexo = _Sexo;
                CPF = _CPF;
                Endereco = _Endereco;
                Cidade = _Cidade;
                Estado = _Estado;
                CEP = _CEP;
                Numero = _Numero;
                Email = _Email;
                Trasnporte = _Transporte;
                Telefone = _Telefone;
                Usuario = _Usuario;
                Senha = _Senha;
                ConfSenha = _ConfSenha;
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


        public string Sobrenome
        {
            get { return strSobrenome; }
            set { strSobrenome = value; }
        }

        public string Cidade
        {
            get { return strCidade; }
            set { strCidade = value; }
        }

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

        public int CEP
        {
            get { return intCEP; }
            set { intCEP = value; }
        }

        public string Endereco
        {
            get { return strEndereco; }
            set { strEndereco = value; }
        }

               public int Numero
        {
            get { return strNumero; }
            set { strNumero = value; }
        }
 
        public string Sexo
        {
            get { return strSexo; }
            set { strSexo = value; }
        }


        public string CPF
        {
            get { return strCPF; }
            set { strCPF = value; }
        }

        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }

        public int Telefone
        {
            get { return intTelefone; }
            set { intTelefone = value; }
        }


        public string Trasnporte
        {
            get { return strTransporte; }
            set { strTransporte = value; }
        }


        public string ConfSenha
        {
            get { return strConfSenha; }
            set { strConfSenha = value; }
        }
        public string Usuario
        {
            get { return strUsuario; }
            set { strUsuario = value; }
        }

        public string Senha
        {
            get { return strSenha; }
            set { strSenha = value; }
        }
 
   
   }
}
