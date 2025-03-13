using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroEndereco
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            cbx_uf.SelectedIndex = 0;
        }

        public void alerta (string mensagem = "")
        {
            MessageBox.Show(mensagem, "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void erro (string mensagem = "")
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void sucesso (string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ckb_semnumero_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_semnumero.Checked == true)
            {
                txt_numero.Enabled = false;
            }
            else
            {
                txt_numero.Enabled = true;
            }
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_nomecompleto.Text))
            {
                erro("Campo Nome vazio");
                return;
            }
            
            if (string.IsNullOrEmpty(mtb_cep.Text))
            {
                erro("Campo CEP Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txt_logradouro.Text))
            {
                erro("Campo Logradouro Vazio");
                txt_logradouro.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_numero.Text) && chk_semnumero.Checked == false)
            {
                erro("Campo Numero Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txt_bairro.Text))
            {
                erro("Campo Bairro Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txt_cidade.Text))
            {
                erro("Campo Cidade Vazio");
                return;
            }
            if (string.IsNullOrEmpty(cbx_uf.SelectedItem?.ToString()))
            {
                erro("Campo Estado Vazio");
                return;
            }
            
            Endereco end = new Endereco();
            end.nome = txt_nomecompleto.Text;
            end.Cep = mtb_cep.Text;
            end.logadouro = txt_logradouro.Text;
            end.numero = chk_semnumero.Checked ? "S/N": txt_numero.Text;
            end.complemento = txt_complemento.Text;
            end.bairro = txt_bairro.Text;
            end.cidade = txt_cidade.Text;
            end.uf = cbx_uf.SelectedItem?.ToString();
            end.semnumero = chk_semnumero.Checked;

            string mensagem = @$"
            Nome: {end.nome}
            Logradouro: {end.logadouro}
            Número: {end.numero}
            Bairro: {end.bairro}
            Cidade: {end.cidade}
            Estado: {end.uf}
            CEP: {end.Cep}
            Complemento: {end.complemento}";

            sucesso(mensagem);

        }
    }
}
