﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppContatoForm
{
    public partial class ContatoForm : Form
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ContatoForm()
        {
            InitializeComponent();

            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!rdSexo1.Checked && !rdSexo2.Checked)
                {
                    MessageBox.Show("Marque uma opção");
                }

                else
                {
                    var nome = txtNome.Text;
                    var email = txtEmail.Text;
                    var datanasc = dateDataNascimento.Value;
                    var telefone = txtTelefone.Text;

                    var sexo = "Feminino";

                    if (rdSexo1.Checked)
                    {
                        sexo = "Masculino";
                    }

                    string query = "INSERT INTO contato_con (nome_con,email_con, data_nasc_con, sexo_con, telefone_con ) VALUES (@_nome,  @_email, @_dataNascimento, @_sexo, @_telefone)";
                    var comando = new MySqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_dataNascimento", datanasc);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_telefone", telefone);

                    comando.ExecuteNonQuery();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreram erros ao salvar informações! " +
                    "Contate a equipe de suporte do sistema. (cad 10)");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdSexoGroup_ValueChanged(object sender, int index, string text)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
