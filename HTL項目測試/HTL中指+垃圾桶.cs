namespace HTL項目測試
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = e.Location; // 記錄滑鼠在圖上的位置
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // 移動 PictureBox 位置
                pictureBox1.Left = e.X + pictureBox1.Left - offset.X;
                pictureBox1.Top = e.Y + pictureBox1.Top - offset.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
