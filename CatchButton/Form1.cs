namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Catch_Me_Button_Click(object sender, EventArgs e)
        {

        }

        private void Catch_Me_Button_MouseEnter(object sender, EventArgs e)
        {
            int x_position = 100;
            int y_position = 151;
            // 새로운위치값세팅. 새로운X,Y 좌표값
            Catch_Me_Button.Location = new Point(x_position, y_position);
            // 버튼을새로운위치로옮김(새로운Point 객체생성)
        }
    }
}
