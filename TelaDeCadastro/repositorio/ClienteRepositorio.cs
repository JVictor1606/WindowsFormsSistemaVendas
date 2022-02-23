using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaDeCadastro.model;

namespace TelaDeCadastro.repositorio
{
    public class ClienteRepositorio
    {
        string conex = @"Server=DESKTOP-0QN57TB\SQL;Database=joaodb;User Id=sa;Password=jvictor10";
        public void Insert(Cliente cliente)
        { 
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("insert into clientes (nome,cpf,dataNascimento,sexo) values (@nome,@cpf,@dataNascimento,@sexo) ", conn);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@dataNascimento", cliente.dataNascimento);
            cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Atualizar(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("update  clientes set nome = @nome,cpf = @cpf,dataNascimento = @dataNascimento ,sexo = @sexo where id = @id  ", conn);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@dataNascimento", cliente.dataNascimento);
            cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Int64 id)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("delete from clientes where id = @id ", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Cliente> SelecionarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd  = new SqlCommand("select  id,nome,cpf,dataNascimento,sexo from clientes  ", conn);
            //cmd.Parameters.AddWithValue("@nome", cliente.nome);
            conn.Open();
            SqlDataReader rd =  cmd.ExecuteReader();
            while(rd.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = Convert.ToInt64(rd[0]);
                cliente.nome = Convert.ToString(rd[1]);
                cliente.cpf = Convert.ToString(rd[2]);
                cliente.dataNascimento = Convert.ToDateTime(rd[3]);
                cliente.sexo = Convert.ToChar(rd[4]);
                lista.Add(cliente);
            }
            conn.Close();
            return lista;
        }

        public Cliente SelecionarCliente(Int64 id)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("select  id,nome,cpf,dataNascimento,sexo from clientes where id = @id  ", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            Cliente cliente = new Cliente();
            if (rd.Read())
            {  
                cliente.id = Convert.ToInt64(rd[0]);
                cliente.nome = Convert.ToString(rd[1]);
                cliente.cpf = Convert.ToString(rd[2]);
                cliente.dataNascimento = Convert.ToDateTime(rd[3]);
                cliente.sexo = Convert.ToChar(rd[4]);
            }
            conn.Close();
            return cliente;
        }
        public List<Cliente> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            string comando = "select  id,nome,cpf,dataNascimento,sexo from clientes  ";
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if(tipoPesquisa == 0)
            {
                cmd = new SqlCommand(comando + " where nome LIKE @nome", conn);
                cmd.Parameters.AddWithValue("@nome", "%" + textoPesquisa + "%");
            }
            else if(tipoPesquisa == 1)
            {
                cmd.CommandText = comando + " where cpf = @cpf";
                cmd.Parameters.AddWithValue("@cpf", Convert.ToString(textoPesquisa));
            }
            else
            {
                cmd.CommandText = comando + " where dataNascimento = @dataNascimento";
                cmd.Parameters.AddWithValue("@dataNascimento", Convert.ToDateTime(textoPesquisa).ToString("yyyy-MM-dd") );
            }
           
            conn.Open();
            Console.WriteLine(cmd.CommandText);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = Convert.ToInt64(rd[0]);
                cliente.nome = Convert.ToString(rd[1]);
                cliente.cpf = Convert.ToString(rd[2]);
                cliente.dataNascimento = Convert.ToDateTime(rd[3]);
                cliente.sexo = Convert.ToChar(rd[4]);
                lista.Add(cliente);
            }
            conn.Close();
            return lista;
        }
    }

}
