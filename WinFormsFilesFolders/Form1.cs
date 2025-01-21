namespace WinFormsFilesFolders
{
    /// <summary>
    /// Classe principal do formul�rio da aplica��o.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inst�ncia da classe FileHandling para realizar opera��es com arquivos e pastas.
        /// </summary>
        private FileHandling fileHandler;

        /// <summary>
        /// Construtor da classe Form1.
        /// </summary>
        public Form1()
        {
            // Inicializa os componentes do formul�rio
            InitializeComponent();
            // Cria uma nova inst�ncia de FileHandling
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
            MessageBox.Show("Manipula��o de ficheiros vers�o 1.0\nSim�o Morais\n20/01/2025 CET 97");
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Listar Sub Pastas".
        /// </summary>
        private void btnListarSubPastas_Click(object sender, EventArgs e)
        {
            // Obt�m o caminho da pasta do campo de texto
            string pasta = txtPasta.Text;
            // Chama o m�todo para listar subpastas
            fileHandler.ListarSubpastas(pasta, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Listar Ficheiros".
        /// </summary>
        private void btnListarFicheiros_Click(object sender, EventArgs e)
        {
            string pasta = txtPasta.Text;
            fileHandler.ListarFicheiros(pasta, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Listar Ficheiros Detalhados".
        /// </summary>
        private void btnListarFicheirosDetalhados_Click(object sender, EventArgs e)
        {
            string pasta = txtPasta.Text;
            fileHandler.ListarFicheirosDetalhados(pasta, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Listar Ficheiros Por Extens�o".
        /// </summary>
        private void btnListarFicheirosPorExtensao_Click(object sender, EventArgs e)
        {
            // Obt�m o caminho da pasta e a extens�o dos campos de texto
            string pasta = txtPasta.Text;
            string extensao = txtExtensao.Text;
            // Chama o m�todo para listar arquivos por extens�o
            fileHandler.ListarFicheirosPorExtensao(pasta, extensao, listBox1);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Criar Pasta".
        /// </summary>
        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            string caminho = txtPasta.Text;
            fileHandler.CriarPasta(caminho);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Mover Ficheiro".
        /// </summary>
        private void btnMoverFicheiro_Click(object sender, EventArgs e)
        {
            string origem = txtOrigem.Text;
            string destino = txtDestino.Text;
            fileHandler.MoverFicheiro(origem, destino);
        }
        /// <summary>
        /// Manipulador de evento para o bot�o "Copiar Ficheiro".
        /// </summary>
        private void btnCopiarFicheiro_Click(object sender, EventArgs e)
        {
            // Obt�m os caminhos de origem e destino dos campos de texto
            string origem = txtOrigem.Text;
            string destino = txtDestino.Text;
            // Chama o m�todo para copiar o arquivo
            fileHandler.CopiarFicheiro(origem, destino);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Apagar Por Extens�o".
        /// </summary>
        private void btnApagarPorExtensao_Click(object sender, EventArgs e)
        {
            // Obt�m o caminho da pasta e a extens�o dos campos de texto
            string pasta = txtPastaApagar.Text;
            string extensao = txtExtensaoNome.Text;
            // Chama o m�todo para apagar arquivos por extens�o
            fileHandler.ApagarFicheirosPorExtensao(pasta, extensao);
        }

        /// <summary>
        /// Manipulador de evento para o bot�o "Apagar Por Nome".
        /// </summary>
        private void btnApagarPorNome_Click(object sender, EventArgs e)
        {
            // Obt�m o caminho da pasta e o padr�o de nome dos campos de texto
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
