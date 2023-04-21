
namespace CrudUsu.Interfaces
{
    partial class FormGestaoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUsuarioStatusCadastro = new System.Windows.Forms.ComboBox();
            this.nmudNivelUsuarioCadastro = new System.Windows.Forms.NumericUpDown();
            this.txtLoginUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecharJanela = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnSalvarAlteracoes = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNivelUsuarioCadastro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status";
            // 
            // cmbUsuarioStatusCadastro
            // 
            this.cmbUsuarioStatusCadastro.FormattingEnabled = true;
            this.cmbUsuarioStatusCadastro.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cmbUsuarioStatusCadastro.Location = new System.Drawing.Point(9, 182);
            this.cmbUsuarioStatusCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsuarioStatusCadastro.Name = "cmbUsuarioStatusCadastro";
            this.cmbUsuarioStatusCadastro.Size = new System.Drawing.Size(80, 21);
            this.cmbUsuarioStatusCadastro.TabIndex = 18;
            // 
            // nmudNivelUsuarioCadastro
            // 
            this.nmudNivelUsuarioCadastro.Location = new System.Drawing.Point(110, 182);
            this.nmudNivelUsuarioCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.nmudNivelUsuarioCadastro.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmudNivelUsuarioCadastro.Name = "nmudNivelUsuarioCadastro";
            this.nmudNivelUsuarioCadastro.Size = new System.Drawing.Size(82, 20);
            this.nmudNivelUsuarioCadastro.TabIndex = 17;
            // 
            // txtLoginUsuarioCadastro
            // 
            this.txtLoginUsuarioCadastro.Location = new System.Drawing.Point(9, 137);
            this.txtLoginUsuarioCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginUsuarioCadastro.Name = "txtLoginUsuarioCadastro";
            this.txtLoginUsuarioCadastro.Size = new System.Drawing.Size(80, 20);
            this.txtLoginUsuarioCadastro.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login";
            // 
            // txtSenhaUsuarioCadastro
            // 
            this.txtSenhaUsuarioCadastro.Location = new System.Drawing.Point(107, 137);
            this.txtSenhaUsuarioCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaUsuarioCadastro.Name = "txtSenhaUsuarioCadastro";
            this.txtSenhaUsuarioCadastro.Size = new System.Drawing.Size(85, 20);
            this.txtSenhaUsuarioCadastro.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha";
            // 
            // txtNomeUsuarioCadastro
            // 
            this.txtNomeUsuarioCadastro.Location = new System.Drawing.Point(9, 84);
            this.txtNomeUsuarioCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeUsuarioCadastro.Name = "txtNomeUsuarioCadastro";
            this.txtNomeUsuarioCadastro.Size = new System.Drawing.Size(198, 20);
            this.txtNomeUsuarioCadastro.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(9, 27);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(95, 20);
            this.txtId.TabIndex = 22;
            this.txtId.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFecharJanela);
            this.panel1.Controls.Add(this.btnExcluirUsuario);
            this.panel1.Controls.Add(this.btnSalvarAlteracoes);
            this.panel1.Controls.Add(this.btnNovoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 39);
            this.panel1.TabIndex = 23;
            // 
            // btnFecharJanela
            // 
            this.btnFecharJanela.Location = new System.Drawing.Point(425, 4);
            this.btnFecharJanela.Margin = new System.Windows.Forms.Padding(2);
            this.btnFecharJanela.Name = "btnFecharJanela";
            this.btnFecharJanela.Size = new System.Drawing.Size(100, 32);
            this.btnFecharJanela.TabIndex = 28;
            this.btnFecharJanela.Text = "Fechar Janela";
            this.btnFecharJanela.UseVisualStyleBackColor = true;
            this.btnFecharJanela.Click += new System.EventHandler(this.btnFecharJanela_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(220, 4);
            this.btnExcluirUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(100, 32);
            this.btnExcluirUsuario.TabIndex = 27;
            this.btnExcluirUsuario.Text = "Excluir Usuário";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.Location = new System.Drawing.Point(115, 4);
            this.btnSalvarAlteracoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.Size = new System.Drawing.Size(100, 32);
            this.btnSalvarAlteracoes.TabIndex = 26;
            this.btnSalvarAlteracoes.Text = "Salvar Alterações";
            this.btnSalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoes.Click += new System.EventHandler(this.btnSalvarAlteracoes_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(10, 4);
            this.btnNovoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(100, 32);
            this.btnNovoUsuario.TabIndex = 25;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(220, 27);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(306, 258);
            this.dgvUsuarios.TabIndex = 24;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // FormGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 352);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuários";
            this.Load += new System.EventHandler(this.FormGestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmudNivelUsuarioCadastro)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUsuarioStatusCadastro;
        private System.Windows.Forms.NumericUpDown nmudNivelUsuarioCadastro;
        private System.Windows.Forms.TextBox txtLoginUsuarioCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaUsuarioCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUsuarioCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFecharJanela;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnSalvarAlteracoes;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}