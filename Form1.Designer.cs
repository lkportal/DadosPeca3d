namespace CadastraPecas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            txtEixoZ = new TextBox();
            txtEixoY = new TextBox();
            label4 = new Label();
            txtEixoX = new TextBox();
            txtTamanho = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            label7 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastra Peça";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEixoZ);
            panel1.Controls.Add(txtEixoY);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEixoX);
            panel1.Controls.Add(txtTamanho);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Alfa Slab One", 8.999999F);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 406);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("Alfa Slab One", 8.999999F);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(334, 291);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Alfa Slab One", 8.999999F);
            label6.Location = new Point(468, 194);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 10;
            label6.Text = "Z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Alfa Slab One", 8.999999F);
            label5.Location = new Point(394, 194);
            label5.Name = "label5";
            label5.Size = new Size(26, 28);
            label5.TabIndex = 9;
            label5.Text = "Y";
            // 
            // txtEixoZ
            // 
            txtEixoZ.Location = new Point(449, 222);
            txtEixoZ.MaxLength = 7;
            txtEixoZ.Name = "txtEixoZ";
            txtEixoZ.Size = new Size(69, 32);
            txtEixoZ.TabIndex = 8;
            // 
            // txtEixoY
            // 
            txtEixoY.Location = new Point(374, 222);
            txtEixoY.MaxLength = 7;
            txtEixoY.Name = "txtEixoY";
            txtEixoY.Size = new Size(69, 32);
            txtEixoY.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Alfa Slab One", 8.999999F);
            label4.Location = new Point(322, 194);
            label4.Name = "label4";
            label4.Size = new Size(26, 28);
            label4.TabIndex = 6;
            label4.Text = "X";
            // 
            // txtEixoX
            // 
            txtEixoX.Location = new Point(299, 222);
            txtEixoX.MaxLength = 7;
            txtEixoX.Name = "txtEixoX";
            txtEixoX.Size = new Size(69, 32);
            txtEixoX.TabIndex = 5;
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(299, 150);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(214, 32);
            txtTamanho.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Alfa Slab One", 8.999999F);
            label3.Location = new Point(299, 122);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 3;
            label3.Text = "Tamanho ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Alfa Slab One", 8.999999F);
            label2.Location = new Point(299, 51);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(299, 79);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 32);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Alfa Slab One", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 38);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Peça";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informaçoes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 406);
            panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(786, 406);
            splitContainer1.SplitterDistance = 169;
            splitContainer1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Alfa Slab One", 8.999999F);
            label7.Location = new Point(305, 12);
            label7.Name = "label7";
            label7.Size = new Size(32, 28);
            label7.TabIndex = 3;
            label7.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 43);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 31);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(786, 233);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox txtTamanho;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEixoX;
        private Label label6;
        private Label label5;
        private TextBox txtEixoZ;
        private TextBox txtEixoY;
        private Label label4;
        private Button button1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private Label label7;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
