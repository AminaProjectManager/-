namespace Виселяк
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            labelWins = new Label();
            labelLosses = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(465, 146);
            button1.Name = "button1";
            button1.Size = new Size(379, 50);
            button1.TabIndex = 1;
            button1.Text = "Начать игру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(465, 199);
            label1.Name = "label1";
            label1.Size = new Size(379, 116);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(465, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 59);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(465, 318);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 59);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox1_TextChanged;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(465, 383);
            button2.Name = "button2";
            button2.Size = new Size(379, 55);
            button2.TabIndex = 6;
            button2.Text = "Проверить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelWins
            // 
            labelWins.Location = new Point(585, 9);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(128, 56);
            labelWins.TabIndex = 7;
            labelWins.Text = "Выигрыши: ";
            labelWins.TextAlign = ContentAlignment.MiddleCenter;
            labelWins.Click += label2_Click;
            // 
            // labelLosses
            // 
            labelLosses.Location = new Point(719, 9);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(125, 56);
            labelLosses.TabIndex = 8;
            labelLosses.Text = "Проигрыши: ";
            labelLosses.TextAlign = ContentAlignment.MiddleCenter;
            labelLosses.Click += label3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(719, 81);
            button3.Name = "button3";
            button3.Size = new Size(125, 59);
            button3.TabIndex = 9;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(465, 12);
            button4.Name = "button4";
            button4.Size = new Size(114, 53);
            button4.TabIndex = 10;
            button4.Text = "Список";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(labelLosses);
            Controls.Add(labelWins);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label labelWins;
        private Label labelLosses;
        private Button button3;
        private Button button4;
    }
}