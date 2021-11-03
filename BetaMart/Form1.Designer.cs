
namespace BetaMart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 121);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Barang BetaMart";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(574, 237);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga Barang";
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.Color.Lavender;
            this.tbNama.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(108, 133);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(136, 21);
            this.tbNama.TabIndex = 5;
            // 
            // tbStok
            // 
            this.tbStok.BackColor = System.Drawing.Color.Lavender;
            this.tbStok.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStok.Location = new System.Drawing.Point(108, 166);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(136, 21);
            this.tbStok.TabIndex = 6;
            // 
            // tbHarga
            // 
            this.tbHarga.BackColor = System.Drawing.Color.Lavender;
            this.tbHarga.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(108, 202);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(136, 21);
            this.tbHarga.TabIndex = 7;
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Lime;
            this.btInsert.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(15, 239);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(77, 29);
            this.btInsert.TabIndex = 8;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(108, 239);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(80, 29);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(509, 239);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(92, 33);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "Number Of Row(s) :";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Fuchsia;
            this.btReset.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(208, 239);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(80, 29);
            this.btReset.TabIndex = 12;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(628, 569);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

