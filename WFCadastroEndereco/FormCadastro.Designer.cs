namespace WFCadastroEndereco
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lbl_nomecompleto = new Label();
            txt_nomecompleto = new TextBox();
            lbl_cep = new Label();
            label3 = new Label();
            mtb_cep = new MaskedTextBox();
            label1 = new Label();
            lbl_logradouro = new Label();
            txt_logradouro = new TextBox();
            txt_numero = new TextBox();
            lbl_numero = new Label();
            txt_complemento = new TextBox();
            lbl_complemento = new Label();
            lbl_bairro = new Label();
            txt_bairro = new TextBox();
            lbl_cidade = new Label();
            txt_cidade = new TextBox();
            cbx_uf = new ComboBox();
            lbl_uf = new Label();
            chk_semnumero = new CheckBox();
            btn_salva = new Button();
            SuspendLayout();
            // 
            // lbl_nomecompleto
            // 
            lbl_nomecompleto.AutoSize = true;
            lbl_nomecompleto.Location = new Point(23, 33);
            lbl_nomecompleto.Name = "lbl_nomecompleto";
            lbl_nomecompleto.Size = new Size(96, 15);
            lbl_nomecompleto.TabIndex = 0;
            lbl_nomecompleto.Text = "Nome Completo";
            // 
            // txt_nomecompleto
            // 
            txt_nomecompleto.Location = new Point(23, 51);
            txt_nomecompleto.Name = "txt_nomecompleto";
            txt_nomecompleto.Size = new Size(357, 23);
            txt_nomecompleto.TabIndex = 1;
            // 
            // lbl_cep
            // 
            lbl_cep.AutoSize = true;
            lbl_cep.Location = new Point(23, 94);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(28, 15);
            lbl_cep.TabIndex = 2;
            lbl_cep.Text = "CEP";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(23, 9);
            label3.Name = "label3";
            label3.Size = new Size(354, 1);
            label3.TabIndex = 5;
            // 
            // mtb_cep
            // 
            mtb_cep.Location = new Point(23, 112);
            mtb_cep.Mask = "00000-999";
            mtb_cep.Name = "mtb_cep";
            mtb_cep.Size = new Size(96, 23);
            mtb_cep.TabIndex = 2;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(23, 394);
            label1.Name = "label1";
            label1.Size = new Size(354, 1);
            label1.TabIndex = 7;
            // 
            // lbl_logradouro
            // 
            lbl_logradouro.AutoSize = true;
            lbl_logradouro.Location = new Point(23, 154);
            lbl_logradouro.Name = "lbl_logradouro";
            lbl_logradouro.Size = new Size(69, 15);
            lbl_logradouro.TabIndex = 8;
            lbl_logradouro.Text = "Logradouro";
            // 
            // txt_logradouro
            // 
            txt_logradouro.Location = new Point(23, 172);
            txt_logradouro.Name = "txt_logradouro";
            txt_logradouro.Size = new Size(155, 23);
            txt_logradouro.TabIndex = 3;
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(184, 172);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(94, 23);
            txt_numero.TabIndex = 4;
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(184, 154);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(51, 15);
            lbl_numero.TabIndex = 11;
            lbl_numero.Text = "Número";
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(23, 289);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(184, 23);
            txt_complemento.TabIndex = 8;
            // 
            // lbl_complemento
            // 
            lbl_complemento.AutoSize = true;
            lbl_complemento.Location = new Point(23, 271);
            lbl_complemento.Name = "lbl_complemento";
            lbl_complemento.Size = new Size(84, 15);
            lbl_complemento.TabIndex = 13;
            lbl_complemento.Text = "Complemento";
            // 
            // lbl_bairro
            // 
            lbl_bairro.AutoSize = true;
            lbl_bairro.Location = new Point(215, 215);
            lbl_bairro.Name = "lbl_bairro";
            lbl_bairro.Size = new Size(38, 15);
            lbl_bairro.TabIndex = 15;
            lbl_bairro.Text = "Bairro";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(215, 233);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(165, 23);
            txt_bairro.TabIndex = 7;
            // 
            // lbl_cidade
            // 
            lbl_cidade.AutoSize = true;
            lbl_cidade.Location = new Point(23, 215);
            lbl_cidade.Name = "lbl_cidade";
            lbl_cidade.Size = new Size(44, 15);
            lbl_cidade.TabIndex = 17;
            lbl_cidade.Text = "Cidade";
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(23, 233);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(184, 23);
            txt_cidade.TabIndex = 6;
            // 
            // cbx_uf
            // 
            cbx_uf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_uf.FormattingEnabled = true;
            cbx_uf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbx_uf.Location = new Point(217, 289);
            cbx_uf.Name = "cbx_uf";
            cbx_uf.Size = new Size(163, 23);
            cbx_uf.TabIndex = 9;
            // 
            // lbl_uf
            // 
            lbl_uf.AutoSize = true;
            lbl_uf.Location = new Point(217, 271);
            lbl_uf.Name = "lbl_uf";
            lbl_uf.Size = new Size(21, 15);
            lbl_uf.TabIndex = 19;
            lbl_uf.Text = "UF";
            // 
            // chk_semnumero
            // 
            chk_semnumero.AutoSize = true;
            chk_semnumero.Location = new Point(284, 172);
            chk_semnumero.Name = "chk_semnumero";
            chk_semnumero.Size = new Size(96, 19);
            chk_semnumero.TabIndex = 5;
            chk_semnumero.Text = "Sem Número";
            chk_semnumero.UseVisualStyleBackColor = true;
            chk_semnumero.CheckedChanged += ckb_semnumero_CheckedChanged;
            // 
            // btn_salva
            // 
            btn_salva.Location = new Point(23, 350);
            btn_salva.Name = "btn_salva";
            btn_salva.Size = new Size(354, 35);
            btn_salva.TabIndex = 10;
            btn_salva.Text = "Salva";
            btn_salva.UseVisualStyleBackColor = true;
            btn_salva.Click += btn_salva_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 416);
            Controls.Add(btn_salva);
            Controls.Add(chk_semnumero);
            Controls.Add(lbl_uf);
            Controls.Add(cbx_uf);
            Controls.Add(lbl_cidade);
            Controls.Add(txt_cidade);
            Controls.Add(lbl_bairro);
            Controls.Add(txt_bairro);
            Controls.Add(lbl_complemento);
            Controls.Add(txt_complemento);
            Controls.Add(lbl_numero);
            Controls.Add(txt_numero);
            Controls.Add(txt_logradouro);
            Controls.Add(lbl_logradouro);
            Controls.Add(label1);
            Controls.Add(mtb_cep);
            Controls.Add(label3);
            Controls.Add(lbl_cep);
            Controls.Add(txt_nomecompleto);
            Controls.Add(lbl_nomecompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nomecompleto;
        private TextBox txt_nomecompleto;
        private Label lbl_cep;
        private Label label3;
        private MaskedTextBox mtb_cep;
        private Label label1;
        private Label lbl_logradouro;
        private TextBox txt_logradouro;
        private TextBox txt_numero;
        private Label lbl_numero;
        private TextBox txt_complemento;
        private Label lbl_complemento;
        private Label lbl_bairro;
        private TextBox txt_bairro;
        private Label lbl_cidade;
        private TextBox txt_cidade;
        private ComboBox cbx_uf;
        private Label lbl_uf;
        private CheckBox chk_semnumero;
        private Button btn_salva;
    }
}