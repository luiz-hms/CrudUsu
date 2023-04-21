
namespace CrudUsu.Interfaces
{
    partial class FormNovoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmudNivelUsuarioCadastro = new System.Windows.Forms.NumericUpDown();
            this.cmbUsuarioStatusCadastro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.btnCancelarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnFecharCadastroUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNivelUsuarioCadastro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeUsuarioCadastro
            // 
            this.txtNomeUsuarioCadastro.Location = new System.Drawing.Point(12, 33);
            this.txtNomeUsuarioCadastro.Name = "txtNomeUsuarioCadastro";
            this.txtNomeUsuarioCadastro.Size = new System.Drawing.Size(263, 22);
            this.txtNomeUsuarioCadastro.TabIndex = 1;
            // 
            // txtSenhaUsuarioCadastro
            // 
            this.txtSenhaUsuarioCadastro.Location = new System.Drawing.Point(525, 33);
            this.txtSenhaUsuarioCadastro.Name = "txtSenhaUsuarioCadastro";
            this.txtSenhaUsuarioCadastro.Size = new System.Drawing.Size(198, 22);
            this.txtSenhaUsuarioCadastro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txtLoginUsuarioCadastro
            // 
            this.txtLoginUsuarioCadastro.Location = new System.Drawing.Point(300, 33);
            this.txtLoginUsuarioCadastro.Name = "txtLoginUsuarioCadastro";
            this.txtLoginUsuarioCadastro.Size = new System.Drawing.Size(198, 22);
            this.txtLoginUsuarioCadastro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // nmudNivelUsuarioCadastro
            // 
            this.nmudNivelUsuarioCadastro.Location = new System.Drawing.Point(155, 83);
            this.nmudNivelUsuarioCadastro.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmudNivelUsuarioCadastro.Name = "nmudNivelUsuarioCadastro";
            this.nmudNivelUsuarioCadastro.Size = new System.Drawing.Size(120, 22);
            this.nmudNivelUsuarioCadastro.TabIndex = 6;
            // 
            // cmbUsuarioStatusCadastro
            // 
            this.cmbUsuarioStatusCadastro.FormattingEnabled = true;
            this.cmbUsuarioStatusCadastro.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cmbUsuarioStatusCadastro.Location = new System.Drawing.Point(12, 83);
            this.cmbUsuarioStatusCadastro.Name = "cmbUsuarioStatusCadastro";
            this.cmbUsuarioStatusCadastro.Size = new System.Drawing.Size(121, 24);
            this.cmbUsuarioStatusCadastro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nivel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFecharCadastroUsuario);
            this.panel1.Controls.Add(this.btnSalvarUsuario);
            this.panel1.Controls.Add(this.btnCancelarCadastroUsuario);
            this.panel1.Controls.Add(this.btnNovoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 48);
            this.panel1.TabIndex = 11;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUsuario.Location = new System.Drawing.Point(6, 5);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(75, 42);
            this.btnNovoUsuario.TabIndex = 12;
            this.btnNovoUsuario.Text = "Novo";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarUsuario.Location = new System.Drawing.Point(98, 5);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(75, 42);
            this.btnSalvarUsuario.TabIndex = 13;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // btnCancelarCadastroUsuario
            // 
            this.btnCancelarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCadastroUsuario.Location = new System.Drawing.Point(184, 5);
            this.btnCancelarCadastroUsuario.Name = "btnCancelarCadastroUsuario";
            this.btnCancelarCadastroUsuario.Size = new System.Drawing.Size(101, 42);
            this.btnCancelarCadastroUsuario.TabIndex = 14;
            this.btnCancelarCadastroUsuario.Text = "Cancelar";
            this.btnCancelarCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroUsuario.Click += new System.EventHandler(this.btnCancelarCadastroUsuario_Click);
            // 
            // btnFecharCadastroUsuario
            // 
            this.btnFecharCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharCadastroUsuario.Location = new System.Drawing.Point(655, 3);
            this.btnFecharCadastroUsuario.Name = "btnFecharCadastroUsuario";
            this.btnFecharCadastroUsuario.Size = new System.Drawing.Size(75, 42);
            this.btnFecharCadastroUsuario.TabIndex = 15;
            this.btnFecharCadastroUsuario.Text = "Fechar";
            this.btnFecharCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnFecharCadastroUsuario.Click += new System.EventHandler(this.btnFecharCadastroUsuario_Click);
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUsuarioStatusCadastro);
            this.Controls.Add(this.nmudNivelUsuarioCadastro);
            this.Controls.Add(this.txtLoginUsuarioCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaUsuarioCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeUsuarioCadastro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.nmudNivelUsuarioCadastro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUsuarioCadastro;
        private System.Windows.Forms.TextBox txtSenhaUsuarioCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginUsuarioCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmudNivelUsuarioCadastro;
        private System.Windows.Forms.ComboBox cmbUsuarioStatusCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFecharCadastroUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Button btnCancelarCadastroUsuario;
        private System.Windows.Forms.Button btnNovoUsuario;
    }
}