namespace Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblcdcliente = new Label();
            textBox1 = new TextBox();
            lblnome = new Label();
            textBox2 = new TextBox();
            lblcpf = new Label();
            mskCPF = new MaskedTextBox();
            lblrg = new Label();
            mskRG = new MaskedTextBox();
            lbluf = new Label();
            lblData = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lbltelefone = new Label();
            maskedTextBox2 = new MaskedTextBox();
            lblSexo = new Label();
            rdbMasculino1 = new RadioButton();
            rdbFeminino1 = new RadioButton();
            button1 = new Button();
            cmbUF = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnExcluirCliente = new Button();
            button2 = new Button();
            btnExcluirTodos = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblcdcliente
            // 
            lblcdcliente.AutoSize = true;
            lblcdcliente.Location = new Point(20, 381);
            lblcdcliente.Name = "lblcdcliente";
            lblcdcliente.Size = new Size(106, 15);
            lblcdcliente.TabIndex = 0;
            lblcdcliente.Text = "Código do Cliente:";
            lblcdcliente.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 378);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(105, 23);
            textBox1.TabIndex = 14;
            textBox1.Visible = false;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(52, 70);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(100, 15);
            lblnome.TabIndex = 2;
            lblnome.Text = "Nome do Cliente:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(475, 23);
            textBox2.TabIndex = 1;
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(52, 114);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(88, 15);
            lblcpf.TabIndex = 4;
            lblcpf.Text = "CPF do Cliente:";
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(158, 106);
            mskCPF.Mask = "999.999.999.99";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(105, 23);
            mskCPF.TabIndex = 5;
            // 
            // lblrg
            // 
            lblrg.AutoSize = true;
            lblrg.Location = new Point(269, 114);
            lblrg.Name = "lblrg";
            lblrg.Size = new Size(82, 15);
            lblrg.TabIndex = 6;
            lblrg.Text = "RG do Cliente:";
            // 
            // mskRG
            // 
            mskRG.Location = new Point(357, 106);
            mskRG.Mask = "999-999-999-9";
            mskRG.Name = "mskRG";
            mskRG.Size = new Size(105, 23);
            mskRG.TabIndex = 7;
            // 
            // lbluf
            // 
            lbluf.AutoSize = true;
            lbluf.Location = new Point(468, 114);
            lbluf.Name = "lbluf";
            lbluf.Size = new Size(81, 15);
            lbluf.TabIndex = 8;
            lbluf.Text = "UF do Cliente:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(52, 151);
            lblData.Name = "lblData";
            lblData.Size = new Size(117, 15);
            lblData.TabIndex = 10;
            lblData.Text = "Data de Nascimento:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(175, 151);
            maskedTextBox1.Mask = "0000/00/00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(281, 159);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(109, 15);
            lbltelefone.TabIndex = 12;
            lbltelefone.Text = "Telefone do cliente:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(396, 156);
            maskedTextBox2.Mask = "(99) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 10;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(502, 164);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 14;
            lblSexo.Text = "Sexo:";
            // 
            // rdbMasculino1
            // 
            rdbMasculino1.AutoSize = true;
            rdbMasculino1.Location = new Point(543, 164);
            rdbMasculino1.Name = "rdbMasculino1";
            rdbMasculino1.Size = new Size(80, 19);
            rdbMasculino1.TabIndex = 11;
            rdbMasculino1.TabStop = true;
            rdbMasculino1.Text = "Masculino";
            rdbMasculino1.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino1
            // 
            rdbFeminino1.AutoSize = true;
            rdbFeminino1.Location = new Point(631, 164);
            rdbFeminino1.Name = "rdbFeminino1";
            rdbFeminino1.Size = new Size(75, 19);
            rdbFeminino1.TabIndex = 12;
            rdbFeminino1.TabStop = true;
            rdbFeminino1.Text = "Feminino";
            rdbFeminino1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 50;
            button1.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button1.ForeColor = SystemColors.WindowText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 211);
            button1.Name = "button1";
            button1.Size = new Size(107, 85);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbUF
            // 
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE ", "DF ", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbUF.Location = new Point(555, 111);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(78, 23);
            cmbUF.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 12);
            label1.Name = "label1";
            label1.Size = new Size(231, 29);
            label1.TabIndex = 20;
            label1.Text = "Cadastro de Clientes";
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.Red;
            btnExcluirCliente.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnExcluirCliente.FlatAppearance.BorderSize = 50;
            btnExcluirCliente.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnExcluirCliente.ForeColor = SystemColors.WindowText;
            btnExcluirCliente.Image = (Image)resources.GetObject("btnExcluirCliente.Image");
            btnExcluirCliente.Location = new Point(249, 361);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(63, 55);
            btnExcluirCliente.TabIndex = 21;
            btnExcluirCliente.UseVisualStyleBackColor = false;
            btnExcluirCliente.Visible = false;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 50;
            button2.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button2.ForeColor = SystemColors.WindowText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(157, 211);
            button2.Name = "button2";
            button2.Size = new Size(106, 85);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnExcluirTodos
            // 
            btnExcluirTodos.BackColor = Color.Violet;
            btnExcluirTodos.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnExcluirTodos.FlatAppearance.BorderSize = 50;
            btnExcluirTodos.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnExcluirTodos.ForeColor = SystemColors.WindowText;
            btnExcluirTodos.Image = (Image)resources.GetObject("btnExcluirTodos.Image");
            btnExcluirTodos.Location = new Point(301, 211);
            btnExcluirTodos.Name = "btnExcluirTodos";
            btnExcluirTodos.Size = new Size(106, 85);
            btnExcluirTodos.TabIndex = 23;
            btnExcluirTodos.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 50;
            button3.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button3.ForeColor = SystemColors.WindowText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(443, 211);
            button3.Name = "button3";
            button3.Size = new Size(106, 85);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Wheat;
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.BorderSize = 50;
            button4.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button4.ForeColor = SystemColors.WindowText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(589, 211);
            button4.Name = "button4";
            button4.Size = new Size(106, 85);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(589, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 26;
            dataGridView1.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(413, 378);
            button5.Name = "button5";
            button5.Size = new Size(62, 54);
            button5.TabIndex = 27;
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button6.FlatAppearance.BorderSize = 50;
            button6.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button6.ForeColor = SystemColors.WindowText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(723, 211);
            button6.Name = "button6";
            button6.Size = new Size(106, 85);
            button6.TabIndex = 28;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 466);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnExcluirTodos);
            Controls.Add(button2);
            Controls.Add(btnExcluirCliente);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(cmbUF);
            Controls.Add(button1);
            Controls.Add(rdbFeminino1);
            Controls.Add(rdbMasculino1);
            Controls.Add(lblSexo);
            Controls.Add(maskedTextBox2);
            Controls.Add(lbltelefone);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblData);
            Controls.Add(lbluf);
            Controls.Add(mskRG);
            Controls.Add(lblrg);
            Controls.Add(mskCPF);
            Controls.Add(lblcpf);
            Controls.Add(textBox2);
            Controls.Add(lblnome);
            Controls.Add(textBox1);
            Controls.Add(lblcdcliente);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcdcliente;
        private TextBox textBox1;
        private Label lblnome;
        private TextBox textBox2;
        private Label lblcpf;
        private MaskedTextBox mskCPF;
        private Label lblrg;
        private MaskedTextBox mskRG;
        private Label lbluf;
        private Label lblData;
        private MaskedTextBox maskedTextBox1;
        private Label lbltelefone;
        private MaskedTextBox maskedTextBox2;
        private Label lblSexo;
        private RadioButton rdbMasculino1;
        private RadioButton rdbFeminino1;
        private Button button1;
        private ComboBox cmbUF;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnExcluirCliente;
        private Button button2;
        private Button btnExcluirTodos;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button6;
    }
}