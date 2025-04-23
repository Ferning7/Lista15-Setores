using MySql.Data.MySqlClient;

namespace Setor
{
    public partial class Setor : Form
    {
        public Setor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dataGrind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    MetodoSetor metodos = new MetodoSetor();
                    metodos.Nome = txtNome.Text;

                    if (metodos.verificarSetorExistente())
                    {
                        if (metodos.InserirSetor())
                        {
                            MessageBox.Show("Setor gravado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível gravar o nome do Setor");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Setor já existente!");
                    }

                }
                else
                {
                    MessageBox.Show("Insira um nome para o novo Setor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar setor -> {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtNomeSetor.Text.Equals("") && !txtID.Text.Equals(""))
            {
                MetodoSetor metodo = new MetodoSetor();
                metodo.Nome = txtNomeSetor.Text;
                metodo.Id = int.Parse(txtID.Text);
                metodo.EditarSetor();
                txtNomeSetor.Clear();
                txtID.Clear();
                dataGrind.ClearSelection();
                metodo.ListarTodosSetores(dataGrind);
            }
            else
            {
                MessageBox.Show("Não é possível editar um campo vazio!");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!txtNomeSetor.Text.Equals("") && !txtID.Text.Equals(""))
            {
                MetodoSetor metodo = new MetodoSetor();
                metodo.Nome = txtNomeSetor.Text;
                metodo.Id = int.Parse(txtID.Text);
                metodo.ExcluirSetor();
                txtNomeSetor.Clear();
                txtID.Clear();
                dataGrind.ClearSelection();
                metodo.ListarTodosSetores(dataGrind);
            }
            else
            {
                MessageBox.Show("Não é possível apagar campos vazios!");
            }
        }

        private void btnListarPnome_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoSetor metodo = new MetodoSetor();

                if (!string.IsNullOrEmpty(txtNomeSetor.Text))
                {
                    metodo.Nome = txtNomeSetor.Text;

                    // Chama o método para listar os setores pelo nome e preenche o DataGrid
                    metodo.ListarSetorNome(dataGrind);
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                else if (!string.IsNullOrEmpty(txtID.Text))
                {
                    metodo.Id = int.Parse(txtID.Text);

                    // Chama o método para listar setores por ID
                    metodo.ListarSetorNome(dataGrind);
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro: Informe o nome do setor ou o ID para listar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ->" + ex.Message);
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            MetodoSetor metodo = new MetodoSetor();
            metodo.ListarTodosSetores(dataGrind);

            int colunaIdIndex = dataGrind.Columns["id"].Index;

            
            dataGrind.Columns[colunaIdIndex].Width = 100;
        }

        private void dataGrind_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGrind.CurrentRow.Cells[0].Value.ToString();
            txtNomeSetor.Text = dataGrind.CurrentRow.Cells[1].Value.ToString();

            txtID.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeSetor.Clear();
            txtID.Clear();
            dataGrind.ClearSelection();
            txtID.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }
    }
}
