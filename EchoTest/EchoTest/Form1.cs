using System;
using System.Windows.Forms;

namespace EchoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NAudio.Wave.WaveFileReader wave = null;
        
        private NAudio.Wave.DirectSoundOut output = null;

        private NAudio.Wave.BlockAlignReductionStream stream = null;



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeWave();

            wave = new NAudio.Wave.WaveFileReader(open.FileName);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(wave));
            output.Play();

            pauseButton.Enabled = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if(output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();

                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();


            }
        }

        public void DisposeWave()
        { 
            if(output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }

            if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }

            if(stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 File (*.mp3)|*.mp3;";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeWave();

            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
            pauseMP3Button.Enabled = true;
        }

        private void pauseMP3Button_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();

                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();

            }
        }
    }
}
