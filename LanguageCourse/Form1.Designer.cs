namespace LanguageCourse
{
    partial class Form1
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
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.Button();
            this.Animals = new System.Windows.Forms.Button();
            this.Kitchen = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.LessonLabel = new System.Windows.Forms.Label();
            this.Fruits = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.AnswerWrong = new System.Windows.Forms.Button();
            this.MenuPicture = new System.Windows.Forms.PictureBox();
            this.Berries = new System.Windows.Forms.Button();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.Chapter1 = new System.Windows.Forms.Button();
            this.IceCream = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBox.Location = new System.Drawing.Point(230, 151);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(251, 26);
            this.AnswerBox.TabIndex = 0;
            this.AnswerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // AnswerButton
            // 
            this.AnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton.Location = new System.Drawing.Point(487, 149);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(133, 28);
            this.AnswerButton.TabIndex = 1;
            this.AnswerButton.Text = "Answer";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(230, 187);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(153, 29);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "AnswerLabel";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(230, 110);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(170, 29);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "QuestionLabel";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(748, 110);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(93, 29);
            this.Results.TabIndex = 4;
            this.Results.Text = "Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(487, 346);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(133, 28);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Animals
            // 
            this.Animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals.Location = new System.Drawing.Point(321, 249);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(133, 28);
            this.Animals.TabIndex = 7;
            this.Animals.Text = "Animals";
            this.Animals.UseVisualStyleBackColor = true;
            this.Animals.Visible = false;
            this.Animals.Click += new System.EventHandler(this.Animals_Click);
            // 
            // Kitchen
            // 
            this.Kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kitchen.Location = new System.Drawing.Point(321, 283);
            this.Kitchen.Name = "Kitchen";
            this.Kitchen.Size = new System.Drawing.Size(133, 28);
            this.Kitchen.TabIndex = 8;
            this.Kitchen.Text = "Kitchen";
            this.Kitchen.UseVisualStyleBackColor = true;
            this.Kitchen.Visible = false;
            this.Kitchen.Click += new System.EventHandler(this.Kitchen_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(152, 382);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(133, 28);
            this.Back.TabIndex = 9;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(487, 382);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(133, 28);
            this.Forward.TabIndex = 10;
            this.Forward.Text = ">";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Visible = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // LessonLabel
            // 
            this.LessonLabel.AutoSize = true;
            this.LessonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonLabel.Location = new System.Drawing.Point(206, 25);
            this.LessonLabel.Name = "LessonLabel";
            this.LessonLabel.Size = new System.Drawing.Size(90, 29);
            this.LessonLabel.TabIndex = 11;
            this.LessonLabel.Text = "CLASS";
            // 
            // Fruits
            // 
            this.Fruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fruits.Location = new System.Drawing.Point(321, 312);
            this.Fruits.Name = "Fruits";
            this.Fruits.Size = new System.Drawing.Size(133, 28);
            this.Fruits.TabIndex = 12;
            this.Fruits.Text = "Fruits - Veg";
            this.Fruits.UseVisualStyleBackColor = true;
            this.Fruits.Visible = false;
            this.Fruits.Click += new System.EventHandler(this.Fruits_Click);
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(28, 757);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(133, 28);
            this.GoBack.TabIndex = 13;
            this.GoBack.Text = "<  Back to Menu";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Visible = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // AnswerWrong
            // 
            this.AnswerWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerWrong.Location = new System.Drawing.Point(321, 346);
            this.AnswerWrong.Name = "AnswerWrong";
            this.AnswerWrong.Size = new System.Drawing.Size(133, 28);
            this.AnswerWrong.TabIndex = 14;
            this.AnswerWrong.Text = "Continue >";
            this.AnswerWrong.UseVisualStyleBackColor = true;
            this.AnswerWrong.Visible = false;
            this.AnswerWrong.Click += new System.EventHandler(this.AnswerWrong_Click);
            // 
            // MenuPicture
            // 
            this.MenuPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuPicture.Location = new System.Drawing.Point(672, 397);
            this.MenuPicture.Name = "MenuPicture";
            this.MenuPicture.Size = new System.Drawing.Size(468, 319);
            this.MenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPicture.TabIndex = 15;
            this.MenuPicture.TabStop = false;
            // 
            // Berries
            // 
            this.Berries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Berries.Location = new System.Drawing.Point(487, 249);
            this.Berries.Name = "Berries";
            this.Berries.Size = new System.Drawing.Size(133, 28);
            this.Berries.TabIndex = 16;
            this.Berries.Text = "Berries";
            this.Berries.UseVisualStyleBackColor = true;
            this.Berries.Visible = false;
            this.Berries.Click += new System.EventHandler(this.Berries_Click);
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLabel.Location = new System.Drawing.Point(12, 249);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(86, 29);
            this.PointsLabel.TabIndex = 17;
            this.PointsLabel.Text = "Points:";
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftLabel.Location = new System.Drawing.Point(12, 283);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(105, 29);
            this.LeftLabel.TabIndex = 18;
            this.LeftLabel.Text = "Quedan:";
            // 
            // Chapter1
            // 
            this.Chapter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapter1.Location = new System.Drawing.Point(487, 284);
            this.Chapter1.Name = "Chapter1";
            this.Chapter1.Size = new System.Drawing.Size(133, 28);
            this.Chapter1.TabIndex = 19;
            this.Chapter1.Text = "Chapter 1";
            this.Chapter1.UseVisualStyleBackColor = true;
            this.Chapter1.Visible = false;
            this.Chapter1.Click += new System.EventHandler(this.Chapter1_Click);
            // 
            // IceCream
            // 
            this.IceCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IceCream.Location = new System.Drawing.Point(487, 312);
            this.IceCream.Name = "IceCream";
            this.IceCream.Size = new System.Drawing.Size(133, 28);
            this.IceCream.TabIndex = 20;
            this.IceCream.Text = "Ice Cream";
            this.IceCream.UseVisualStyleBackColor = true;
            this.IceCream.Visible = false;
            this.IceCream.Click += new System.EventHandler(this.IceCream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 797);
            this.Controls.Add(this.IceCream);
            this.Controls.Add(this.Chapter1);
            this.Controls.Add(this.LeftLabel);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.Berries);
            this.Controls.Add(this.MenuPicture);
            this.Controls.Add(this.AnswerWrong);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Fruits);
            this.Controls.Add(this.LessonLabel);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Kitchen);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.AnswerBox);
            this.Name = "Form1";
            this.Text = "Language Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Animals;
        private System.Windows.Forms.Button Kitchen;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label LessonLabel;
        private System.Windows.Forms.Button Fruits;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button AnswerWrong;
        private System.Windows.Forms.PictureBox MenuPicture;
        private System.Windows.Forms.Button Berries;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.Button Chapter1;
        private System.Windows.Forms.Button IceCream;
    }
}

