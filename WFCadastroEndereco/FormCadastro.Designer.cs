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
            msk_cep = new MaskedTextBox();
            label1 = new Label();
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
            // lbl_cep
            // 
            lbl_cep.AutoSize = true;
            lbl_cep.Location = new Point(26, 187);
            lbl_cep.Name = "lbl_cep";
            lbl_cep.Size = new Size(28, 15);
            lbl_cep.TabIndex = 2;
            lbl_cep.Text = "CEP";
            lbl_cep.Click += label1_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(23, 77);
            label3.Name = "label3";
            label3.Size = new Size(354, 1);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // msk_cep
            // 
            msk_cep.Location = new Point(26, 205);
            msk_cep.Mask = "00000-999";
            msk_cep.Name = "msk_cep";
            msk_cep.Size = new Size(74, 23);
            msk_cep.TabIndex = 6;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(26, 231);
            label1.Name = "label1";
            label1.Size = new Size(354, 1);
            label1.TabIndex = 7;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 404);
            Controls.Add(label1);
            Controls.Add(msk_cep);
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
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nomecompleto;
        private TextBox txt_nomecompleto;
        private Label lbl_cep;
        private Label label3;
        private MaskedTextBox msk_cep;
        private Label label1;
    }
}