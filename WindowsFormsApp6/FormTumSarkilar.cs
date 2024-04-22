using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp6
{
    public partial class FormTumSarkilar : Form
    {
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=;";
        public FormTumSarkilar()
        {
            InitializeComponent();
        }

        private void FormTumSarkilar_Load(object sender, EventArgs e)
        {

            DgwDoldur();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwSarkilar.SelectedRows[0];
            int satirId = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Şarkıyı Silmek İstediğinizden Emin Misiniz?",
                                "Şarkı Sil",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error);

            if(cevap == DialogResult.Yes )
            {

                string sorgu = "DELETE FROM sarkilar where id = @satirid;";

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@satirid", satirId);
                    cmd.ExecuteNonQuery();

                    DgwDoldur(); //tekrar doldurur
                }


            }
        }

        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM sarkilar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
              

                da.Fill(dt);
                dgwSarkilar.DataSource = dt;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE sarkilar SET ad =@sarkiad, sanatci=@sanatciad, yil=@yil, tur=@tur, sure=@sure, eklenme_tarihi=@tarih, favori=@favori  WHERE id = @satirid;";
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@sarkiad", txtSarki.Text);
                cmd.Parameters.AddWithValue("@sanatciad", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                cmd.Parameters.AddWithValue("@tarih", dtTarih.Value);
                cmd.Parameters.AddWithValue("@favori", cbFavori.Checked);
            }

        }
    }
}
