using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        Random rd = new Random();

        int score = 0;
        int missCount = 0;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            this.Text = $"점수: {score}, 놓친 횟수: {missCount}";
        }

        private void Catch_Me_Button_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;

            score += 100;
            SystemSounds.Asterisk.Play();

            MessageBox.Show("축하합니다~!", "성공");

            int newWidth = (int)(Catch_Me_Button.Width * 0.9);
            int newHeight = (int)(Catch_Me_Button.Height * 0.9);

            if (newWidth >= 30 && newHeight >= 20)
            {
                Catch_Me_Button.Size = new Size(newWidth, newHeight);
            }

            this.Text = $"점수: {score}, 놓친 횟수: {missCount}";
        }

        private void Catch_Me_Button_MouseEnter(object sender, EventArgs e)
        {
            if (isGameOver) return;

            missCount++;
            score -= 10;
            SystemSounds.Beep.Play();

            int maxX = this.ClientSize.Width - Catch_Me_Button.Width;
            int maxY = this.ClientSize.Height - Catch_Me_Button.Height;

            if (maxX < 0) maxX = 0;
            if (maxY < 0) maxY = 0;

            int nextX = rd.Next(0, maxX + 1);
            int nextY = rd.Next(0, maxY + 1);

            Catch_Me_Button.Location = new Point(nextX, nextY);

            this.Text = $"점수: {score}, 놓친 횟수: {missCount}, 버튼위치: ({nextX}, {nextY})";

            if (missCount >= 20)
            {
                isGameOver = true;
                Catch_Me_Button.Enabled = false;
                MessageBox.Show("Game Over", "게임 종료");
                this.Text = $"Game Over / 최종 점수: {score}";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;
            isGameOver = false;

            Catch_Me_Button.Enabled = true;
            Catch_Me_Button.Visible = true;
            Catch_Me_Button.Size = new Size(120, 50);
            Catch_Me_Button.Location = new Point(100, 100);

            this.Text = $"점수: {score}, 놓친 횟수: {missCount}";
        }
    }
}