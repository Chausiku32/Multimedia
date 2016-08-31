using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Matilda
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer sr = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            say();
        }

        public void say() 
        {
            sr.Speak("hello brian");
            
        }


    }
}
