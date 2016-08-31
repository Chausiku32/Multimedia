using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AudioLoopBack_NAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++ ) 
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            sourceList.Items.Clear();

            foreach(var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                sourceList.Items.Add(item);

            }

        }

        private NAudio.Wave.WaveIn sourceStream = null;

        private NAudio.Wave.DirectSoundOut waveOut = null;

        private NAudio.Wave.WaveFileWriter waveWriter = null;

        private void button2_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100,NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(waveIn);

            sourceStream.StartRecording();
            waveOut.Play();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "WAV File (*.wav)|*.wav;";
            if(save.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
        }

        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if(sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            
            if(waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3_Click(sender,e);
            this.Close();
        }

        

    }
}
