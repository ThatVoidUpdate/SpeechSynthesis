namespace SpeechSynthesisGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_AllVoices = new System.Windows.Forms.ListBox();
            this.lbl_AvailableVoices = new System.Windows.Forms.Label();
            this.pnl_VoiceInfo = new System.Windows.Forms.Panel();
            this.lbl_VoiceInfo = new System.Windows.Forms.Label();
            this.tbx_InputText = new System.Windows.Forms.TextBox();
            this.lbl_TextInput = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_OpenFileDialog = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.sfd_WAVOutput = new System.Windows.Forms.SaveFileDialog();
            this.pnl_VoiceInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_AllVoices
            // 
            this.lbx_AllVoices.FormattingEnabled = true;
            this.lbx_AllVoices.Location = new System.Drawing.Point(12, 25);
            this.lbx_AllVoices.Name = "lbx_AllVoices";
            this.lbx_AllVoices.Size = new System.Drawing.Size(174, 186);
            this.lbx_AllVoices.TabIndex = 0;
            this.lbx_AllVoices.SelectedIndexChanged += new System.EventHandler(this.lbx_AllVoices_SelectedIndexChanged);
            // 
            // lbl_AvailableVoices
            // 
            this.lbl_AvailableVoices.AutoSize = true;
            this.lbl_AvailableVoices.Location = new System.Drawing.Point(12, 9);
            this.lbl_AvailableVoices.Name = "lbl_AvailableVoices";
            this.lbl_AvailableVoices.Size = new System.Drawing.Size(85, 13);
            this.lbl_AvailableVoices.TabIndex = 1;
            this.lbl_AvailableVoices.Text = "Available Voices";
            // 
            // pnl_VoiceInfo
            // 
            this.pnl_VoiceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_VoiceInfo.Controls.Add(this.lbl_VoiceInfo);
            this.pnl_VoiceInfo.Location = new System.Drawing.Point(12, 218);
            this.pnl_VoiceInfo.Name = "pnl_VoiceInfo";
            this.pnl_VoiceInfo.Size = new System.Drawing.Size(174, 220);
            this.pnl_VoiceInfo.TabIndex = 2;
            // 
            // lbl_VoiceInfo
            // 
            this.lbl_VoiceInfo.AutoSize = true;
            this.lbl_VoiceInfo.Location = new System.Drawing.Point(4, 4);
            this.lbl_VoiceInfo.Name = "lbl_VoiceInfo";
            this.lbl_VoiceInfo.Size = new System.Drawing.Size(0, 13);
            this.lbl_VoiceInfo.TabIndex = 0;
            // 
            // tbx_InputText
            // 
            this.tbx_InputText.Location = new System.Drawing.Point(192, 25);
            this.tbx_InputText.Multiline = true;
            this.tbx_InputText.Name = "tbx_InputText";
            this.tbx_InputText.Size = new System.Drawing.Size(162, 186);
            this.tbx_InputText.TabIndex = 3;
            // 
            // lbl_TextInput
            // 
            this.lbl_TextInput.AutoSize = true;
            this.lbl_TextInput.Location = new System.Drawing.Point(192, 8);
            this.lbl_TextInput.Name = "lbl_TextInput";
            this.lbl_TextInput.Size = new System.Drawing.Size(55, 13);
            this.lbl_TextInput.TabIndex = 4;
            this.lbl_TextInput.Text = "Input Text";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(195, 224);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(159, 23);
            this.btn_Preview.TabIndex = 5;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Location = new System.Drawing.Point(3, 5);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(0, 13);
            this.lbl_Path.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_OpenFileDialog);
            this.panel1.Controls.Add(this.lbl_Path);
            this.panel1.Location = new System.Drawing.Point(195, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 22);
            this.panel1.TabIndex = 7;
            // 
            // btn_OpenFileDialog
            // 
            this.btn_OpenFileDialog.Location = new System.Drawing.Point(122, 0);
            this.btn_OpenFileDialog.Name = "btn_OpenFileDialog";
            this.btn_OpenFileDialog.Size = new System.Drawing.Size(37, 23);
            this.btn_OpenFileDialog.TabIndex = 0;
            this.btn_OpenFileDialog.Text = "...";
            this.btn_OpenFileDialog.UseVisualStyleBackColor = true;
            this.btn_OpenFileDialog.Click += new System.EventHandler(this.btn_OpenFileDialog_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(195, 282);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(159, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save WAV";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.lbl_TextInput);
            this.Controls.Add(this.tbx_InputText);
            this.Controls.Add(this.pnl_VoiceInfo);
            this.Controls.Add(this.lbl_AvailableVoices);
            this.Controls.Add(this.lbx_AllVoices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_VoiceInfo.ResumeLayout(false);
            this.pnl_VoiceInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_AllVoices;
        private System.Windows.Forms.Label lbl_AvailableVoices;
        private System.Windows.Forms.Panel pnl_VoiceInfo;
        private System.Windows.Forms.Label lbl_VoiceInfo;
        private System.Windows.Forms.TextBox tbx_InputText;
        private System.Windows.Forms.Label lbl_TextInput;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_OpenFileDialog;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.SaveFileDialog sfd_WAVOutput;
    }
}

