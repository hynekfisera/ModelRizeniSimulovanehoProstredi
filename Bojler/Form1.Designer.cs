namespace Bojler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            trackBarUmPrutok = new TrackBar();
            trackBarUmTeplota = new TrackBar();
            trackBarSpPrutok = new TrackBar();
            trackBarSpTeplota = new TrackBar();
            trackBarCas = new TrackBar();
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelUmPrutok = new Label();
            labelUmTeplota = new Label();
            labelSpPrutok = new Label();
            labelSpTeplota = new Label();
            labelTeplota = new Label();
            labelSpotrebaW = new Label();
            labelSpotrebaL = new Label();
            labelTrackCas = new Label();
            labelCas = new Label();
            pictureBox1 = new PictureBox();
            buttonVentil = new Button();
            label10 = new Label();
            label5 = new Label();
            buttonOhrev = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonAuto = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarUmPrutok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUmTeplota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpPrutok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpTeplota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarCas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBarUmPrutok
            // 
            trackBarUmPrutok.Location = new Point(15, 375);
            trackBarUmPrutok.Maximum = 15;
            trackBarUmPrutok.Name = "trackBarUmPrutok";
            trackBarUmPrutok.Size = new Size(104, 45);
            trackBarUmPrutok.TabIndex = 0;
            trackBarUmPrutok.Scroll += trackBarUmPrutok_Scroll;
            // 
            // trackBarUmTeplota
            // 
            trackBarUmTeplota.Location = new Point(125, 375);
            trackBarUmTeplota.Maximum = 70;
            trackBarUmTeplota.Minimum = 10;
            trackBarUmTeplota.Name = "trackBarUmTeplota";
            trackBarUmTeplota.Size = new Size(104, 45);
            trackBarUmTeplota.TabIndex = 1;
            trackBarUmTeplota.Value = 10;
            trackBarUmTeplota.Scroll += trackBarUmTeplota_Scroll;
            // 
            // trackBarSpPrutok
            // 
            trackBarSpPrutok.Location = new Point(301, 375);
            trackBarSpPrutok.Maximum = 30;
            trackBarSpPrutok.Name = "trackBarSpPrutok";
            trackBarSpPrutok.Size = new Size(104, 45);
            trackBarSpPrutok.TabIndex = 2;
            trackBarSpPrutok.Scroll += trackBarSpPrutok_Scroll;
            // 
            // trackBarSpTeplota
            // 
            trackBarSpTeplota.Location = new Point(411, 375);
            trackBarSpTeplota.Maximum = 70;
            trackBarSpTeplota.Minimum = 10;
            trackBarSpTeplota.Name = "trackBarSpTeplota";
            trackBarSpTeplota.Size = new Size(104, 45);
            trackBarSpTeplota.TabIndex = 3;
            trackBarSpTeplota.Value = 10;
            trackBarSpTeplota.Scroll += trackBarSpTeplota_Scroll;
            // 
            // trackBarCas
            // 
            trackBarCas.Location = new Point(93, 12);
            trackBarCas.Minimum = 1;
            trackBarCas.Name = "trackBarCas";
            trackBarCas.Size = new Size(104, 45);
            trackBarCas.TabIndex = 4;
            trackBarCas.Value = 1;
            trackBarCas.Scroll += trackBarCas_Scroll;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start/Stop";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 347);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 6;
            label1.Text = "Umyvadlo Průtok";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 347);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 7;
            label2.Text = "Umyvadlo Teplota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 347);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Sprcha Průtok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 347);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 9;
            label4.Text = "Sprcha Teplota";
            // 
            // labelUmPrutok
            // 
            labelUmPrutok.AutoSize = true;
            labelUmPrutok.Location = new Point(40, 419);
            labelUmPrutok.Name = "labelUmPrutok";
            labelUmPrutok.Size = new Size(38, 15);
            labelUmPrutok.TabIndex = 10;
            labelUmPrutok.Text = "label5";
            // 
            // labelUmTeplota
            // 
            labelUmTeplota.AutoSize = true;
            labelUmTeplota.Location = new Point(159, 419);
            labelUmTeplota.Name = "labelUmTeplota";
            labelUmTeplota.Size = new Size(38, 15);
            labelUmTeplota.TabIndex = 11;
            labelUmTeplota.Text = "label6";
            // 
            // labelSpPrutok
            // 
            labelSpPrutok.AutoSize = true;
            labelSpPrutok.Location = new Point(327, 423);
            labelSpPrutok.Name = "labelSpPrutok";
            labelSpPrutok.Size = new Size(38, 15);
            labelSpPrutok.TabIndex = 12;
            labelSpPrutok.Text = "label7";
            // 
            // labelSpTeplota
            // 
            labelSpTeplota.AutoSize = true;
            labelSpTeplota.Location = new Point(436, 423);
            labelSpTeplota.Name = "labelSpTeplota";
            labelSpTeplota.Size = new Size(38, 15);
            labelSpTeplota.TabIndex = 13;
            labelSpTeplota.Text = "label8";
            // 
            // labelTeplota
            // 
            labelTeplota.AutoSize = true;
            labelTeplota.Location = new Point(331, 97);
            labelTeplota.Name = "labelTeplota";
            labelTeplota.Size = new Size(38, 15);
            labelTeplota.TabIndex = 14;
            labelTeplota.Text = "label5";
            // 
            // labelSpotrebaW
            // 
            labelSpotrebaW.AutoSize = true;
            labelSpotrebaW.Location = new Point(331, 140);
            labelSpotrebaW.Name = "labelSpotrebaW";
            labelSpotrebaW.Size = new Size(38, 15);
            labelSpotrebaW.TabIndex = 15;
            labelSpotrebaW.Text = "label6";
            // 
            // labelSpotrebaL
            // 
            labelSpotrebaL.AutoSize = true;
            labelSpotrebaL.Location = new Point(331, 182);
            labelSpotrebaL.Name = "labelSpotrebaL";
            labelSpotrebaL.Size = new Size(38, 15);
            labelSpotrebaL.TabIndex = 16;
            labelSpotrebaL.Text = "label7";
            // 
            // labelTrackCas
            // 
            labelTrackCas.AutoSize = true;
            labelTrackCas.Location = new Point(203, 16);
            labelTrackCas.Name = "labelTrackCas";
            labelTrackCas.Size = new Size(38, 15);
            labelTrackCas.TabIndex = 17;
            labelTrackCas.Text = "label8";
            // 
            // labelCas
            // 
            labelCas.AutoSize = true;
            labelCas.Location = new Point(331, 16);
            labelCas.Name = "labelCas";
            labelCas.Size = new Size(13, 15);
            labelCas.TabIndex = 18;
            labelCas.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(93, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 201);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // buttonVentil
            // 
            buttonVentil.Location = new Point(436, 239);
            buttonVentil.Name = "buttonVentil";
            buttonVentil.Size = new Size(75, 23);
            buttonVentil.TabIndex = 20;
            buttonVentil.Text = "On/Off";
            buttonVentil.UseVisualStyleBackColor = true;
            buttonVentil.Click += buttonVentil_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(327, 243);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 21;
            label10.Text = "Ventil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 279);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 22;
            label5.Text = "Ohřev";
            // 
            // buttonOhrev
            // 
            buttonOhrev.Enabled = false;
            buttonOhrev.Location = new Point(436, 279);
            buttonOhrev.Name = "buttonOhrev";
            buttonOhrev.Size = new Size(75, 23);
            buttonOhrev.TabIndex = 23;
            buttonOhrev.Text = "On/Off";
            buttonOhrev.UseVisualStyleBackColor = true;
            buttonOhrev.Click += buttonOhrev_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonAuto
            // 
            buttonAuto.Location = new Point(436, 304);
            buttonAuto.Name = "buttonAuto";
            buttonAuto.Size = new Size(75, 23);
            buttonAuto.TabIndex = 24;
            buttonAuto.Text = "On/Off";
            buttonAuto.UseVisualStyleBackColor = true;
            buttonAuto.Click += buttonAuto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 308);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 25;
            label6.Text = "Automat/Manuál";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(buttonAuto);
            Controls.Add(buttonOhrev);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(buttonVentil);
            Controls.Add(pictureBox1);
            Controls.Add(labelCas);
            Controls.Add(labelTrackCas);
            Controls.Add(labelSpotrebaL);
            Controls.Add(labelSpotrebaW);
            Controls.Add(labelTeplota);
            Controls.Add(labelSpTeplota);
            Controls.Add(labelSpPrutok);
            Controls.Add(labelUmTeplota);
            Controls.Add(labelUmPrutok);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Controls.Add(trackBarCas);
            Controls.Add(trackBarSpTeplota);
            Controls.Add(trackBarSpPrutok);
            Controls.Add(trackBarUmTeplota);
            Controls.Add(trackBarUmPrutok);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarUmPrutok).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUmTeplota).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpPrutok).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpTeplota).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarCas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarUmPrutok;
        private TrackBar trackBarUmTeplota;
        private TrackBar trackBarSpPrutok;
        private TrackBar trackBarSpTeplota;
        private TrackBar trackBarCas;
        private Button buttonStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelUmPrutok;
        private Label labelUmTeplota;
        private Label labelSpPrutok;
        private Label labelSpTeplota;
        private Label labelTeplota;
        private Label labelSpotrebaW;
        private Label labelSpotrebaL;
        private Label labelTrackCas;
        private Label labelCas;
        private PictureBox pictureBox1;
        private Button buttonVentil;
        private Label label10;
        private Label label5;
        private Button buttonOhrev;
        private System.Windows.Forms.Timer timer1;
        private Button buttonAuto;
        private Label label6;
    }
}