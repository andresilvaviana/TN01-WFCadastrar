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
            cbx_escolaridade.SelectedIndex = 0;
        }
        public void LimparFormulario()
        {
            txt_nomecompleto.Clear();
            mkd_telefone.Clear();
            dtp_datanascimento.Value = DateTime.Now;
            cbx_escolaridade.SelectedIndex = 0;
            rdb_feminino.Checked = false;
            rdb_masculino.Checked = false;
            rdb_masculino.Checked = false;
            nup_rendamensal.Value = 0;
            chk_possuifilhos.Checked = false;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoas p1 = new Pessoas();
            p1.nomecompleto = txt_nomecompleto.Text;
            p1.dddtelefone = mkd_telefone.Text;
            p1.datanascimento = dtp_datanascimento.Value;
            p1.escolaridade = cbx_escolaridade.SelectedItem!.ToString();
            p1.rendamensal = Convert.ToDouble(nup_rendamensal.Value);

            if (rdb_masculino.Checked)
            {
                p1.sexo = 'm';
            }
            else if (rdb_feminino.Checked)
            {
                p1.sexo = 'f';
            }
            else if (rdb_naoinformado.Checked)
            {
                p1.sexo = 'n';
            }
            else
            {
                MessageBox.Show("Sexo não definido!");
                return;
            }

            if (chk_possuifilhos.CheckState == CheckState.Checked)
            {
                p1.possuifilhos = true;
            }
            else if (chk_possuifilhos.CheckState == CheckState.Unchecked)
            {
                p1.possuifilhos = false;
            }
            else

            {
                MessageBox.Show("Filhos não informado!");
                return;
            }

            Pessoas.listaPessoas.Add(p1);

            MessageBox.Show("Cadastro realizado com Sucesso!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
