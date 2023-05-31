using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelefonRehberr
{
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }


        // Sql Bağlantı
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-M8M86O5\\SQLEXPRESS;Initial Catalog=TelefonRehber;Integrated Security=True");
        // Sql Bağlantı

        // değişkenler
       public int secilen;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'telefonRehberDataSet.Table_Rehber' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            tablogüncelle();
            textboxid.Enabled = false;

        }

        void tablogüncelle()
        {
            this.table_RehberTableAdapter.Fill(this.telefonRehberDataSet.Table_Rehber);
        }



        public void buttonadd_Click(object sender, EventArgs e)
        {

     


            // Rehber Kişi Ekleme SQL Veritabanı veri gönderme .
            bağlantı.Open();

            SqlCommand addrehber = new SqlCommand("insert into Table_Rehber(Ad,Soyad,Telefon,Mail) values(@p1,@p2,@p3,@p4)", bağlantı);

            addrehber.Parameters.AddWithValue("@p1", textboxad.Text);
            addrehber.Parameters.AddWithValue("@p2", textboxsoyad.Text);
            addrehber.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            addrehber.Parameters.AddWithValue("@p4", textboxmail.Text);
            addrehber.ExecuteNonQuery();
            bağlantı.Close();

            // Rehber Kişi Ekleme SQL Veritabanı veri gönderme .
            MessageBox.Show("Kişi Rehbere Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablogüncelle();

        }


        void temizle()
        {
            textboxid.Text = "";
            textboxad.Text = "";
            textboxsoyad.Text = "";
            maskedTextBox1.Text = "";
            textboxmail.Text = "";
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             secilen = dataGridView1.SelectedCells[0].RowIndex;

            textboxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textboxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textboxsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textboxmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand deleteusser = new SqlCommand("Delete Table_Rehber  where id=@p1", bağlantı);
            deleteusser.Parameters.AddWithValue("@p1", textboxid.Text);
            deleteusser.ExecuteNonQuery();
            bağlantı.Close();


            MessageBox.Show("Kişi Rehberden Silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablogüncelle();
            temizle();

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            temizle();
         
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand updateform = new SqlCommand("Update Table_Rehber Set Ad=@p3 , Soyad=@p4,Telefon=@p5,Mail=@p6 where İd=@p2",bağlantı);
            updateform.Parameters.AddWithValue("@p2", textboxid.Text);
            updateform.Parameters.AddWithValue("@p3", textboxad.Text);
            updateform.Parameters.AddWithValue("@p4", textboxsoyad.Text);
            updateform.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            updateform.Parameters.AddWithValue("@p6", textboxmail.Text);
            updateform.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Kişi Bilgileri Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablogüncelle();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
