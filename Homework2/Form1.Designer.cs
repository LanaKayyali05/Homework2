namespace Homework2
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
            label1 = new Label();
            txtGuess = new TextBox();
            lblMessage = new Label();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 33);
            label1.Name = "label1";
            label1.Size = new Size(301, 40);
            label1.TabIndex = 0;
            label1.Text = "      I have a number between 1 and 100\r\nCan you guess my number? Enter your guess\r\n";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(225, 76);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(85, 27);
            txtGuess.TabIndex = 1;
            txtGuess.KeyPress += txtGuess_KeyPress;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(325, 79);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(198, 20);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Guess result will appear here";
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(312, 111);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 3;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewGame);
            Controls.Add(lblMessage);
            Controls.Add(txtGuess);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGuess;
        private Label lblMessage;
        private Button btnNewGame;
    }
}
