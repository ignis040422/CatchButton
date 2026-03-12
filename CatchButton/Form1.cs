using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        Random rd = new Random();

        int score = 0;
        int missCount = 0;
        bool isGameOver = false;
        //  점수, 놓친 횟수, 게임 오버 상태를 저장하는 변수

        public Form1()
        {
            InitializeComponent();
            this.Text = $"점수: {score}, 놓친 횟수: {missCount}";
            // 초기 타이틀 설정
        }

        private void Catch_Me_Button_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            //게임이 끝나면 실행안되도록 함
            score += 100;
            // 버튼 잡으면 100점
            SystemSounds.Asterisk.Play();
            // 성공 효과음 재생

            MessageBox.Show("축하합니다~!", "성공");
            // 성공 메시지 출력

            int newWidth = (int)(Catch_Me_Button.Width * 0.9);
            //버튼 크기 줄이기 10%씩
            int newHeight = (int)(Catch_Me_Button.Height * 0.9);
            //버튼 크기 줄이기 10%씩

            if (newWidth >= 30 && newHeight >= 20)
                // 버튼 크기 제한
            {
                Catch_Me_Button.Size = new Size(newWidth, newHeight);
            }

            this.Text = $"점수: {score}, 놓친 횟수: {missCount}";
        }

        private void Catch_Me_Button_MouseEnter(object sender, EventArgs e)
        {
            if (isGameOver) return;
            //게임이 종료되면 실행 x
            missCount++;
            // 버튼을 놓치면 missCount 증가
            score -= 10;
            SystemSounds.Beep.Play();
            // 실패 효과음 재생

            int maxX = this.ClientSize.Width - Catch_Me_Button.Width;
            // 버튼이 폼 밖으로 나가지 않도록 최대 X 좌표 계산
            int maxY = this.ClientSize.Height - Catch_Me_Button.Height;
            // 버튼이 폼 밖으로 나가지 않도록 최대 Y 좌표 계산

            if (maxX < 0) maxX = 0;
            if (maxY < 0) maxY = 0;
            // 폼이 너무 작아서 버튼이 들어가지 않는 경우 대비

            int nextX = rd.Next(0, maxX + 1);
            int nextY = rd.Next(0, maxY + 1);
            // 버튼이 랜덤한 위치로 이동

            Catch_Me_Button.Location = new Point(nextX, nextY);
            //  버튼 위치 업데이트

            this.Text = $"점수: {score}, 놓친 횟수: {missCount}, 버튼위치: ({nextX}, {nextY})";
            //  점수, 놓친 횟수, 버튼 위치를 타이틀에 표시

            if (missCount >= 20)
            {
                isGameOver = true;
                Catch_Me_Button.Enabled = false;
                MessageBox.Show("Game Over", "게임 종료");
                this.Text = $"Game Over / 최종 점수: {score}";
                // 게임 오버 메시지 출력 및 최종 점수 표시
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;
            isGameOver = false;
            // 게임 상태 초기화

            Catch_Me_Button.Enabled = true;
            Catch_Me_Button.Visible = true;
            Catch_Me_Button.Size = new Size(120, 50);
            Catch_Me_Button.Location = new Point(100, 100);
            // 버튼 초기 위치 및 크기로 리셋

            this.Text = $"점수: {score}, 놓친 횟수: {missCount}";
            // 점수와 놓친 횟수 초기화
        }
    }
}