namespace WinFormsFilesFolders
{
    /// <summary>
    /// Classe principal do formulário da aplicação.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instância da classe FileHandling para realizar operações com arquivos e pastas.
        /// </summary>
        private FileHandling fileHandler;

        /// <summary>
        /// Construtor da classe Form1.
        /// </summary>
        public Form1()
        {
            // Inicializa os componentes do formulário
            InitializeComponent();
            // Cria uma nova instância de FileHandling
            fileHandler = new FileHandling();
        }

        /// <summary>
        /// Manipulador de evento para o item de menu "Sair".
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Manipulador de evento para o item de menu "Sobre".
        /// </summary>
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manipulação de ficheiros versão 1.0\nSimão Morais\n20/01/2025 CET 97");
        }

        /// <summary>
        /// Manipulador de evento para o botão "Listar Sub Pastas".
        /// </summary>
        private void btnListarSubPastas_Click(object sender, EventArgs e)
        {
            // Obtém o caminho da pasta do campo de texto
            string pasta = txtPasta.Text;
            // Chama o método para listar subpastas
            fileHandler.ListarSubpastas(pasta, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Listar Ficheiros".
        /// </summary>
        private void btnListarFicheiros_Click(object sender, EventArgs e)
        {
            string pasta = txtPasta.Text;
            fileHandler.ListarFicheiros(pasta, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Listar Ficheiros Detalhados".
        /// </summary>
        private void btnListarFicheirosDetalhados_Click(object sender, EventArgs e)
        {
            string pasta = txtPasta.Text;
            fileHandler.ListarFicheirosDetalhados(pasta, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Listar Ficheiros Por Extensão".
        /// </summary>
        private void btnListarFicheirosPorExtensao_Click(object sender, EventArgs e)
        {
            // Obtém o caminho da pasta e a extensão dos campos de texto
            string pasta = txtPasta.Text;
            string extensao = txtExtensao.Text;
            // Chama o método para listar arquivos por extensão
            fileHandler.ListarFicheirosPorExtensao(pasta, extensao, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Criar Pasta".
        /// </summary>
        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            string caminho = txtPasta.Text;
            fileHandler.CriarPasta(caminho);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Mover Ficheiro".
        /// </summary>
        private void btnMoverFicheiro_Click(object sender, EventArgs e)
        {
            string origem = txtOrigem.Text;
            string destino = txtDestino.Text;
            fileHandler.MoverFicheiro(origem, destino);
        }
        /// <summary>
        /// Manipulador de evento para o botão "Copiar Ficheiro".
        /// </summary>
        private void btnCopiarFicheiro_Click(object sender, EventArgs e)
        {
            // Obtém os caminhos de origem e destino dos campos de texto
            string origem = txtOrigem.Text;
            string destino = txtDestino.Text;
            // Chama o método para copiar o arquivo
            fileHandler.CopiarFicheiro(origem, destino);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Apagar Por Extensão".
        /// </summary>
        private void btnApagarPorExtensao_Click(object sender, EventArgs e)
        {
            // Obtém o caminho da pasta e a extensão dos campos de texto
            string pasta = txtPastaApagar.Text;
            string extensao = txtExtensaoNome.Text;
            // Chama o método para apagar arquivos por extensão
            fileHandler.ApagarFicheirosPorExtensao(pasta, extensao);
        }

        /// <summary>
        /// Manipulador de evento para o botão "Apagar Por Nome".
        /// </summary>
        private void btnApagarPorNome_Click(object sender, EventArgs e)
        {
            // Obtém o caminho da pasta e o padrão de nome dos campos de texto
            string pasta = txtPastaApagar.Text;
            string nome = txtExtensaoNome.Text;
            fileHandler.ApagarFicheirosPorNome(pasta, nome);
        }

        private void btnAjudaCopiarMover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ex:\nC:\\Projetos\\ExerciciosFiles\\ExerciciosFiles\\TestFiles\\file.txt\n" +
                "C:\\Projetos\\ExerciciosFiles\\ExerciciosFiles\\TestFiles\\novaPasta\\file.txt");
        }

        private void btnAjudaExtensao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ex:\nC:\\Projetos\\ExerciciosFiles\\ExerciciosFiles\\TestFiles\\\n" +
                "\ntxt " + "docx " + "bmp " + "...");
        }
    }
}
