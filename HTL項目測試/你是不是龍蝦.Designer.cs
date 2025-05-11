namespace HTL項目測試
{
    partial class 你是不是龍蝦
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(你是不是龍蝦));
            label1 = new Label();
            byes = new Button();
            bno = new Button();
            lobtime = new System.Windows.Forms.Timer(components);
            lobpic = new PictureBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)lobpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 105);
            label1.Name = "label1";
            label1.Size = new Size(148, 26);
            label1.TabIndex = 0;
            label1.Text = "你是不是龍蝦?";
            // 
            // byes
            // 
            byes.Location = new Point(84, 233);
            byes.Name = "byes";
            byes.Size = new Size(75, 23);
            byes.TabIndex = 1;
            byes.Text = "YES";
            byes.UseVisualStyleBackColor = true;
            byes.Click += byes_Click;
            // 
            // bno
            // 
            bno.Location = new Point(227, 233);
            bno.Name = "bno";
            bno.Size = new Size(75, 23);
            bno.TabIndex = 2;
            bno.Text = "NO";
            bno.UseVisualStyleBackColor = true;
            bno.Click += button2_Click;
            // 
            // lobtime
            // 
            lobtime.Interval = 1;
            lobtime.Tick += lobtime_Tick;
            // 
            // lobpic
            // 
            lobpic.Image = (Image)resources.GetObject("lobpic.Image");
            lobpic.Location = new Point(0, 0);
            lobpic.MaximumSize = new Size(400, 400);
            lobpic.MinimumSize = new Size(10, 10);
            lobpic.Name = "lobpic";
            lobpic.Size = new Size(10, 10);
            lobpic.SizeMode = PictureBoxSizeMode.Zoom;
            lobpic.TabIndex = 3;
            lobpic.TabStop = false;
            lobpic.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(297, 326);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 4;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // 你是不是龍蝦
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(384, 361);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(lobpic);
            Controls.Add(bno);
            Controls.Add(byes);
            Controls.Add(label1);
            Name = "你是不是龍蝦";
            Text = "你是不是龍蝦";
            ((System.ComponentModel.ISupportInitialize)lobpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button byes;
        private Button bno;
        private System.Windows.Forms.Timer lobtime;
        private PictureBox lobpic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}