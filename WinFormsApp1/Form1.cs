using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class ROMifier : Form
    {


        public string selectedFileName1;
        public string selectedROMName1;
        public int imageNumber = 1;




        public ROMifier()
        {
            InitializeComponent();

            materialRecoverBoot.Enabled = false;
            materialROMflash.Enabled = false;
            materialNext.Enabled = false;  // Next Image
            materialBack.Enabled = false;  // Back Image
            materialROMpath.Enabled = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;





        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void materialRecoverSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Recovery files (*.img)|*.img";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //...
                System.Windows.Forms.MessageBox.Show("Files found: " + selectedFileName.ToString(), "Message");

                materialRecoverBoot.Enabled = true;

                selectedFileName1 = selectedFileName;
                label8.Text = Path.GetFileName(selectedFileName);

            }
        }

        private void materialRecoverBoot_Click(object sender, EventArgs e)
        {

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/c fastboot boot " + selectedFileName1;
            Process.Start(ps);

            materialNext.Enabled = true;  // Next Image


        }

        private void materialROMpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "ROM Zip files (*.zip)|*.zip";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedROMName = openFileDialog1.FileName;
                //...
                System.Windows.Forms.MessageBox.Show("Files found: " + selectedROMName.ToString(), "Message");

                materialROMflash.Enabled = true;

                selectedROMName1 = selectedROMName;

                label7.Text = Path.GetFileName(selectedROMName1);


                
            }
        }

        private void materialROMflash_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/c adb sideload " + selectedROMName1;
            Process.Start(ps);


        }

        private void materialBack_Click(object sender, EventArgs e)
        {
            imageNumber--;

            if (imageNumber == 6)
            {
                materialNext.Enabled = false;
                materialROMpath.Enabled = true;
            }

            switch (imageNumber)
            {

                case 1:
                    materialBack.Enabled = false;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 1:";

                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;

                case 2:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 2:";

                    pictureBox1.Visible = false; ;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;
                case 3:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 3:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;
                case 4:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 4:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;
                case 5:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 5:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;

                    break;
                case 6:
                    materialBack.Enabled = true;
                    materialNext.Enabled = false;
                    materialROMpath.Enabled = true;
                    label9.Text = "Final Step:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;

                    break;
            }
        }

        private void materialNext_Click(object sender, EventArgs e)
        {
            imageNumber++;

            if (imageNumber == 6)
            {
                materialNext.Enabled = false;
                materialROMpath.Enabled = true;
            }

            switch (imageNumber)
            {

                case 1:
                    materialBack.Enabled = false;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 1:";

                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;

                case 2:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 2:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;
                case 3:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 3:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;
                case 4:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 4:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                    break;
                case 5:
                    materialBack.Enabled = true;
                    materialNext.Enabled = true;
                    materialROMpath.Enabled = false;
                    label9.Text = "Step 5:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;

                    break;
                case 6:
                    materialBack.Enabled = true;
                    materialNext.Enabled = false;
                    materialROMpath.Enabled = true;
                    label9.Text = "Final Step:";

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;

                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var uri = "https://github.com/Arinautic/ROMifier";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var uri = "https://www.paypal.com/donate/?hosted_button_id=TFFXQE5E4XE28";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/k fastboot devices";
            Process.Start(ps);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/k fastboot devices";
            Process.Start(ps);

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/k adb devices";
            Process.Start(ps);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/k adb devices";
            Process.Start(ps);
        }
    }
}