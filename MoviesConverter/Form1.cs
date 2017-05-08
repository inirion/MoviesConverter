using System;
using System.Windows.Forms;

namespace MoviesConverter
{
    public partial class Form1 : Form
    {
        private Converter convert;
        public Form1()
        {
            InitializeComponent();
            convert = new Converter();
        }

        private void SelectInputFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Videos Files |*.avi; *.mp4; *.mpg;";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                convert.InputFile = openFileDialog1.FileName.ToString();
                FilePath.Text = convert.InputFile;
            }
            
        }

        private void SelectOutputFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Videos Files |*.avi; *.mp4; *.mpg;";
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                convert.OutputFile = saveFileDialog1.FileName.ToString();
                SaveFileTB.Text = convert.OutputFile;
            }
        }


        private void vlcPathBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Executable Files |*.exe;";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                convert.vlcPath = openFileDialog1.FileName.ToString();
                VlcPathTB.Text = convert.vlcPath;
            }
            
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                convert.AudioCodec = AudioComboBox.Text;
                convert.VideoCoded = ImageComboBox.Text;
                convert.AudioFlow = Int32.Parse(AudioFlowTB.Text);
                convert.ImageFlow = Int32.Parse(ImageFlowTB.Text);
                convert.ImageWidth = Int32.Parse(WidthTB.Text);
                convert.ImageHeight = Int32.Parse(HeightTB.Text);
                convert.Fps = Int32.Parse(FpsTB.Text);
                ResultTB.Text = "Compressed: " + convert.execute().ToString()+ "bytes";
            }
            catch (Exception ee){
                MessageBox.Show("All fields must be filled which positive integer", "Warning",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

    }
}
