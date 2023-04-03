using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Week5
{
    public partial class Form1 : Form
    {
        DataTable simpanproduk = new DataTable();
        DataTable category = new DataTable();
        DataTable tampilproduk = new DataTable();
        List<string> id = new List<string>() { "J001", "T001", "K001", "K002", "R001", "J002", "C001", "S001" };
        List<string> barang = new List<string>() { "Jas Hitam", "T-Shirt", "Kemeja Hitam", "Kemeja Putih", "Rok Mini", "Jeans Hitam", "Celana Pendek Hitam", "Sweater Hitam" };
        List<string> harga = new List<string>() { "1000000", "200000", "400000", "400000", "100000", "500000", "150000", "250000" };
        List<string> stock = new List<string>() { "10", "20", "10", "10", "7", "5", "10", "5" };
        List<string> ktgr = new List<string>() { "C1", "C2", "C3", "C3", "C4", "C5", "C6", "C7" };
        List<string> idktgr = new List<string>() { "C1", "C2", "C3", "C4", "C5", "C6", "C7" };
        List<string> namaktgr = new List<string>() { "Jas", "T-Shirt", "Kemeja", "Rok", "Jeans", "Celana", "Sweater" };
        int cek = 0;
        int c = 0;
        int nampung = 0;
        int n = 0;
        int edit = 0;
        string hapus = "";
        string idbaru = "";
        string idbarang = "";
        string idkategori = "";
        string simpenkategori = "";
        string simpenbarang = "";

        public Form1()
        {
            InitializeComponent();
        }
        public void updatekategori()
        {
            for (int x = 0; x < namaktgr.Count; x++)
            {
                category.Rows.Add(idktgr[x], namaktgr[x]);
            }
            datacategory.DataSource = category;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            simpenkategori = datacategory.SelectedCells[0].Value.ToString();
            namakategori.Text = datacategory.SelectedCells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpanproduk.Columns.Add("Product ID");
            simpanproduk.Columns.Add("Product Name");
            simpanproduk.Columns.Add("Price");
            simpanproduk.Columns.Add("Stock");
            simpanproduk.Columns.Add("Category ID");
            dataproduk.DataSource = simpanproduk;
            for (int x = 0; x < barang.Count; x++)
            {
                simpanproduk.Rows.Add(id[x], barang[x], harga[x], stock[x], ktgr[x]);
            }
            dataproduk.DataSource = simpanproduk;

            category.Columns.Add("Category ID");
            category.Columns.Add("Category Name");
            datacategory.DataSource = category;
            updatekategori();
            foreach (string a in namaktgr)
            {
                cb_list.Items.Add(a);
                cb_category.Items.Add(a);
            }

            tampilproduk = simpanproduk.Copy();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_list.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_list.Enabled = false;
            cb_list.Text = null;
            dataproduk.DataSource = simpanproduk;
        }

        private void dataproduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hapus = dataproduk.SelectedCells[0].Value.ToString();
            nama.Text = dataproduk.SelectedCells[1].Value.ToString();
            simpenbarang = dataproduk.SelectedCells[4].Value.ToString();
            foreach (DataRow a in category.Rows)
            {
                if (a[0].ToString() == simpenbarang)
                {
                    datacategory.Text = a[1].ToString();
                    break;
                }
            }
            dataharga.Text = dataproduk.SelectedCells[2].Value.ToString();
            datastock.Text = dataproduk.SelectedCells[3].Value.ToString();
        }

        private void cb_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tampilproduk.Rows.Clear();
            foreach (DataRow a in category.Rows)
            {
                if (a[1] == cb_list.SelectedItem.ToString())
                {
                    foreach (DataRow b in simpanproduk.Rows)
                    {
                        if (a[0] == b[4])
                        {
                            tampilproduk.Rows.Add(b[0], b[1], b[2], b[3], b[4]);
                        }
                    }
                }
            }
            dataproduk.DataSource = tampilproduk;
        }

        private void tambah_category_Click(object sender, EventArgs e)
        {
            cek = 0;
            if (namakategori.Text == "")
            {
                MessageBox.Show("Error please input category name first");
            }
            else
            {
                foreach (DataRow a in category.Rows)
                {
                    c = Convert.ToInt32(a[0].ToString().Substring(1));
                    if (c >= nampung)
                    {
                        nampung = c;
                    }
                }
                idbaru = "C" + (nampung + 1);
                foreach (DataRow b in category.Rows)
                {
                    if (namakategori.Text == b[1].ToString())
                    {
                        cek = 1;
                    }

                }
                if (cek == 1)
                {
                    MessageBox.Show("Error category name is already exist");
                }
                else
                {
                    category.Rows.Add(idbaru, namakategori.Text);
                    cb_list.Items.Add(namakategori.Text);
                    cb_category.Items.Add(namakategori.Text);
                }
                namakategori.Text = null;
            }
        }

        private void dataharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void datastock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            if (nama.Text == "" || cb_category.SelectedItem.ToString() == "" || dataharga.Text == "" || datastock.Text == "")
            {
                MessageBox.Show("Error please input the textbox");
            }
            else
            {
                foreach (DataRow a in simpanproduk.Rows)
                {
                    if (nama.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                    {
                        c = Convert.ToInt32(a[0].ToString().Substring(1));
                        if (c >= n)
                        {
                            n = c;
                        }
                    }
                }
                n += 1;
                idbarang = nama.Text[0].ToString().ToUpper();
                for (int i = n.ToString().Length; i < 3; i++)
                {
                    idbarang += "0";
                }
                idbarang += Convert.ToString(n);
                foreach (DataRow b in category.Rows)
                {
                    if (b[1].ToString() == cb_category.SelectedItem.ToString())
                    {
                        idkategori = b[0].ToString();
                    }
                }
                simpanproduk.Rows.Add(idbarang, nama.Text, dataharga.Text, datastock.Text, idkategori);
                nama.Text = null; dataharga.Text = null; datastock.Text = null; cb_category.Text = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             cb_list.Items.Remove(datacategory.SelectedCells[1].Value.ToString());
            cb_category.Items.Remove(datacategory.SelectedCells[1].Value.ToString());
            foreach (DataRow a in category.Rows)
            {
                if (a[0].ToString() == simpenkategori)
                {
                    category.Rows.Remove(a);
                    break;
                }
            }       
            namakategori.Text = null;
            for (int x = simpanproduk.Rows.Count - 1; x >= 0; x--)
            {
                if (simpanproduk.Rows[x][4].ToString() == simpenkategori)
                {
                    simpanproduk.Rows.RemoveAt(x);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nama.Text == "" || cb_category.SelectedItem.ToString() == "" || dataharga.Text == "" || datastock.Text == "")
            {
                MessageBox.Show("Error please input the textbox");
            }
            else
            {
                edit = dataproduk.SelectedRows[0].Index;
                if (datastock.Text == "0")
                {
                    simpanproduk.Rows.RemoveAt(edit);
                }
                else
                {
                    n = 0;
                    foreach (DataRow a in simpanproduk.Rows)
                    {
                        if (nama.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                        {
                            c = Convert.ToInt32(a[0].ToString().Substring(1));
                            if (c >= n)
                            {
                                n = c;
                            }
                        }
                    }
                    n += 1;
                    idbarang = nama.Text[0].ToString().ToUpper();
                    for (int i = n.ToString().Length; i < 3; i++)
                    {
                        idbarang += "0";
                    }
                    idbarang += Convert.ToString(n);
                    simpanproduk.Rows[edit][0] = idbarang;
                    simpanproduk.Rows[edit][1] = nama.Text;
                    simpanproduk.Rows[edit][2] = dataharga.Text;
                    simpanproduk.Rows[edit][3] = datastock.Text;
                    foreach (DataRow a in category.Rows)
                    {
                        if (a[1].ToString() == cb_category.Text)
                        {
                            simpanproduk.Rows[edit][4] = a[0].ToString();
                            break;
                        }
                    }
                }
            }
            nama.Text = null; dataharga.Text = null; datastock.Text = null; cb_category.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataRow a in simpanproduk.Rows)
            {
                if (hapus == a[0].ToString())
                {
                    simpanproduk.Rows.Remove(a);
                    break;
                }
            }
            nama.Text = null; dataharga.Text = null; datastock.Text = null; cb_category.Text = null;
        }
    }
}
