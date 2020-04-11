﻿using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayAudio(Stream stream)
        {
            if (stream == null) return;

            var sound = new SoundPlayer(stream);
            sound.Play();
        }

        private void ProcessKeyPress(KeyPressEventArgs eventArgs, Stream audioStream)
        {
            var keyString = eventArgs.KeyChar.ToString();
            keyPressedLabel.Text = keyString;
            PlayAudio(audioStream);
            eventArgs.Handled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar < 48 || e.KeyChar > 58)
            //    return;

            switch (e.KeyChar)
            {
                case (char)49:
                    ProcessKeyPress(e, Properties.Resources.Beauty_and_the_Beast);
                    break;
                case (char)50:
                    ProcessKeyPress(e, Properties.Resources.Under_the_Sea);
                    break;
                case (char)51:
                    ProcessKeyPress(e, Properties.Resources.Let_It_Go);
                    break;
                case (char)48:
                case (char)52:
                case (char)53:
                case (char)54:
                case (char)55:
                case (char)56:
                case (char)57:
                case (char)58:
                default:
                    ProcessKeyPress(e, Properties.Resources.toot);
                    break;
            }
        }
    }
}
