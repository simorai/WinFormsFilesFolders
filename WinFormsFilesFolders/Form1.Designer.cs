namespace WinFormsFilesFolders
{
    partial class Form1
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
            txtPasta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtExtensao = new TextBox();
            label6 = new Label();
            txtOrigem = new TextBox();
            txtExtensaoNome = new TextBox();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            btnListarSubPastas = new Button();
            btnListarFicheiros = new Button();
            btnListarFicheirosDetalhados = new Button();
            btnListarFicheirosPorExtensao = new Button();
            btnCriarPasta = new Button();
            btnMoverFicheiro = new Button();
            btnApagarPorExtensao = new Button();
            listBox1 = new ListBox();
            label8 = new Label();
            label9 = new Label();
            txtDestino = new TextBox();
            btnCopiarFicheiro = new Button();
            label10 = new Label();
            label11 = new Label();
            txtPastaApagar = new TextBox();
            btnApagarPorNome = new Button();
            btnAjudaCopiarMover = new Button();
            btnAjudaExtensao = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPasta
            // 
            txtPasta.Location = new Point(12, 78);
            txtPasta.Name = "txtPasta";
            txtPasta.Size = new Size(471, 31);
            txtPasta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 1;
            label1.Text = "Operações listar ou criar pastas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(598, 25);
            label2.TabIndex = 2;
            label2.Text = "Listar todos os ficheiros existentes dentro de uma determinada pasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 249);
            label3.Name = "label3";
            label3.Size = new Size(495, 25);
            label3.TabIndex = 5;
            label3.Text = "Listar todos os ficheiros, com o seu tamanho e extensões";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 334);
            label4.Name = "label4";
            label4.Size = new Size(453, 25);
            label4.TabIndex = 6;
            label4.Text = "Listar apenas ficheiros com determinadas extensões";
            // 
            // txtExtensao
            // 
            txtExtensao.Location = new Point(12, 365);
            txtExtensao.Name = "txtExtensao";
            txtExtensao.Size = new Size(210, 31);
            txtExtensao.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1033, 50);
            label6.Name = "label6";
            label6.Size = new Size(317, 25);
            label6.TabIndex = 10;
            label6.Text = "Copiar/Mover ficheiros entre pastas";
            // 
            // txtOrigem
            // 
            txtOrigem.Location = new Point(832, 78);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(518, 31);
            txtOrigem.TabIndex = 11;
            // 
            // txtExtensaoNome
            // 
            txtExtensaoNome.Location = new Point(1137, 278);
            txtExtensaoNome.Name = "txtExtensaoNome";
            txtExtensaoNome.Size = new Size(213, 31);
            txtExtensaoNome.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(711, 212);
            label7.Name = "label7";
            label7.Size = new Size(639, 25);
            label7.TabIndex = 13;
            label7.Text = "Apagar ficheiros com determinados critérios com extensões ou caracteres\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1362, 33);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(87, 29);
            fToolStripMenuItem.Text = "&Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(127, 30);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(72, 29);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(145, 30);
            sobreToolStripMenuItem.Text = "&Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // btnListarSubPastas
            // 
            btnListarSubPastas.BackColor = SystemColors.ButtonHighlight;
            btnListarSubPastas.Location = new Point(12, 115);
            btnListarSubPastas.Name = "btnListarSubPastas";
            btnListarSubPastas.Size = new Size(94, 29);
            btnListarSubPastas.TabIndex = 17;
            btnListarSubPastas.Text = "Listar pastas";
            btnListarSubPastas.UseVisualStyleBackColor = false;
            btnListarSubPastas.Click += btnListarSubPastas_Click;
            // 
            // btnListarFicheiros
            // 
            btnListarFicheiros.Location = new Point(12, 189);
            btnListarFicheiros.Name = "btnListarFicheiros";
            btnListarFicheiros.Size = new Size(94, 29);
            btnListarFicheiros.TabIndex = 18;
            btnListarFicheiros.Text = "Listar";
            btnListarFicheiros.UseVisualStyleBackColor = true;
            btnListarFicheiros.Click += btnListarFicheiros_Click;
            // 
            // btnListarFicheirosDetalhados
            // 
            btnListarFicheirosDetalhados.Location = new Point(12, 279);
            btnListarFicheirosDetalhados.Name = "btnListarFicheirosDetalhados";
            btnListarFicheirosDetalhados.Size = new Size(94, 29);
            btnListarFicheirosDetalhados.TabIndex = 19;
            btnListarFicheirosDetalhados.Text = "Listar";
            btnListarFicheirosDetalhados.UseVisualStyleBackColor = true;
            btnListarFicheirosDetalhados.Click += btnListarFicheirosDetalhados_Click;
            // 
            // btnListarFicheirosPorExtensao
            // 
            btnListarFicheirosPorExtensao.Location = new Point(12, 402);
            btnListarFicheirosPorExtensao.Name = "btnListarFicheirosPorExtensao";
            btnListarFicheirosPorExtensao.Size = new Size(94, 29);
            btnListarFicheirosPorExtensao.TabIndex = 20;
            btnListarFicheirosPorExtensao.Text = "Listar";
            btnListarFicheirosPorExtensao.UseVisualStyleBackColor = true;
            btnListarFicheirosPorExtensao.Click += btnListarFicheirosPorExtensao_Click;
            // 
            // btnCriarPasta
            // 
            btnCriarPasta.Location = new Point(112, 114);
            btnCriarPasta.Name = "btnCriarPasta";
            btnCriarPasta.Size = new Size(210, 30);
            btnCriarPasta.TabIndex = 21;
            btnCriarPasta.Text = "Criar nova pasta";
            btnCriarPasta.UseVisualStyleBackColor = true;
            btnCriarPasta.Click += btnCriarPasta_Click;
            // 
            // btnMoverFicheiro
            // 
            btnMoverFicheiro.Location = new Point(1184, 150);
            btnMoverFicheiro.Name = "btnMoverFicheiro";
            btnMoverFicheiro.Size = new Size(166, 39);
            btnMoverFicheiro.TabIndex = 22;
            btnMoverFicheiro.Text = "Mover Ficheiros";
            btnMoverFicheiro.UseVisualStyleBackColor = true;
            btnMoverFicheiro.Click += btnMoverFicheiro_Click;
            // 
            // btnApagarPorExtensao
            // 
            btnApagarPorExtensao.Location = new Point(1151, 317);
            btnApagarPorExtensao.Name = "btnApagarPorExtensao";
            btnApagarPorExtensao.Size = new Size(199, 42);
            btnApagarPorExtensao.TabIndex = 23;
            btnApagarPorExtensao.Text = "Apagar por extensao";
            btnApagarPorExtensao.UseVisualStyleBackColor = true;
            btnApagarPorExtensao.Click += btnApagarPorExtensao_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(650, 374);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(700, 304);
            listBox1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(749, 78);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 25;
            label8.Text = "Origem:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(749, 113);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 26;
            label9.Text = "Destino:";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(832, 113);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(518, 31);
            txtDestino.TabIndex = 27;
            // 
            // btnCopiarFicheiro
            // 
            btnCopiarFicheiro.Location = new Point(1012, 150);
            btnCopiarFicheiro.Name = "btnCopiarFicheiro";
            btnCopiarFicheiro.Size = new Size(166, 39);
            btnCopiarFicheiro.TabIndex = 28;
            btnCopiarFicheiro.Text = "Copiar Ficheiros";
            btnCopiarFicheiro.UseVisualStyleBackColor = true;
            btnCopiarFicheiro.Click += btnCopiarFicheiro_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(759, 243);
            label10.Name = "label10";
            label10.Size = new Size(163, 25);
            label10.TabIndex = 29;
            label10.Text = "Pasta dos ficheiros:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(979, 281);
            label11.Name = "label11";
            label11.Size = new Size(152, 25);
            label11.TabIndex = 30;
            label11.Text = "Extensão / Nome:";
            // 
            // txtPastaApagar
            // 
            txtPastaApagar.Location = new Point(928, 240);
            txtPastaApagar.Name = "txtPastaApagar";
            txtPastaApagar.Size = new Size(422, 31);
            txtPastaApagar.TabIndex = 31;
            // 
            // btnApagarPorNome
            // 
            btnApagarPorNome.Location = new Point(951, 317);
            btnApagarPorNome.Name = "btnApagarPorNome";
            btnApagarPorNome.Size = new Size(194, 42);
            btnApagarPorNome.TabIndex = 32;
            btnApagarPorNome.Text = "Apagar por nome";
            btnApagarPorNome.UseVisualStyleBackColor = true;
            btnApagarPorNome.Click += btnApagarPorNome_Click;
            // 
            // btnAjudaCopiarMover
            // 
            btnAjudaCopiarMover.BackColor = Color.LimeGreen;
            btnAjudaCopiarMover.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjudaCopiarMover.Location = new Point(969, 150);
            btnAjudaCopiarMover.Name = "btnAjudaCopiarMover";
            btnAjudaCopiarMover.Size = new Size(37, 39);
            btnAjudaCopiarMover.TabIndex = 33;
            btnAjudaCopiarMover.Text = "?";
            btnAjudaCopiarMover.UseVisualStyleBackColor = false;
            btnAjudaCopiarMover.Click += btnAjudaCopiarMover_Click;
            // 
            // btnAjudaExtensao
            // 
            btnAjudaExtensao.BackColor = Color.LimeGreen;
            btnAjudaExtensao.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjudaExtensao.Location = new Point(937, 272);
            btnAjudaExtensao.Name = "btnAjudaExtensao";
            btnAjudaExtensao.Size = new Size(36, 39);
            btnAjudaExtensao.TabIndex = 34;
            btnAjudaExtensao.Text = "?";
            btnAjudaExtensao.UseVisualStyleBackColor = false;
            btnAjudaExtensao.Click += btnAjudaExtensao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1362, 690);
            Controls.Add(btnAjudaExtensao);
            Controls.Add(btnAjudaCopiarMover);
            Controls.Add(btnApagarPorNome);
            Controls.Add(txtPastaApagar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnCopiarFicheiro);
            Controls.Add(txtDestino);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(btnApagarPorExtensao);
            Controls.Add(btnMoverFicheiro);
            Controls.Add(btnCriarPasta);
            Controls.Add(btnListarFicheirosPorExtensao);
            Controls.Add(btnListarFicheirosDetalhados);
            Controls.Add(btnListarFicheiros);
            Controls.Add(btnListarSubPastas);
            Controls.Add(label7);
            Controls.Add(txtExtensaoNome);
            Controls.Add(txtOrigem);
            Controls.Add(label6);
            Controls.Add(txtExtensao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPasta;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox txtExtensao;
        private Label label6;
        private TextBox txtOrigem;
        private TextBox txtExtensaoNome;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnListarSubPastas;
        private Button btnListarFicheiros;
        private Button btnListarFicheirosDetalhados;
        private Button btnListarFicheirosPorExtensao;
        private Button btnCriarPasta;
        private Button btnMoverFicheiro;
        private Button btnApagarPorExtensao;
        private ListBox listBox1;
        private Label label8;
        private Label label9;
        private TextBox txtDestino;
        private Button btnCopiarFicheiro;
        private Label label10;
        private Label label11;
        private TextBox txtPastaApagar;
        private Button btnApagarPorNome;
        private Button btnAjudaCopiarMover;
        private Button btnAjudaExtensao;
    }
}
