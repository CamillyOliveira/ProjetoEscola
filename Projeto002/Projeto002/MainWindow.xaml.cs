using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto002
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            // Informações de Registro

            string nomeFantasia = txtNomeFantasia.Text;
            string razaoSocial = txtRazaoSocial.Text;
            string cnpj = txtCNPJ.Text;
            string incricaoEstadual = txtInscricaoEstadual.Text;
            string tipo = "";
            DatePicker dataCriacao = dpdataCriacao;
            string responsavel = txtResponsavel.Text;
            RadioButton publico = rbPublica;
            RadioButton privado = rbPrivado;

            // Localização
            string rua = txtRua.Text;
            string num = txtN.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;


            if (publico.IsChecked == true)
            {
                tipo = publico.Content.ToString();

            }
            if (privado.IsChecked == true)
            {
                tipo = privado.Content.ToString();
            }

            MessageBox.Show("INFORMAÇÕES DE REGISTROS :......." + Environment.NewLine +
                "Nome fantasia : " + nomeFantasia + Environment.NewLine +
                " Razão Social :" + razaoSocial + Environment.NewLine +
                "CNPJ : " + cnpj + Environment.NewLine +
                "Incrição Estadual : " + incricaoEstadual + Environment.NewLine +
                "Tipo" + tipo + Environment.NewLine +
                "Responsável : " + responsavel + Environment.NewLine +
                "Data criação: " + dataCriacao);

            MessageBox.Show("INFORMAÇÕES DE LOCALIZAÇÃO :......." + Environment.NewLine + Environment.NewLine +
                "Rua :" + rua + Environment.NewLine +
                "Nº : " + num + Environment.NewLine +
                "Bairro : " + bairro + Environment.NewLine +
                "Complemento : " + complemento + Environment.NewLine +
                "CEP : " + cep + Environment.NewLine +
                "Cidade : " + cidade + Environment.NewLine +
                "Estado : " + estado + Environment.NewLine +
                "Telefone Pessoal : " + telefone + Environment.NewLine +
                "E-mail : " + email);


            // Informações de registro

            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            txtCNPJ.Clear();
            txtInscricaoEstadual.Clear();
            txtResponsavel.Clear();
            publico.IsChecked = false;
            privado.IsChecked = false;
            dataCriacao.SelectedDate = null;

            // Localização 

            txtRua.Clear();
            txtN.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEstado = null;
        }
    }
    
}
