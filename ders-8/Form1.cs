using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable ogrenciTablosu;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciTablosu = new DataTable();
            ogrenciTablosu.Columns.Add("Öğrenci Adı", typeof(String));
            ogrenciTablosu.Columns.Add("Öğrenci Soyadı", typeof(String));
            ogrenciTablosu.Columns.Add("Öğrenci Cinsiyeti", typeof(String));
            dataGridView1.DataSource = ogrenciTablosu;
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (ogrenciAdiText.Text.Length > 0 && ogrenciSoyadiText.Text.Length > 0 && ogrenciErkek.Checked || ogrenciKadin.Checked)
            {
                ogrenciTablosu.Rows.Add(ogrenciAdiText.Text, ogrenciSoyadiText.Text, (ogrenciErkek.Checked) ? ("Erkek") : ("Kadın"));
                MessageBox.Show("Öğrenci kaydı yapıldı!");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.");
            }
        }
    }
}
