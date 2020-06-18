using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCourse
{
    public partial class Form1 : Form
    {
        Items item = new Items();
        Items mistakes = new Items();
        int index;
        Random rnd = new Random();
        int score = 0;
        int wrong = 0;

        public Form1()
        {
            InitializeComponent();
            AcceptButton = button1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StartGame();
        }

        private void StartGame()
        {
            AnswerLabel.Text = "";
            Results.Text = "";
            item.Add(new Question("chileno", "chilean"));
            item.Add(new Question("mañana", "morning"));
            item.Add(new Question("en la mañana", "in the morning"));
            item.Add(new Question("despertarse", "wake up"));
            item.Add(new Question("levantarse", "get up"));
            item.Add(new Question("ducha", "shower"));
            item.Add(new Question("tomar una ducha", "take a shower"));
            item.Add(new Question("tomar desayuno", "eat breakfast"));
            item.Add(new Question("vestirse", "get dressed"));
            item.Add(new Question("ir al colegio", "go to school"));
            item.Add(new Question("ir a trabajar", "go to work"));
            item.Add(new Question("diente", "tooth"));
            item.Add(new Question("dientes", "teeth"));
            item.Add(new Question("cepillo de diente", "toothbrush"));
            item.Add(new Question("cepillarse los dientes", "brush the teeth"));
            item.Add(new Question("buenos días (en la mañana)", "good morning"));

            index = rnd.Next(0, item.GetTotalNumber() );
            QuestionLabel.Text = item.GetQuestion(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == item.GetAnswer(index))
            {
                AnswerLabel.Text = "Correct!\nYour answer was " + textBox1.Text + "\nand the answer was " + item.GetAnswer(index);
                textBox1.Text = "";
                score += 10;
            }
            else
            {
                AnswerLabel.Text = "Incorrect!";
                mistakes.Add(new Question(item.GetQuestion(index), item.GetAnswer(index)));
                textBox1.Text = "";
                wrong += 1;
            }

            item.RemoveAt(index);
            GameOver();
            
        }
        private void GameOver()
        {
            if(item.GetTotalNumber() == 0)
            {
                MessageBox.Show("You have completed the answers.");
                if(wrong == 0)
                {
                    Results.Text = "Your score is " + score.ToString() + "\nAnd you got zero wrong answers.";
                }
                else if(wrong == 1)
                {
                    Results.Text = "Your score is " + score.ToString() + "\nYou got " + wrong.ToString() + " wrong answer.\nHere is the correct answer:\n" + mistakes.ShowWrongAnswers();
                }
                else
                {
                    Results.Text = "Your score is " + score.ToString() + "\n" + wrong.ToString() + " wrong answers.\nHere are the correct answers:\n" + mistakes.ShowWrongAnswers();
                }
                
                //StartGame();
            }
            else
            {
                index = rnd.Next(0, item.GetTotalNumber());
                QuestionLabel.Text = item.GetQuestion(index);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                button1.PerformClick();
            }
        }

    }
}
