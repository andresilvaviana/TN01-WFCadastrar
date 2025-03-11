namespace TN01_WFCadastrar
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
            lbl_telefone = new Label();
            mkd_telefone = new MaskedTextBox();
            lbl_datadenascimento = new Label();
            dtp_datanascimento = new DateTimePicker();
            lbl_escolaridade = new Label();
            cbx_escolaridade = new ComboBox();
            gbx_sexo = new GroupBox();
            rdb_naoinformado = new RadioButton();
            rdb_feminino = new RadioButton();
            rdb_masculino = new RadioButton();
            lbl_rendamensal = new Label();
            nup_rendamensal = new NumericUpDown();
            chk_possuifilhos = new CheckBox();
            btn_salvar = new Button();
            gbx_sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_rendamensal).BeginInit();
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
            txt_nomecompleto.Size = new Size(354, 23);
            txt_nomecompleto.TabIndex = 1;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(23, 113);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(51, 15);
            lbl_telefone.TabIndex = 2;
            lbl_telefone.Text = "Telefone";
            // 
            // mkd_telefone
            // 
            mkd_telefone.ImeMode = ImeMode.On;
            mkd_telefone.Location = new Point(23, 131);
            mkd_telefone.Mask = "(00) 90000-0000";
            mkd_telefone.Name = "mkd_telefone";
            mkd_telefone.Size = new Size(208, 23);
            mkd_telefone.TabIndex = 2;
            // 
            // lbl_datadenascimento
            // 
            lbl_datadenascimento.AutoSize = true;
            lbl_datadenascimento.Location = new Point(245, 113);
            lbl_datadenascimento.Name = "lbl_datadenascimento";
            lbl_datadenascimento.Size = new Size(114, 15);
            lbl_datadenascimento.TabIndex = 4;
            lbl_datadenascimento.Text = "Data de Nascimento";
            // 
            // dtp_datanascimento
            // 
            dtp_datanascimento.Format = DateTimePickerFormat.Short;
            dtp_datanascimento.Location = new Point(245, 131);
            dtp_datanascimento.Name = "dtp_datanascimento";
            dtp_datanascimento.Size = new Size(132, 23);
            dtp_datanascimento.TabIndex = 3;
            dtp_datanascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lbl_escolaridade
            // 
            lbl_escolaridade.AutoSize = true;
            lbl_escolaridade.Location = new Point(23, 204);
            lbl_escolaridade.Name = "lbl_escolaridade";
            lbl_escolaridade.Size = new Size(73, 15);
            lbl_escolaridade.TabIndex = 7;
            lbl_escolaridade.Text = "Escolaridade";
            // 
            // cbx_escolaridade
            // 
            cbx_escolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_escolaridade.FormattingEnabled = true;
            cbx_escolaridade.Items.AddRange(new object[] { "Analfabeto", "Ensino Fundamento Incompleto", "Ensino Fundamento Completo", "Ensino Medio Incompleto", "Ensino Medio Completo", "Ensino Tecnico Incompleto", "Ensino Tecnico Completp", "Ensino Superio Incompleto", "Ensino Superio Completo", "Pós-Graduação Incompleto", "Pós-Graduação Completo" });
            cbx_escolaridade.Location = new Point(23, 222);
            cbx_escolaridade.Name = "cbx_escolaridade";
            cbx_escolaridade.Size = new Size(208, 23);
            cbx_escolaridade.TabIndex = 4;
            // 
            // gbx_sexo
            // 
            gbx_sexo.Controls.Add(rdb_naoinformado);
            gbx_sexo.Controls.Add(rdb_feminino);
            gbx_sexo.Controls.Add(rdb_masculino);
            gbx_sexo.Location = new Point(23, 285);
            gbx_sexo.Name = "gbx_sexo";
            gbx_sexo.Size = new Size(208, 100);
            gbx_sexo.TabIndex = 5;
            gbx_sexo.TabStop = false;
            gbx_sexo.Text = "Sexo";
            // 
            // rdb_naoinformado
            // 
            rdb_naoinformado.AutoSize = true;
            rdb_naoinformado.Location = new Point(6, 72);
            rdb_naoinformado.Name = "rdb_naoinformado";
            rdb_naoinformado.Size = new Size(128, 19);
            rdb_naoinformado.TabIndex = 2;
            rdb_naoinformado.TabStop = true;
            rdb_naoinformado.Text = "Prefiro não Informa";
            rdb_naoinformado.UseVisualStyleBackColor = true;
            // 
            // rdb_feminino
            // 
            rdb_feminino.AutoSize = true;
            rdb_feminino.Location = new Point(6, 47);
            rdb_feminino.Name = "rdb_feminino";
            rdb_feminino.Size = new Size(75, 19);
            rdb_feminino.TabIndex = 1;
            rdb_feminino.TabStop = true;
            rdb_feminino.Text = "Feminino";
            rdb_feminino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            rdb_masculino.AutoSize = true;
            rdb_masculino.Location = new Point(6, 22);
            rdb_masculino.Name = "rdb_masculino";
            rdb_masculino.Size = new Size(80, 19);
            rdb_masculino.TabIndex = 0;
            rdb_masculino.TabStop = true;
            rdb_masculino.Text = "Masculino";
            rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // lbl_rendamensal
            // 
            lbl_rendamensal.AutoSize = true;
            lbl_rendamensal.Location = new Point(245, 204);
            lbl_rendamensal.Name = "lbl_rendamensal";
            lbl_rendamensal.Size = new Size(81, 15);
            lbl_rendamensal.TabIndex = 10;
            lbl_rendamensal.Text = "Renda Mensal";
            // 
            // nup_rendamensal
            // 
            nup_rendamensal.DecimalPlaces = 2;
            nup_rendamensal.Location = new Point(245, 222);
            nup_rendamensal.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nup_rendamensal.Name = "nup_rendamensal";
            nup_rendamensal.Size = new Size(132, 23);
            nup_rendamensal.TabIndex = 6;
            // 
            // chk_possuifilhos
            // 
            chk_possuifilhos.AutoSize = true;
            chk_possuifilhos.Checked = true;
            chk_possuifilhos.CheckState = CheckState.Indeterminate;
            chk_possuifilhos.Location = new Point(257, 285);
            chk_possuifilhos.Name = "chk_possuifilhos";
            chk_possuifilhos.Size = new Size(99, 19);
            chk_possuifilhos.TabIndex = 7;
            chk_possuifilhos.Text = "Possui Filhos?";
            chk_possuifilhos.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.Location = new Point(257, 334);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(120, 42);
            btn_salvar.TabIndex = 6;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleRight;
            btn_salvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += button1_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 404);
            Controls.Add(btn_salvar);
            Controls.Add(chk_possuifilhos);
            Controls.Add(nup_rendamensal);
            Controls.Add(lbl_rendamensal);
            Controls.Add(gbx_sexo);
            Controls.Add(cbx_escolaridade);
            Controls.Add(lbl_escolaridade);
            Controls.Add(dtp_datanascimento);
            Controls.Add(lbl_datadenascimento);
            Controls.Add(mkd_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(txt_nomecompleto);
            Controls.Add(lbl_nomecompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            gbx_sexo.ResumeLayout(false);
            gbx_sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_rendamensal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nomecompleto;
        private TextBox txt_nomecompleto;
        private Label lbl_telefone;
        private MaskedTextBox mkd_telefone;
        private Label lbl_datadenascimento;
        private DateTimePicker dtp_datanascimento;
        private Label lbl_escolaridade;
        private ComboBox cbx_escolaridade;
        private GroupBox gbx_sexo;
        private RadioButton rdb_naoinformado;
        private RadioButton rdb_feminino;
        private RadioButton rdb_masculino;
        private Label lbl_rendamensal;
        private NumericUpDown nup_rendamensal;
        private CheckBox chk_possuifilhos;
        private Button btn_salvar;
    }
}