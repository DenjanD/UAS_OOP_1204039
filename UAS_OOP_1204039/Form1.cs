namespace UAS_OOP_1204039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputMahasiswa inputMahasiswa = new InputMahasiswa();
            inputMahasiswa.MdiParent = this;
            inputMahasiswa.Show();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputProdi inputProdi = new InputProdi();
            inputProdi.MdiParent = this;
            inputProdi.Show();
        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputDaftarUlang inputDaftarUlang = new InputDaftarUlang();
            inputDaftarUlang.MdiParent = this;
            inputDaftarUlang.Show();
        }

        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewMahasiswa viewMahasiswa = new ViewMahasiswa();
            viewMahasiswa.MdiParent = this;
            viewMahasiswa.Show();
        }

        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProdi viewProdi = new ViewProdi();
            viewProdi.MdiParent = this;
            viewProdi.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTransaksi viewTransaksi = new ViewTransaksi();
            viewTransaksi.MdiParent = this;
            viewTransaksi.Show();
        }

        private void mahasiswaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateMahasiswa updateMahasiswa = new UpdateMahasiswa();
            updateMahasiswa.MdiParent = this;
            updateMahasiswa.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateTransaksi updateTransaksi = new UpdateTransaksi();
            updateTransaksi.MdiParent = this;
            updateTransaksi.Show();
        }

        private void prodiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateProdi updateProdi = new UpdateProdi();
            updateProdi.MdiParent = this;
            updateProdi.Show();
        }
    }
}