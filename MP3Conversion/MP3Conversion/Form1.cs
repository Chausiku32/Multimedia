using System;
using System.Windows.Forms;

namespace MP3Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 File (*.mp3)|*.mp3;";
            if (open.ShowDialog() != DialogResult.OK) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "WAV File (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;

            using (NAudio.Wave.Mp3FileReader mp3 = new NAudio.Wave.Mp3FileReader(open.FileName))
            {
                using (NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    NAudio.Wave.WaveFileWriter.CreateWaveFile(save.FileName, pcm);
                }
            }
        }
    }
}
