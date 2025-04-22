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
                    } else
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
            MetodoSetor metodo = new MetodoSetor();
            metodo.Nome = txtNomeSetor.Text;
            metodo.Id = int.Parse(txtID.Text);
            metodo.EditarSetor();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MetodoSetor metodo = new MetodoSetor();
            metodo.Nome = txtNomeSetor.Text;   
            metodo.Id = int.Parse(txtID.Text);   
            metodo.ExcluirSetor();
        }

        private void btnListarPnome_Click(object sender, EventArgs e)
        {

        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            MetodoSetor metodo = new MetodoSetor();

            metodo.ListarTodosSetores(dataGrind);
        }

        private void dataGrind_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
