namespace Setor
{
    partial class Setor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setor));
            dataGrind = new DataGridView();
            lblNomeSetor = new Label();
            lblid = new Label();
            txtNomeSetor = new TextBox();
            btnGravar = new Button();
            lblNome = new Label();
            txtID = new TextBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListarTodos = new Button();
            btnListarPnome = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrind).BeginInit();
            SuspendLayout();
            // 
            // dataGrind
            // 
            dataGrind.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrind.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrind.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrind.Location = new Point(25, 279);
            dataGrind.Name = "dataGrind";
            dataGrind.RowHeadersVisible = false;
            dataGrind.RowHeadersWidth = 62;
            dataGrind.Size = new Size(833, 254);
            dataGrind.TabIndex = 0;
            dataGrind.CellContentClick += dataGrind_CellContentClick;
            dataGrind.CellDoubleClick += dataGrind_CellDoubleClick;
            // 
            // lblNomeSetor
            // 
            lblNomeSetor.AutoSize = true;
            lblNomeSetor.Font = new Font("Segoe UI", 12F);
            lblNomeSetor.Location = new Point(19, 200);
            lblNomeSetor.Name = "lblNomeSetor";
            lblNomeSetor.Size = new Size(174, 21);
            lblNomeSetor.TabIndex = 1;
            lblNomeSetor.Text = "Digite o nome do Setor:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F);
            lblid.Location = new Point(344, 201);
            lblid.Name = "lblid";
            lblid.Size = new Size(28, 21);
            lblid.TabIndex = 2;
            lblid.Text = "ID:";
            // 
            // txtNomeSetor
            // 
            txtNomeSetor.Location = new Point(24, 225);
            txtNomeSetor.Name = "txtNomeSetor";
            txtNomeSetor.Size = new Size(298, 26);
            txtNomeSetor.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(726, 77);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(132, 49);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(25, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(344, 225);
            txtID.Name = "txtID";
            txtID.Size = new Size(69, 26);
            txtID.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(649, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 49);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(758, 214);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 49);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListarTodos
            // 
            btnListarTodos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarTodos.Location = new Point(25, 551);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(700, 49);
            btnListarTodos.TabIndex = 10;
            btnListarTodos.Text = "Listar todos";
            btnListarTodos.UseVisualStyleBackColor = true;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // btnListarPnome
            // 
            btnListarPnome.BackColor = Color.Transparent;
            btnListarPnome.Image = (Image)resources.GetObject("btnListarPnome.Image");
            btnListarPnome.Location = new Point(439, 214);
            btnListarPnome.Name = "btnListarPnome";
            btnListarPnome.Size = new Size(53, 49);
            btnListarPnome.TabIndex = 11;
            btnListarPnome.UseVisualStyleBackColor = false;
            btnListarPnome.Click += btnListarPnome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 12;
            label1.Text = "Criação de Setor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 160);
            label2.Name = "label2";
            label2.Size = new Size(303, 28);
            label2.TabIndex = 13;
            label2.Text = "Alteração e Exclusão de Setor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(526, 26);
            txtNome.TabIndex = 7;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(745, 551);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(113, 49);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Setor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 612);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListarPnome);
            Controls.Add(btnListarTodos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lblNome);
            Controls.Add(btnGravar);
            Controls.Add(txtNomeSetor);
            Controls.Add(lblid);
            Controls.Add(lblNomeSetor);
            Controls.Add(dataGrind);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Setor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Setores";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrind).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrind;
        private Label lblNomeSetor;
        private Label lblid;
        private TextBox txtNomeSetor;
        private Button btnGravar;
        private Label lblNome;
        private TextBox txtID;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListarTodos;
        private Button btnListarPnome;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Button btnLimpar;
    }
}
