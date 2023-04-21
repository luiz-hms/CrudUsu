
namespace CrudUsu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNovoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTÃODECLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTÃODEUSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblNomeUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAcesso);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(161, 12);
            this.lblNomeUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(16, 13);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Location = new System.Drawing.Point(82, 12);
            this.lblAcesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(13, 13);
            this.lblAcesso.TabIndex = 1;
            this.lblAcesso.Text = "0";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(40, 12);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Acesso:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.uSUÁRIOSToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNovoCliente,
            this.gESTÃODECLIENTESToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // tsmiNovoCliente
            // 
            this.tsmiNovoCliente.Name = "tsmiNovoCliente";
            this.tsmiNovoCliente.Size = new System.Drawing.Size(186, 22);
            this.tsmiNovoCliente.Text = "NOVO CLIENTE";
            this.tsmiNovoCliente.Click += new System.EventHandler(this.NovoClienteToolStripMenuItem_Click);
            // 
            // gESTÃODECLIENTESToolStripMenuItem
            // 
            this.gESTÃODECLIENTESToolStripMenuItem.Name = "gESTÃODECLIENTESToolStripMenuItem";
            this.gESTÃODECLIENTESToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gESTÃODECLIENTESToolStripMenuItem.Text = "GESTÃO DE CLIENTES";
            this.gESTÃODECLIENTESToolStripMenuItem.Click += new System.EventHandler(this.GestaoClientesToolStripMenuItem_Click);
            // 
            // uSUÁRIOSToolStripMenuItem
            // 
            this.uSUÁRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOUSUÁRIOToolStripMenuItem,
            this.gESTÃODEUSUÁRIOSToolStripMenuItem});
            this.uSUÁRIOSToolStripMenuItem.Name = "uSUÁRIOSToolStripMenuItem";
            this.uSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUÁRIOSToolStripMenuItem.Text = "USUÁRIOS";
            // 
            // nOVOUSUÁRIOToolStripMenuItem
            // 
            this.nOVOUSUÁRIOToolStripMenuItem.Name = "nOVOUSUÁRIOToolStripMenuItem";
            this.nOVOUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nOVOUSUÁRIOToolStripMenuItem.Text = "NOVO USUÁRIO";
            this.nOVOUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.NovoUsuarioToolStripMenuItem_Click);
            // 
            // gESTÃODEUSUÁRIOSToolStripMenuItem
            // 
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Name = "gESTÃODEUSUÁRIOSToolStripMenuItem";
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Text = "GESTÃO DE USUÁRIOS";
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Click += new System.EventHandler(this.GestaoUsuariosToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGONToolStripMenuItem,
            this.lOGOFFToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // lOGONToolStripMenuItem
            // 
            this.lOGONToolStripMenuItem.Name = "lOGONToolStripMenuItem";
            this.lOGONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lOGONToolStripMenuItem.Text = "LOGON";
            this.lOGONToolStripMenuItem.Click += new System.EventHandler(this.LogonToolStripMenuItem_Click);
            // 
            // lOGOFFToolStripMenuItem
            // 
            this.lOGOFFToolStripMenuItem.Name = "lOGOFFToolStripMenuItem";
            this.lOGOFFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lOGOFFToolStripMenuItem.Text = "LOGOFF";
            this.lOGOFFToolStripMenuItem.Click += new System.EventHandler(this.LogOffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud Usu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblAcesso;
        public System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNovoCliente;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTÃODEUSUÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTÃODECLIENTESToolStripMenuItem;
    }
}

