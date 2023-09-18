namespace UIWinFormsApp
{
    partial class FormGestaoGrupoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePermissao = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRemoverPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.textBoxFiltrarGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePermissao)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.GrupoUsuario);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(902, 46);
            this.labelTitulo.Text = "Gestão de grupos de usuários";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(815, 354);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(734, 354);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceCadastro;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(437, 255);
            this.dataGridView1.TabIndex = 7;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Grupo de usuário";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bindingSourcePermissao;
            this.dataGridView2.Location = new System.Drawing.Point(455, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(437, 255);
            this.dataGridView2.TabIndex = 7;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Permições do grupo";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bindingSourcePermissao
            // 
            this.bindingSourcePermissao.DataMember = "PermissaoListMyProperty";
            this.bindingSourcePermissao.DataSource = this.bindingSourceCadastro;
            // 
            // buttonRemoverPermissao
            // 
            this.buttonRemoverPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoverPermissao.Location = new System.Drawing.Point(815, 64);
            this.buttonRemoverPermissao.Name = "buttonRemoverPermissao";
            this.buttonRemoverPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverPermissao.TabIndex = 8;
            this.buttonRemoverPermissao.Text = "Remover";
            this.buttonRemoverPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(734, 64);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 9;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltrarGrupo
            // 
            this.textBoxFiltrarGrupo.Location = new System.Drawing.Point(12, 64);
            this.textBoxFiltrarGrupo.Name = "textBoxFiltrarGrupo";
            this.textBoxFiltrarGrupo.Size = new System.Drawing.Size(242, 23);
            this.textBoxFiltrarGrupo.TabIndex = 10;
            this.textBoxFiltrarGrupo.TextChanged += new System.EventHandler(this.textBoxFiltrarGrupo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtrar grupo";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(260, 64);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(59, 23);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(325, 64);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(59, 23);
            this.buttonAlterar.TabIndex = 9;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(390, 64);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(59, 23);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // FormGestaoGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltrarGrupo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonRemoverPermissao);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestaoGrupoUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestaoGrupoUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FormGestaoGrupoUsuario_Load);
            this.Controls.SetChildIndex(this.buttonSalvar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.buttonRemoverPermissao, 0);
            this.Controls.SetChildIndex(this.buttonAdicionarPermissao, 0);
            this.Controls.SetChildIndex(this.buttonInserir, 0);
            this.Controls.SetChildIndex(this.buttonAlterar, 0);
            this.Controls.SetChildIndex(this.buttonExcluir, 0);
            this.Controls.SetChildIndex(this.textBoxFiltrarGrupo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePermissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridView dataGridView2;
        private BindingSource bindingSourcePermissao;
        private Button buttonRemoverPermissao;
        private Button buttonAdicionarPermissao;
        private TextBox textBoxFiltrarGrupo;
        private Label label1;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonExcluir;
    }
}