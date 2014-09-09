using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GL_CamadaDados.Cordenador;
using GL_CamadaDados.Negocio;
using GL_CamadaDados.SQL;
using System.Data.SqlClient;
using System.Data;

namespace GL_CamadaDados.Dados
{
    class DalColaborador
    {
    
        public static DalColaborador objDalColaborador;
        
        //PADRÃO SINGLENTON
        public static DalColaborador getInstance()
        {
            if (objDalColaborador == null)
                objDalColaborador = new DalColaborador();

            return objDalColaborador;
        
        }
       
        public void Cadastrar(Colaborador objColaborador)
        {
            try
            {
                SQLConn con = new SQLConn(); 
                SqlCommand cmd = new SqlCommand("SP_GL_InsereColaborador", con.Conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = objColaborador.Usuario;
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = objColaborador.Nome;
                cmd.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = objColaborador.Sobrenome;
                cmd.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = objColaborador.Sexo;
                cmd.Parameters.Add("@CPF", SqlDbType.Int).Value = objColaborador.CPF;
                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = objColaborador.Endereco;
                cmd.Parameters.Add("@Numero", SqlDbType.VarChar).Value = objColaborador.Numero;
                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = objColaborador.Cidade;
                cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = objColaborador.Estado;
                cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = objColaborador.CEP;
                cmd.Parameters.Add("@Telefone", SqlDbType.Int).Value = objColaborador.Telefone;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = objColaborador.Email;
                cmd.Parameters.Add("@Transporte", SqlDbType.VarChar).Value = objColaborador.Trasnporte;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = objColaborador.Senha;
                cmd.Parameters.Add("@ConfSenha", SqlDbType.VarChar).Value = objColaborador.ConfSenha;

                if (objColaborador.Senha == objColaborador.ConfSenha) 
                {
                    con.ConOpen("Desktop");
                    cmd.ExecuteNonQuery();              
                }

                else
                {
                    
                }            
   
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
           
        }
   
    }
}
