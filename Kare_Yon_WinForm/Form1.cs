namespace Kare_Yon_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KontrolEt()
        {
            if (btnHareket.Bounds.IntersectsWith(ustLabel.Bounds))
                btnHareket.Top += 50;
            else if (btnHareket.Bounds.IntersectsWith(altLabel.Bounds))
                btnHareket.Top -= 50;
            else if (btnHareket.Bounds.IntersectsWith(solLabel.Bounds))
                btnHareket.Left += 50;
            else if (btnHareket.Bounds.IntersectsWith(sagLabel.Bounds))
                btnHareket.Left -= 50;
        }

        private void btnYukari_Click_1(object sender, EventArgs e)
        {
            btnHareket.Location = new Point(btnHareket.Location.X, btnHareket.Location.Y - 10);
            KontrolEt();
        }

        private void btnAsagi_Click_1(object sender, EventArgs e)
        {
            btnHareket.Location = new Point(btnHareket.Location.X, btnHareket.Location.Y + 10);
            KontrolEt();
        }

        private void btnSol_Click_1(object sender, EventArgs e)
        {
            btnHareket.Location = new Point(btnHareket.Location.X - 10, btnHareket.Location.Y);
            KontrolEt();
        }

        private void btnSag_Click_1(object sender, EventArgs e)
        {
            btnHareket.Location = new Point(btnHareket.Location.X + 10, btnHareket.Location.Y);
            KontrolEt();
        }
    }
}