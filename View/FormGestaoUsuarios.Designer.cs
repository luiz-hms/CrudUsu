
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label5.Location = new System.Drawing.Point(143, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
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
            this.cmbUsuarioStatusCadastro.Location = new System.Drawing.Point(12, 224);
            this.cmbUsuarioStatusCadastro.Name = "cmbUsuarioStatusCadastro";
            this.cmbUsuarioStatusCadastro.Size = new System.Drawing.Size(105, 24);
            this.cmbUsuarioStatusCadastro.TabIndex = 18;
            // 
            // nmudNivelUsuarioCadastro
            // 
            this.nmudNivelUsuarioCadastro.Location = new System.Drawing.Point(146, 224);
            this.nmudNivelUsuarioCadastro.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmudNivelUsuarioCadastro.Name = "nmudNivelUsuarioCadastro";
            this.nmudNivelUsuarioCadastro.Size = new System.Drawing.Size(109, 22);
            this.nmudNivelUsuarioCadastro.TabIndex = 17;
            // 
            // txtLoginUsuarioCadastro
            // 
            this.txtLoginUsuarioCadastro.Location = new System.Drawing.Point(12, 169);
            this.txtLoginUsuarioCadastro.Name = "txtLoginUsuarioCadastro";
            this.txtLoginUsuarioCadastro.Size = new System.Drawing.Size(105, 22);
            this.txtLoginUsuarioCadastro.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login";
            // 
            // txtSenhaUsuarioCadastro
            // 
            this.txtSenhaUsuarioCadastro.Location = new System.Drawing.Point(143, 169);
            this.txtSenhaUsuarioCadastro.Name = "txtSenhaUsuarioCadastro";
            this.txtSenhaUsuarioCadastro.Size = new System.Drawing.Size(112, 22);
            this.txtSenhaUsuarioCadastro.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha";
            // 
            // txtNomeUsuarioCadastro
            // 
            this.txtNomeUsuarioCadastro.Location = new System.Drawing.Point(12, 103);
            this.txtNomeUsuarioCadastro.Name = "txtNomeUsuarioCadastro";
            this.txtNomeUsuarioCadastro.Size = new System.Drawing.Size(263, 22);
            this.txtNomeUsuarioCadastro.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 33);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(125, 22);
            this.txtId.TabIndex = 22;
            this.txtId.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
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
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 48);
            this.panel1.TabIndex = 23;
            // 
            // btnFecharJanela
            // 
            this.btnFecharJanela.Location = new System.Drawing.Point(567, 5);
            this.btnFecharJanela.Name = "btnFecharJanela";
            this.btnFecharJanela.Size = new System.Drawing.Size(134, 40);
            this.btnFecharJanela.TabIndex = 28;
            this.btnFecharJanela.Text = "Fechar Janela";
            this.btnFecharJanela.UseVisualStyleBackColor = true;
            this.btnFecharJanela.Click += new System.EventHandler(this.btnFecharJanela_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(293, 5);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(134, 40);
            this.btnExcluirUsuario.TabIndex = 27;
            this.btnExcluirUsuario.Text = "Excluir Usuário";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.Location = new System.Drawing.Point(153, 5);
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.Size = new System.Drawing.Size(134, 40);
            this.btnSalvarAlteracoes.TabIndex = 26;
            this.btnSalvarAlteracoes.Text = "Salvar Alterações";
            this.btnSalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoes.Click += new System.EventHandler(this.btnSalvarAlteracoes_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(13, 5);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(134, 40);
            this.btnNovoUsuario.TabIndex = 25;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(293, 33);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(408, 317);
            this.dgvUsuarios.TabIndex = 24;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // FormGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 433);
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