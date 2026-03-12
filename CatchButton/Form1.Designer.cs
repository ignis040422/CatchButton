namespace CatchButton
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
            Catch_Me_Button = new Button();
            SuspendLayout();
            // 
            // Catch_Me_Button
            // 
            Catch_Me_Button.Font = new Font("맑은 고딕", 15F);
            Catch_Me_Button.Location = new Point(300, 185);
            Catch_Me_Button.Name = "Catch_Me_Button";
            Catch_Me_Button.Size = new Size(147, 55);
            Catch_Me_Button.TabIndex = 0;
            Catch_Me_Button.Text = "나를 잡아봐";
            Catch_Me_Button.UseVisualStyleBackColor = true;
            Catch_Me_Button.Click += Catch_Me_Button_Click;
            Catch_Me_Button.MouseEnter += Catch_Me_Button_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Catch_Me_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Catch_Me_Button;
    }
}
