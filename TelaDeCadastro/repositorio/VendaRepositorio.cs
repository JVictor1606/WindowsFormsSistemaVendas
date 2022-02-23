using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaDeCadastro.model;

namespace TelaDeCadastro.repositorio
{
    public class VendaRepositorio
    {
        string conex = @"Server=DESKTOP-0QN57TB\SQL;Database=joaodb;User Id=sa;Password=jvictor10";
        public void Insert(Venda venda)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("insert into vendas (nomeProduto, unidade, quantidade,precoUnitario, valorTotal, nomeVendedor) values (@nomeProduto, @unidade, @quantidade,@precoUnitario, @precoTotal, @nomeVendedor) ", conn);
            cmd.Parameters.AddWithValue("@nomeProduto", venda.nomeProduto);
            cmd.Parameters.AddWithValue("@unidade", venda.unidade);
            cmd.Parameters.AddWithValue("@quantidade", venda.quantidade);
            cmd.Parameters.AddWithValue("@precoUnitario", venda.precoUnitario);
            cmd.Parameters.AddWithValue("@precoTotal", venda.valorTotal);
            cmd.Parameters.AddWithValue("@nomeVendedor", venda.nomeVendedor);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        
        public List<Venda> SelecionarTodos()
        {
            List<Venda> lista = new List<Venda>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("select id,nomeProduto,unidade,quantidade,precoUnitario,valorTotal,nomeVendedor from vendas  ", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Venda venda = new Venda();
                venda.id = Convert.ToInt64(rd[0]);
                venda.nomeProduto = Convert.ToString(rd[1]);
                venda.unidade = Convert.ToString(rd[2]);
                venda.quantidade = Convert.ToString(rd[3]);
                venda.precoUnitario = Convert.ToString(rd[4]);
                venda.valorTotal = Convert.ToString(rd[5]);
                venda.nomeVendedor = Convert.ToString(rd[0]);
                lista.Add(venda);
            }
            conn.Close();
            return lista;
        }
        
    }
}