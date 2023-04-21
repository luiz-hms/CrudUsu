
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
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUTENÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bANCODEDADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTÃODEUSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(215, 15);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(23, 17);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Location = new System.Drawing.Point(109, 15);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(16, 17);
            this.lblAcesso.TabIndex = 1;
            this.lblAcesso.Text = "0";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(54, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(58, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Acesso:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.uSUÁRIOSToolStripMenuItem,
            this.mANUTENÇÃOToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGONToolStripMenuItem,
            this.lOGOFFToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // lOGONToolStripMenuItem
            // 
            this.lOGONToolStripMenuItem.Name = "lOGONToolStripMenuItem";
            this.lOGONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lOGONToolStripMenuItem.Text = "LOGON";
            this.lOGONToolStripMenuItem.Click += new System.EventHandler(this.lOGONToolStripMenuItem_Click);
            // 
            // lOGOFFToolStripMenuItem
            // 
            this.lOGOFFToolStripMenuItem.Name = "lOGOFFToolStripMenuItem";
            this.lOGOFFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lOGOFFToolStripMenuItem.Text = "LOGOFF";
            this.lOGOFFToolStripMenuItem.Click += new System.EventHandler(this.lOGOFFToolStripMenuItem_Click);
            // 
            // mANUTENÇÃOToolStripMenuItem
            // 
            this.mANUTENÇÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bANCODEDADOSToolStripMenuItem});
            this.mANUTENÇÃOToolStripMenuItem.Name = "mANUTENÇÃOToolStripMenuItem";
            this.mANUTENÇÃOToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mANUTENÇÃOToolStripMenuItem.Text = "MANUTENÇÃO";
            // 
            // bANCODEDADOSToolStripMenuItem
            // 
            this.bANCODEDADOSToolStripMenuItem.Name = "bANCODEDADOSToolStripMenuItem";
            this.bANCODEDADOSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bANCODEDADOSToolStripMenuItem.Text = "BANCO DE DADOS";
            this.bANCODEDADOSToolStripMenuItem.Click += new System.EventHandler(this.BANCODEDADOSToolStripMenuItem_Click);
            // 
            // uSUÁRIOSToolStripMenuItem
            // 
            this.uSUÁRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOUSUÁRIOToolStripMenuItem,
            this.gESTÃODEUSUÁRIOSToolStripMenuItem});
            this.uSUÁRIOSToolStripMenuItem.Name = "uSUÁRIOSToolStripMenuItem";
            this.uSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.uSUÁRIOSToolStripMenuItem.Text = "USUÁRIOS";
            // 
            // gESTÃODEUSUÁRIOSToolStripMenuItem
            // 
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Name = "gESTÃODEUSUÁRIOSToolStripMenuItem";
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Text = "GESTÃO DE USUÁRIOS";
            this.gESTÃODEUSUÁRIOSToolStripMenuItem.Click += new System.EventHandler(this.gESTÃODEUSUÁRIOSToolStripMenuItem_Click);
            // 
            // nOVOUSUÁRIOToolStripMenuItem
            // 
            this.nOVOUSUÁRIOToolStripMenuItem.Name = "nOVOUSUÁRIOToolStripMenuItem";
            this.nOVOUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.nOVOUSUÁRIOToolStripMenuItem.Text = "NOVO USUÁRIO";
            this.nOVOUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.nOVOUSUÁRIOToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOCLIENTEToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // nOVOCLIENTEToolStripMenuItem
            // 
            this.nOVOCLIENTEToolStripMenuItem.Name = "nOVOCLIENTEToolStripMenuItem";
            this.nOVOCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nOVOCLIENTEToolStripMenuItem.Text = "NOVO CLIENTE";
            this.nOVOCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.nOVOCLIENTEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem nOVOCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTÃODEUSUÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANUTENÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bANCODEDADOSToolStripMenuItem;
    }
}

