using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace BetaMart
{
    public partial class Form1 : Form
    {
        private string id = "";
        private int row = 0;

        public Form1()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = "";
            tbNama.Text = "";
            tbStok.Text = "";
            tbHarga.Text = "";

            btUpdate.Text = "Update";
            btDelete.Text = "Delete";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new OleDbCommand(mySQL, CRUD.con);
            AddParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void AddParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();

            if (str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue(id, this.id);
            }

            CRUD.cmd.Parameters.AddWithValue("Nama Barang", tbNama.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Stok Barang", tbStok.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Harga Barang", tbHarga.Text.Trim());

            if (str == "Update" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue(id, this.id);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNama.Text.Trim()) ||
                string.IsNullOrEmpty(tbStok.Text.Trim()) ||
                string.IsNullOrEmpty(tbHarga.Text.Trim()))
            {
                MessageBox.Show("Tolong Masukkan Data", "BetaMart Insert",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "INSERT INTO tb_barang(Nama_Barang, Stok_Barang, Harga_Jual) VALUES(@nama, @stok, @harga)";
            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data Berhasil Disimpan", "BetaMart Insert",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
        }

        private void loadData(string keyword)
        {
            CRUD.sql = "SELECT * FROM tb_barang ORDER BY ID_Barang ASC";
            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("keyword1", strKeyword);
            CRUD.cmd.Parameters.AddWithValue("keyword2", keyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Number of row(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Nama Barang";
            dgv.Columns[2].HeaderText = "Stok Barang";
            dgv.Columns[3].HeaderText = "Harga Barang";

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 200;
            dgv.Columns[2].Width = 141;
            dgv.Columns[3].Width = 140;

        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;

                this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                btUpdate.Text = "Update (" + this.id + ")";
                btDelete.Text = "Delete (" + this.id + ")";

                tbNama.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value).Trim();
                tbStok.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value).Trim();
                tbHarga.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value).Trim();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Tolong Pilih List Barang Yang Akan Di Update.",
                    "BetaMart Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tbNama.Text.Trim()) ||
               string.IsNullOrEmpty(tbStok.Text.Trim()) ||
               string.IsNullOrEmpty(tbHarga.Text.Trim()))
            {
                MessageBox.Show("Tolong Masukkan Data Barang.",
                    "BetaMart Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }   
            
            CRUD.sql = "UPDATE tb_barang set Nama_Barang = @nama, Stok_Barang = @stok, Harga_Jual = @harga WHERE ID_Barang = @id";
            execute(CRUD.sql, "Update");

            MessageBox.Show("Data Berhasil Disimpan", "BetaMart Update",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Tolong Pilih List Barang Yang Akan Di Hapus.",
                    "BetaMart Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Barang Ini?", "BetaMart Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM tb_barang WHERE ID_Barang = @id";
                execute(CRUD.sql, "Delete");

                MessageBox.Show("Data Berhasil Terhapus", "BetaMart Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");
                resetMe();
            }
            

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            resetMe();
        }
    }
}

