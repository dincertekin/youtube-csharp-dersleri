namespace csharpforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiText. Text == "dincer")
            {
                if (parolaText.Text == "123456")
                {
                    MessageBox.Show("Başarıyla giriş yaptınız!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form form2 = new Form2();
                    form2.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Hatalı bir şifre girdiniz! Lütfen kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Hatalı bir kullanıcı adı girdiniz! Lütfen kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
