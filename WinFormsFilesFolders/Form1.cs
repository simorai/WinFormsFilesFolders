namespace WinFormsFilesFolders
{
    public partial class Form1 : Form
    {
        private FileHandling fileHandler;

        public Form1()
        {
            InitializeComponent();
            fileHandler = new FileHandling();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manipulação de ficheiros versão 1.0\nSimão Morais\n20/01/2025 CET 97");
        }

        private void btnListarSubPastas_Click(object sender, EventArgs e)
        {
            string pasta = txtPasta.Text;
            fileHandler.ListarSubpastas(pasta, listBox1);
        }

        private void btnListarFicheiros_Click(object sender, EventArgs e)
        {
            string pasta = txtPasta.Text;
            fileHandler.ListarFicheiros(pasta, listBox1);
        }        
    }
}
