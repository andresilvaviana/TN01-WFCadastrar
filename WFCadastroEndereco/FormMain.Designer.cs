namespace WFCadastroEndereco
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnscadastrar = new ToolStripMenuItem();
            mnssobre = new ToolStripMenuItem();
            mnssair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnscadastrar, mnssobre, mnssair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "MenuStrip1";
            // 
            // mnscadastrar
            // 
            mnscadastrar.Checked = true;
            mnscadastrar.CheckState = CheckState.Checked;
            mnscadastrar.Name = "mnscadastrar";
            mnscadastrar.Size = new Size(65, 20);
            mnscadastrar.Text = "Cadastra";
            mnscadastrar.Click += mnscadastrar_Click;
            // 
            // mnssobre
            // 
            mnssobre.Name = "mnssobre";
            mnssobre.Size = new Size(49, 20);
            mnssobre.Text = "Sobre";
            // 
            // mnssair
            // 
            mnssair.Name = "mnssair";
            mnssair.Size = new Size(38, 20);
            mnssair.Text = "Sair";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 402);
            Controls.Add(menuStrip1);
            Name = "FormMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnscadastrar;
        private ToolStripMenuItem mnssobre;
        private ToolStripMenuItem mnssair;
    }
}
