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
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            btnListarSubPastas = new Button();
            btnListarFicheiros = new Button();
            BtnListarTamanhoExtensao = new Button();
            BtnListarCertaExtensao = new Button();
            BtnCriarPastas = new Button();
            BtnMoverFicheiros = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
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
            label1.Size = new Size(410, 25);
            label1.TabIndex = 1;
            label1.Text = "Listar todas as sub-pastas dentro de uma pasta\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(598, 25);
            label2.TabIndex = 2;
            label2.Text = "Listar todos os ficheiros existentes dentro de uma determinada pasta";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 312);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 31);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 280);
            label3.Name = "label3";
            label3.Size = new Size(495, 25);
            label3.TabIndex = 5;
            label3.Text = "Listar todos os ficheiros, com o seu tamanho e extensões";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 407);
            label4.Name = "label4";
            label4.Size = new Size(453, 25);
            label4.TabIndex = 6;
            label4.Text = "Listar apenas ficheiros com determinadas extensões";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 435);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 572);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(210, 31);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 544);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 9;
            label5.Text = "Criar as pastas desejadas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(877, 33);
            label6.Name = "label6";
            label6.Size = new Size(317, 25);
            label6.TabIndex = 10;
            label6.Text = "Copiar/Mover ficheiros entre pastas";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(676, 61);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(495, 31);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(958, 223);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 31);
            textBox7.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(782, 167);
            label7.Name = "label7";
            label7.Size = new Size(389, 25);
            label7.TabIndex = 13;
            label7.Text = "Apagar ficheiros com determinados critérios";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(955, 195);
            label8.Name = "label8";
            label8.Size = new Size(216, 25);
            label8.TabIndex = 14;
            label8.Text = "extensões ou caracteres";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1219, 33);
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
            btnListarSubPastas.Location = new Point(12, 115);
            btnListarSubPastas.Name = "btnListarSubPastas";
            btnListarSubPastas.Size = new Size(94, 29);
            btnListarSubPastas.TabIndex = 17;
            btnListarSubPastas.Text = "Listar pastas";
            btnListarSubPastas.UseVisualStyleBackColor = true;
            btnListarSubPastas.Click += btnListarSubPastas_Click;
            // 
            // btnListarFicheiros
            // 
            btnListarFicheiros.Location = new Point(12, 228);
            btnListarFicheiros.Name = "btnListarFicheiros";
            btnListarFicheiros.Size = new Size(94, 29);
            btnListarFicheiros.TabIndex = 18;
            btnListarFicheiros.Text = "Listar";
            btnListarFicheiros.UseVisualStyleBackColor = true;
            btnListarFicheiros.Click += btnListarFicheiros_Click;
            // 
            // BtnListarTamanhoExtensao
            // 
            BtnListarTamanhoExtensao.Location = new Point(12, 349);
            BtnListarTamanhoExtensao.Name = "BtnListarTamanhoExtensao";
            BtnListarTamanhoExtensao.Size = new Size(94, 29);
            BtnListarTamanhoExtensao.TabIndex = 19;
            BtnListarTamanhoExtensao.Text = "Listar";
            BtnListarTamanhoExtensao.UseVisualStyleBackColor = true;
            // 
            // BtnListarCertaExtensao
            // 
            BtnListarCertaExtensao.Location = new Point(12, 472);
            BtnListarCertaExtensao.Name = "BtnListarCertaExtensao";
            BtnListarCertaExtensao.Size = new Size(94, 29);
            BtnListarCertaExtensao.TabIndex = 20;
            BtnListarCertaExtensao.Text = "Listar";
            BtnListarCertaExtensao.UseVisualStyleBackColor = true;
            // 
            // BtnCriarPastas
            // 
            BtnCriarPastas.Location = new Point(12, 609);
            BtnCriarPastas.Name = "BtnCriarPastas";
            BtnCriarPastas.Size = new Size(94, 29);
            BtnCriarPastas.TabIndex = 21;
            BtnCriarPastas.Text = "Listar";
            BtnCriarPastas.UseVisualStyleBackColor = true;
            // 
            // BtnMoverFicheiros
            // 
            BtnMoverFicheiros.Location = new Point(949, 98);
            BtnMoverFicheiros.Name = "BtnMoverFicheiros";
            BtnMoverFicheiros.Size = new Size(222, 29);
            BtnMoverFicheiros.TabIndex = 22;
            BtnMoverFicheiros.Text = "Mover Ficheiros";
            BtnMoverFicheiros.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(988, 260);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 23;
            button1.Text = "Apagar ficheiro/s";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(494, 365);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(700, 304);
            listBox1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1219, 690);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(BtnMoverFicheiros);
            Controls.Add(BtnCriarPastas);
            Controls.Add(BtnListarCertaExtensao);
            Controls.Add(BtnListarTamanhoExtensao);
            Controls.Add(btnListarFicheiros);
            Controls.Add(btnListarSubPastas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
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
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnListarSubPastas;
        private Button btnListarFicheiros;
        private Button BtnListarTamanhoExtensao;
        private Button BtnListarCertaExtensao;
        private Button BtnCriarPastas;
        private Button BtnMoverFicheiros;
        private Button button1;
        private ListBox listBox1;
    }
}
