using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace HTL項目測試
{
    public partial class 你是不是龍蝦 : Form
    {
        //
        private int maxSize = 350; // 最大尺寸
        private int growStep = 40; // 每次放大多少像素
        //
        private IWavePlayer waveOut;        // 播放裝置
        private AudioFileReader audioFile;  // 音檔讀取器

        // 音樂檔案的相對路徑
        string path = "stuff\\Blobster.mp3";
        private bool userStopped = false;  // 音樂是否被用戶手動停止

        public 你是不是龍蝦()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lobpic.Visible = true;
            lobpic.Size = new Size(10, 10);
            lobtime.Start();
            PlayMp3AndExitAfterFinish(path);
        }

        private void lobtime_Tick(object sender, EventArgs e)
        {
            if (lobpic.Width < maxSize)
            {
                lobpic.Size = new Size(
                    lobpic.Width + growStep,
                    lobpic.Height + growStep
                );
                //lobpic.Left = (this.ClientSize.Width - lobpic.Width) / 2;
                //lobpic.Top = (this.ClientSize.Height - lobpic.Height) / 2;
            }
            else
            {
                lobtime.Stop();
            }
        }
        //
        private void PlayMp3AndExitAfterFinish(string filePath)
        {
            StopMp3(); // 確保之前的播放器被清除

            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);
            waveOut.Init(audioFile);

            // 音樂播放完畢時觸發事件
            userStopped = false; // 重設旗標
            waveOut.PlaybackStopped += (s, e) =>
            {
                if (!userStopped)
                {
                    Application.Exit(); // 音樂播放結束後退出程式
                }
            };

            waveOut.Play();
        }

        private void StopMp3()
        {
            if (waveOut != null)
            {
                userStopped = true;
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        private void byes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("喔，你好棒棒!");
        }
    }
}