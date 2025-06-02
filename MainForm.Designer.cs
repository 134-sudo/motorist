using System.Drawing;

namespace motorist
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            saveBtn = new Button();
            pictureBoxLogo = new PictureBox();
            contracts = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(11, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(861, 415);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Times New Roman", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 27);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(121, 2, 2);
            saveBtn.Font = new Font("Times New Roman", 10.2F);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(878, 175);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(188, 48);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(878, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(188, 103);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // contracts
            // 
            contracts.BackColor = Color.FromArgb(121, 2, 2);
            contracts.Font = new Font("Times New Roman", 10.2F);
            contracts.ForeColor = Color.White;
            contracts.Location = new Point(878, 121);
            contracts.Name = "contracts";
            contracts.Size = new Size(188, 48);
            contracts.TabIndex = 6;
            contracts.Text = "Договора";
            contracts.UseVisualStyleBackColor = false;
            contracts.Click += goods_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 472);
            Controls.Add(contracts);
            Controls.Add(pictureBoxLogo);
            Controls.Add(saveBtn);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Главная";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Button contracts;
    }
}
