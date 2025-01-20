using System.IO;
using System;
using System.Windows.Forms;

namespace WinFormsFilesFolders
{
    internal class FileHandling
    {
        //Aceder a pastas       
        //Exemplo
        // C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiles

        public void ListarSubpastas(string pasta, ListBox listBox)
        {
            try
            {
                string[] subpastas = Directory.GetDirectories(pasta);
                listBox.Items.Clear();
                foreach (string subpasta in subpastas)
                {
                    listBox.Items.Add(subpasta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar sub-pastas: " + ex.Message);
            }
        }

        public void ListarFicheiros(string pasta, ListBox listBox) {
            try
            {
                string[] ficheiros = Directory.GetFiles(pasta);
                listBox.Items.Clear();
                foreach (string ficheiro in ficheiros)
                {
                    listBox.Items.Add(Path.GetFileName(ficheiro));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ficheiros: " + ex.Message);
            }
        }

        public void ListarFicheirosDetalhados(string pasta) { }
        public void ListarFicheirosPorExtensao(string pasta, string extensao) {}
        public void CriarPasta(string caminho) {}
        public void CopiarFicheiro(string origem, string destino) {}
        public void MoverFicheiro(string origem, string destino) {}
        public void ApagarFicheirosPorExtensao(string pasta, string extensao) { }
        public void ApagarFicheirosPorNome(string pasta, string padrao) {  }


    }
}
