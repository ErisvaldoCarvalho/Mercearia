namespace UIWinFormsApp
{
    partial class FormMCadastroUsuario
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.Usuario);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(655, 46);
            this.labelTitulo.Text = "Cadastro de usuário";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(568, 303);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(487, 303);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 64);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(428, 23);
            this.textBoxNome.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome de usuário";
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "NomeUsuario", true));
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(446, 64);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(197, 23);
            this.textBoxNomeUsuario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(12, 108);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(181, 23);
            this.textBoxSenha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmação de senha";
            // 
            // textBoxConfirmacaoSenha
            // 
            this.textBoxConfirmacaoSenha.Location = new System.Drawing.Point(199, 108);
            this.textBoxConfirmacaoSenha.Name = "textBoxConfirmacaoSenha";
            this.textBoxConfirmacaoSenha.Size = new System.Drawing.Size(181, 23);
            this.textBoxConfirmacaoSenha.TabIndex = 8;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCadastro, "Ativo", true));
            this.checkBoxAtivo.Location = new System.Drawing.Point(386, 110);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(54, 19);
            this.checkBoxAtivo.TabIndex = 9;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // FormMCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 338);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.textBoxConfirmacaoSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "FormMCadastroUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMCadastroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FormMCadastroUsuario_Load);
            this.Controls.SetChildIndex(this.buttonSalvar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxNome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxNomeUsuario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxSenha, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxConfirmacaoSenha, 0);
            this.Controls.SetChildIndex(this.checkBoxAtivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxNomeUsuario;
        private Label label3;
        private TextBox textBoxSenha;
        private Label label4;
        private TextBox textBoxConfirmacaoSenha;
        private CheckBox checkBoxAtivo;
    }
}