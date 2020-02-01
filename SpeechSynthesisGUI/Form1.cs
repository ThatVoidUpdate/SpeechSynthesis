using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpeechSynthesisGUI
{
    public partial class Form1 : Form
    {
        public List<InstalledVoice> InstalledVoices;

        public SpeechSynthesizer synth = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            InstalledVoices = synth.GetInstalledVoices().ToList<InstalledVoice>();


            foreach (InstalledVoice voice in InstalledVoices)
            {
                lbx_AllVoices.Items.Add(voice.VoiceInfo.Name);
            }

            lbx_AllVoices.SelectedIndex = 0;

        }
            

        private void lbx_AllVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoiceInfo info = InstalledVoices[lbx_AllVoices.SelectedIndex].VoiceInfo;
            lbl_VoiceInfo.Text = "Name: " + info.Name + "\nGender: " + info.Gender + "\nAge: " + info.Age; 
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice(InstalledVoices[lbx_AllVoices.SelectedIndex].VoiceInfo.Name);
            synth.SpeakAsync(tbx_InputText.Text);
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            synth.SetOutputToWaveFile(sfd_WAVOutput.FileName);
            synth.SpeakAsync(tbx_InputText.Text);
        }

        private void btn_OpenFileDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = sfd_WAVOutput.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbl_Path.Text = sfd_WAVOutput.FileName;
            }
        }
    }
}
