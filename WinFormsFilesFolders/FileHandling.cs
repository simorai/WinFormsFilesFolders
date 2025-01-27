using System.IO;
using System;
using System.Windows.Forms;

namespace WinFormsFilesFolders
{
    /// <summary>
    /// Classe responsável por operações de manipulação de arquivos e pastas.
    /// </summary>
    internal class FileHandling
    {
        //Aceder a pastas       
        //Pasta de exemplo
        // C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiles

        /// <summary>
        /// Lista as subpastas de uma pasta específica e as exibe em um ListBox.
        /// </summary>
        /// <param name="pasta">O caminho da pasta a ser analisada.</param>
        /// <param name="listBox">O ListBox onde as subpastas serão exibidas.</param>
        public void ListarSubpastas(string pasta, ListBox listBox)
        {
            try
            {
                // Obtém um array com todos os diretórios na pasta especificada
                string[] subpastas = Directory.GetDirectories(pasta);
                // Limpa todos os itens existentes no ListBox
                listBox.Items.Clear();
                // Itera sobre cada subpasta encontrada
                foreach (string subpasta in subpastas)
                {
                    // Adiciona o caminho completo da subpasta ao ListBox
                    listBox.Items.Add(subpasta);
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao listar sub-pastas: " + ex.Message);
            }
        }

        /// <summary>
        /// Lista os arquivos de uma pasta específica e os exibe em um ListBox.
        /// </summary>
        /// <param name="pasta">O caminho da pasta a ser analisada.</param>
        /// <param name="listBox">O ListBox onde os nomes dos arquivos serão exibidos.</param>
        public void ListarFicheiros(string pasta, ListBox listBox)
        {
            try
            {
                // Obtem um array com todos os arquivos na pasta especificada
                string[] ficheiros = Directory.GetFiles(pasta);
                listBox.Items.Clear();
                foreach (string ficheiro in ficheiros)
                {
                    // Adiciona apenas o nome do arquivo (sem o caminho completo) ao ListBox
                    listBox.Items.Add(Path.GetFileName(ficheiro));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ficheiros: " + ex.Message);
            }
        }

        /// <summary>
        /// Lista os arquivos de uma pasta específica com detalhes e os exibe em um ListBox.
        /// </summary>
        /// <param name="pasta">O caminho da pasta a ser analisada.</param>
        /// <param name="listBox">O ListBox onde os detalhes dos arquivos serão exibidos.</param>
        public void ListarFicheirosDetalhados(string pasta, ListBox listBox)
        {
            try
            {
                // Cria um objeto DirectoryInfo para a pasta especificada e obtem todos os arquivos
                var ficheiros = new DirectoryInfo(pasta).GetFiles();
                listBox.Items.Clear();
                foreach (var ficheiro in ficheiros)
                {
                    // Adiciona uma string formatada com nome, tamanho e extensão do arquivo ao ListBox
                    listBox.Items.Add($"{ficheiro.Name} - {ficheiro.Length} bytes - {ficheiro.Extension}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ficheiros detalhados: " + ex.Message);
            }
        }

        /// <summary>
        /// Lista os arquivos de uma pasta específica com uma determinada extensão e os exibe em um ListBox.
        /// </summary>
        /// <param name="pasta">O caminho da pasta a ser analisada.</param>
        /// <param name="extensao">A extensão dos arquivos a serem listados.</param>
        /// <param name="listBox">O ListBox onde os nomes dos arquivos serão exibidos.</param>
        public void ListarFicheirosPorExtensao(string pasta, string extensao, ListBox listBox)
        {
            try
            {
                // Cria um objeto DirectoryInfo para a pasta especificada e obtém os arquivos com a extensão desejada
                var ficheiros = new DirectoryInfo(pasta).GetFiles($"*{extensao}");
                listBox.Items.Clear();
                // Itera sobre cada arquivo encontrado
                foreach (var ficheiro in ficheiros)
                {
                    // Adiciona o nome do arquivo ao ListBox
                    listBox.Items.Add(ficheiro.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ficheiros por extensão: " + ex.Message);
            }
        }

        /// <summary>
        /// Cria uma nova pasta no caminho especificado.
        /// </summary>
        /// <param name="caminho">O caminho completo onde a nova pasta será criada.</param>
        public void CriarPasta(string caminho)
        {
            try
            {
                // Cria um novo diretório no caminho especificado
                Directory.CreateDirectory(caminho);
                MessageBox.Show("Pasta criada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar pasta: " + ex.Message);
            }
        }

        /// <summary>
        /// Copia um arquivo de uma localização para outra.
        /// </summary>
        /// <param name="origem">O caminho completo do arquivo de origem.</param>
        /// <param name="destino">O caminho completo do arquivo de destino.</param>
        public void CopiarFicheiro(string origem, string destino)
        {
            try
            {
                // Copia o arquivo da origem para o destino, substituindo se já existir
                File.Copy(origem, destino, true);
                MessageBox.Show("Ficheiro copiado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao copiar ficheiro: " + ex.Message);
            }
        }

        /// <summary>
        /// Move um arquivo de uma localização para outra.
        /// </summary>
        /// <param name="origem">O caminho completo do arquivo de origem.</param>
        /// <param name="destino">O caminho completo do arquivo de destino.</param>
        public void MoverFicheiro(string origem, string destino)
        {
            try
            {
                // Move o arquivo da origem para o destino
                File.Move(origem, destino);
                MessageBox.Show("Ficheiro movido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao mover ficheiro: " + ex.Message);
            }
        }

        /// <summary>
        /// Apaga todos os arquivos com uma determinada extensão em uma pasta específica.
        /// </summary>
        /// <param name="pasta">O caminho da pasta onde os arquivos serão apagados.</param>
        /// <param name="extensao">A extensão dos arquivos a serem apagados.</param>
        public void ApagarFicheirosPorExtensao(string pasta, string extensao)
        {
            try
            {
                // Obtem todos os arquivos com a extensão especificada na pasta
                var ficheiros = new DirectoryInfo(pasta).GetFiles($"*{extensao}");
                // Itera sobre cada arquivo encontrado
                foreach (var ficheiro in ficheiros)
                {
                    // Apaga o arquivo
                    ficheiro.Delete();
                }
                MessageBox.Show("Ficheiros apagados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar ficheiros: " + ex.Message);
            }
        }
        /// <summary>
        /// Apaga todos os arquivos cujo nome contém um determinado padrão em uma pasta específica.
        /// </summary>
        /// <param name="pasta">O caminho da pasta onde os arquivos serão apagados.</param>
        /// <param name="padrao">O padrão a ser procurado nos nomes dos arquivos.</param>
        public void ApagarFicheirosPorNome(string pasta, string padrao)
        {
            try
            {
                // Obtem todos os arquivos cujo nome contém o padrão especificado na pasta
                var ficheiros = new DirectoryInfo(pasta).GetFiles($"*{padrao}*");
                foreach (var ficheiro in ficheiros)
                {
                    // Apaga o arquivo
                    ficheiro.Delete();
                }
                MessageBox.Show("Ficheiros apagados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar ficheiros: " + ex.Message);
            }
        }
    }
}
