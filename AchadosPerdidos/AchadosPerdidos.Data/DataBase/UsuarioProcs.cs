using AchadosPerdidos.Data.Entities;
using AchadosPerdidos.Infra.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AchadosPerdidos.Data.DataBase
{
    public class UsuarioProcs
    {
        public Usuario ObterUsuario(int idUsuario)
        {
            SqlDataReader _reader = null;
            SqlConnection conexao = new SqlConnection();
            UsuarioEntity usuario = new UsuarioEntity();

            //conexao.ConnectionString = "";

            //SqlCommand _command = new SqlCommand();
            //_command.CommandType = CommandType.Text;
            //_command.CommandText = "";
            //_command.Parameters.AddWithValue("@idUsuario", idUsuario);

            //_command.Connection = conexao;

            //try
            //{
            //    conexao.Open();

            //    _reader = _command.ExecuteReader();
            //    usuario.Nome = _reader["nome"].ToString();


            //    conexao.Close();
            //    return usuario.ToEntity();
            //}
            //catch(Exception ex)
            //{
            //    conexao.Close();
            //    throw new Exception("Falha ao obter usuario!", ex);
            //}


            usuario.Nome = "Lorrann";
            usuario.Sobrenome = "Correa";
            usuario.IdUsuario = 10;
            usuario.Telefone = "(19) 99741-4052";
            usuario.Administrador = true;
            usuario.DadaNascimento = new DateTime(1992, 3, 29).Date;
            usuario.Email = "lorrann@outlook.com";


            return usuario.ToEntity();
        }
    }
}
