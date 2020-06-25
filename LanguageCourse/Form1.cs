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
        int page = 0;
        int top_page = 3;
        bool isFirstAttempt = true;

        public Form1()
        {
            InitializeComponent();
            AcceptButton = AnswerButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StartMenu();
        }

        private void StartMenu()
        {
            Restart.Visible = false;
            pictureBox1.Visible = false;
            AnswerBox.Visible = false;
            AnswerButton.Visible = false;
            QuestionLabel.Visible = false;
            AnswerLabel.Visible = false;
            PointsLabel.Visible = false;
            LeftLabel.Visible = false;
            Results.Visible = false;
            Forward.Visible = true;
            Back.Visible = true;
            LessonLabel.Visible = true;
            GoBack.Visible = false;
            Navigator();
        }

        private void Navigator()
        {
            
            Fruits.Visible = false;
            Animals.Visible = false;
            Kitchen.Visible = false;
            Berries.Visible = false;
            MenuPicture.Location = new Point(152, 55);
            MenuPicture.Visible = true;
            if (page == 0)
            {
                LessonLabel.Text = "Lesson 1 : Animals";
                MenuPicture.Image = Image.FromFile("..\\..\\Img\\animals.jpg");
                Animals.Location = new Point(321, 382);
                Animals.Visible = true;
            }
            else if (page == 1)
            {
                LessonLabel.Text = "Lesson 2 : Kitchen Appliances";
                MenuPicture.Image = Image.FromFile("..\\..\\Img\\kappliances.png");
                Kitchen.Location = new Point(321, 382);
                Kitchen.Visible = true;
            }
            else if (page == 2)
            {
                LessonLabel.Text = "Lesson 3 : Fruits and Vegetables";
                MenuPicture.Image = Image.FromFile("..\\..\\Img\\fruitsveggies.png");
                Fruits.Location = new Point(321, 382);
                Fruits.Visible = true;
            }
            else if (page == 3)
            {
                LessonLabel.Text = "Lesson 4: Berries";
                MenuPicture.Image = Image.FromFile("..\\..\\Img\\berries.jpg");
                Berries.Location = new Point(321, 382);
                Berries.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isFirstAttempt == true)
            {
                if (AnswerBox.Text.ToLower() == item.GetAnswer(index))
                {
                    AnswerLabel.Text = "Correct!\nYour answer was " + AnswerBox.Text + "\nand the answer was " + item.GetAnswer(index);
                    AnswerBox.Text = "";
                    score += 10;                  
                }
                else
                {
                    AnswerLabel.Text = "Incorrect!";
                    mistakes.Add(new Question(item.GetQuestion(index), item.GetAnswer(index), item.GetImg(index)));
                    AnswerBox.Text = "";
                    wrong += 1;
                }

                item.RemoveAt(index);
                PointsLabel.Text = "Points: " + score.ToString();
                LeftLabel.Text = "Quedan: " + item.GetTotalNumber().ToString();
                GameOver();
            }
            else
            {
                if (AnswerBox.Text.ToLower() == mistakes.GetAnswer(index))
                {
                    AnswerLabel.Text = "Correct!\nYour answer was " + AnswerBox.Text + "\nand the answer was " + mistakes.GetAnswer(index);
                    AnswerBox.Text = "";
                    score += 5;
                }
                else
                {
                    AnswerLabel.Text = "Incorrect!";
                    AnswerBox.Text = "";
                    wrong += 1;
                }
                mistakes.RemoveAt(index);
                PointsLabel.Text = "Points: " + score.ToString();
                LeftLabel.Text = "Quedan: " + mistakes.GetTotalNumber().ToString();
                GameOver();
            }
            
        }
        private void GameOver()
        {
            if (isFirstAttempt == true)
            {
                if (item.GetTotalNumber() == 0)
                {
                    MessageBox.Show("You have completed the answers. Responde sólo las incorrectas apretando en CONTINUE>");
                    if (wrong == 0)
                    {
                        Results.Text = "Your score is " + score.ToString() + "\nAnd you got zero wrong answers.";
                        AnswerWrong.Location = new Point(235, 50);
                        AnswerWrong.Visible = false;
                    }
                    else if (wrong == 1)
                    {
                        Results.Text = "Your score is " + score.ToString() + "\nYou got " + wrong.ToString() + " wrong answer.\nHere is the correct answer:\n" + mistakes.ShowWrongAnswers();
                        AnswerWrong.Location = new Point(235, 50);
                        AnswerWrong.Visible = true;
                    }
                    else
                    {
                        Results.Text = "Your score is " + score.ToString() + "\n" + wrong.ToString() + " wrong answers.\nHere are the correct answers:\n" + mistakes.ShowWrongAnswers();
                        AnswerWrong.Location = new Point(235, 50);
                        AnswerWrong.Visible = true;
                    }

                    //Restart.Location = new Point(348, 151);
                    //Restart.Visible = true;
                    PointsLabel.Visible = false;
                    LeftLabel.Visible = false;
                    pictureBox1.Visible = false;
                    AnswerBox.Visible = false;
                    AnswerButton.Visible = false;
                    QuestionLabel.Visible = false;
                    AnswerLabel.Visible = false;
                    Results.Location = new Point(230, 81);
                    Results.Visible = true; 
                    
                    
                }
                else
                {
                    index = rnd.Next(0, item.GetTotalNumber());
                    QuestionLabel.Text = item.GetQuestion(index);
                    pictureBox1.Image = Image.FromFile(item.GetImg(index));
                }
            }
            else
            {
                if (mistakes.GetTotalNumber() == 0)
                {
                    MessageBox.Show("You have completed the answers.");
                    if (wrong == 0)
                    {
                        Results.Text = "Your score is " + score.ToString() + "\nAnd you got zero wrong answers.";
                    }
                    else if (wrong == 1)
                    {
                        Results.Text = "Your score is " + score.ToString() + "\nYou got " + wrong.ToString() + " wrong answer.";
                    }
                    else
                    {
                        Results.Text = "Your score is " + score.ToString() + "\n" + wrong.ToString() + " wrong answers.";
                    }

                    //Restart.Location = new Point(348, 151);
                    //Restart.Visible = true;
                    PointsLabel.Visible = false;
                    LeftLabel.Visible = false;
                    pictureBox1.Visible = false;
                    AnswerBox.Visible = false;
                    AnswerButton.Visible = false;
                    QuestionLabel.Visible = false;
                    AnswerLabel.Visible = false;
                    Results.Location = new Point(230, 81);
                    Results.Visible = true;
                    AnswerWrong.Visible = false;
                }
                else
                {
                    index = rnd.Next(0, mistakes.GetTotalNumber());
                    QuestionLabel.Text = mistakes.GetQuestion(index);
                    pictureBox1.Image = Image.FromFile(mistakes.GetImg(index));
                }
            }
                
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                AnswerButton.PerformClick();
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Restart.Visible = false;
            pictureBox1.Visible = true;
            AnswerBox.Visible = true;
            AnswerButton.Visible = true;
            QuestionLabel.Visible = true;
            AnswerLabel.Visible = true;
            StartMenu();
            item.ClearList();
            mistakes.ClearList();
            wrong = 0;
            score = 0;
            isFirstAttempt = true;
        }

        private void Animals_Click(object sender, EventArgs e)
        {          
            Animals.Visible = false;
            item.Add(new Question("elefante", "elephant", "..\\..\\Img\\elephant.png"));
            item.Add(new Question("león", "lion", "..\\..\\Img\\lion.jpg"));
            item.Add(new Question("ballena", "whale", "..\\..\\Img\\whale.jpg"));
            item.Add(new Question("araña", "spider", "..\\..\\Img\\spider.png"));
            item.Add(new Question("serpiente", "snake", "..\\..\\Img\\snake.jpg"));
            item.Add(new Question("caballo", "horse", "..\\..\\Img\\horse.jpg"));
            item.Add(new Question("vaca", "cow", "..\\..\\Img\\cow.jpg"));
            item.Add(new Question("cerdo", "pig", "..\\..\\Img\\pig.jpg"));
            item.Add(new Question("ardilla", "squirrel", "..\\..\\Img\\squirrel.png"));
            item.Add(new Question("ciervo", "deer", "..\\..\\Img\\deer.jpg"));
            item.Add(new Question("tiburón", "shark", "..\\..\\Img\\shark.jpg"));
            item.Add(new Question("hormiga", "ant", "..\\..\\Img\\ant.jpg"));
            item.Add(new Question("ratón", "mouse", "..\\..\\Img\\mouse.jpg"));
            item.Add(new Question("rata", "rat", "..\\..\\Img\\rat.jpg")); 
            item.Add(new Question("mariposa", "butterfly", "..\\..\\Img\\butterfly.jpg"));
            item.Add(new Question("buho, lechuza", "owl", "..\\..\\Img\\owl.png"));
            item.Add(new Question("águila", "eagle", "..\\..\\Img\\eagle.jpg"));
            item.Add(new Question("burro", "donkey", "..\\..\\Img\\donkey.jpg"));
            item.Add(new Question("zorro", "fox", "..\\..\\Img\\fox.jpg"));
            item.Add(new Question("lobo", "wolf", "..\\..\\Img\\wolf.png"));
            item.Add(new Question("oveja", "sheep", "..\\..\\Img\\sheep.jpg"));
            item.Add(new Question("rana", "frog", "..\\..\\Img\\frog.jpg"));
            item.Add(new Question("sapo", "toad", "..\\..\\Img\\toad.jpg"));
            item.Add(new Question("hiena", "hyena", "..\\..\\Img\\hyena.jpg"));
            item.Add(new Question("murciélago", "bat", "..\\..\\Img\\bat.jpg"));
            item.Add(new Question("ganso", "goose", "..\\..\\Img\\goose.jpg"));
            item.Add(new Question("pato", "duck", "..\\..\\Img\\duck.jpg"));
            item.Add(new Question("toro", "bull", "..\\..\\Img\\bull.jpg"));
            item.Add(new Question("hipopótamo", "hippo", "..\\..\\Img\\hippo.jpg"));
            item.Add(new Question("rinoceronte", "rhino", "..\\..\\Img\\rhino.jpg"));
            item.Add(new Question("zebra", "zebra", "..\\..\\Img\\zebra.jpg"));
            item.Add(new Question("pájaro", "bird", "..\\..\\Img\\bird.jpg"));
            item.Add(new Question("pescado", "fish", "..\\..\\Img\\fish.jpg"));

            InGameLayout();
            index = rnd.Next(0, item.GetTotalNumber());
            QuestionLabel.Text = item.GetQuestion(index);
            pictureBox1.Image = Image.FromFile(item.GetImg(index)); 
        }

        private void Kitchen_Click(object sender, EventArgs e)
        {            
            Kitchen.Visible = false;
            item.Add(new Question("tenedor", "fork", "..\\..\\Img\\Kitchen\\fork.jpg"));
            item.Add(new Question("cuchillo", "knife", "..\\..\\Img\\Kitchen\\knife.jpg"));
            item.Add(new Question("cuchara", "spoon", "..\\..\\Img\\Kitchen\\spoon.png"));
            item.Add(new Question("olla", "pot", "..\\..\\Img\\Kitchen\\pot.jpg"));
            item.Add(new Question("taza", "cup", "..\\..\\Img\\Kitchen\\cup.jpg"));
            item.Add(new Question("tazón", "mug", "..\\..\\Img\\Kitchen\\mug.jpg"));
            item.Add(new Question("vaso", "glass", "..\\..\\Img\\Kitchen\\glass.png"));
            item.Add(new Question("hervidor eléctrico", "electric kettle", "..\\..\\Img\\Kitchen\\ekettle.jpg"));
            item.Add(new Question("tetera", "kettle", "..\\..\\Img\\Kitchen\\kettle.jpg"));
            item.Add(new Question("microondas", "microwave", "..\\..\\Img\\Kitchen\\microwave.jpg"));
            item.Add(new Question("horno", "oven", "..\\..\\Img\\Kitchen\\oven.jpg"));
            item.Add(new Question("sartén", "pan", "..\\..\\Img\\Kitchen\\pan.jpg"));
            item.Add(new Question("tostador", "toaster", "..\\..\\Img\\Kitchen\\toaster.jpg"));

            InGameLayout();
            index = rnd.Next(0, item.GetTotalNumber());
            QuestionLabel.Text = item.GetQuestion(index);
            pictureBox1.Image = Image.FromFile(item.GetImg(index));
        }

        private void Fruits_Click(object sender, EventArgs e)
        {           
            Fruits.Visible = false;           
            item.Add(new Question("fruta", "fruit", "..\\..\\Img\\FruitsVeg\\fruit.png"));
            item.Add(new Question("pera", "pear", "..\\..\\Img\\FruitsVeg\\pear.jpg"));
            item.Add(new Question("manzana", "apple", "..\\..\\Img\\FruitsVeg\\apple.jpg"));
            item.Add(new Question("piña", "pineapple", "..\\..\\Img\\FruitsVeg\\pineapple.jpg"));
            item.Add(new Question("plátano", "banana", "..\\..\\Img\\FruitsVeg\\banana.png"));
            item.Add(new Question("melón", "melon", "..\\..\\Img\\FruitsVeg\\melon.jpg"));
            item.Add(new Question("naranja", "orange", "..\\..\\Img\\FruitsVeg\\orange.jpg"));
            item.Add(new Question("durazno", "peach", "..\\..\\Img\\FruitsVeg\\peach.jpg"));
            item.Add(new Question("uvas (plural)", "grapes", "..\\..\\Img\\FruitsVeg\\grapes.jpg"));
            item.Add(new Question("sandía", "watermelon", "..\\..\\Img\\FruitsVeg\\watermelon.jpg"));
            item.Add(new Question("limón", "lemon", "..\\..\\Img\\FruitsVeg\\lemon.jpg"));
            item.Add(new Question("ciruela", "plum", "..\\..\\Img\\FruitsVeg\\plum.png"));
            item.Add(new Question("repollo", "cabbage", "..\\..\\Img\\FruitsVeg\\cabbage.jpg"));
            item.Add(new Question("lechuga", "lettuce", "..\\..\\Img\\FruitsVeg\\lettuce.jpg"));
            item.Add(new Question("pepino", "cucumber", "..\\..\\Img\\FruitsVeg\\cucumber.jpg"));
            item.Add(new Question("tomate", "tomato", "..\\..\\Img\\FruitsVeg\\tomato.jpg"));
            item.Add(new Question("papas (plural)", "potatoes", "..\\..\\Img\\FruitsVeg\\potatoes.jpg"));
            item.Add(new Question("coliflor", "cauliflower", "..\\..\\Img\\FruitsVeg\\cauliflower.jpg"));
            item.Add(new Question("zanahoria", "carrot", "..\\..\\Img\\FruitsVeg\\carrot.jpg"));
            item.Add(new Question("cebolla", "onion", "..\\..\\Img\\FruitsVeg\\onion.jpg"));
            item.Add(new Question("ajo", "garlic", "..\\..\\Img\\FruitsVeg\\garlic.png"));
            item.Add(new Question("arvejas (plural)", "peas", "..\\..\\Img\\FruitsVeg\\peas.png"));
            item.Add(new Question("porotos (plural)", "beans", "..\\..\\Img\\FruitsVeg\\beans.jpg"));
            item.Add(new Question("lentejas (plural)", "lentils", "..\\..\\Img\\FruitsVeg\\lentils.jpg"));
            item.Add(new Question("champiñon", "mushroom", "..\\..\\Img\\FruitsVeg\\mushroom.jpg"));
            item.Add(new Question("aceitunas (plural)", "olives", "..\\..\\Img\\FruitsVeg\\olive.jpg"));
            item.Add(new Question("ají", "chilli", "..\\..\\Img\\FruitsVeg\\chilli.jpg"));

            InGameLayout();
            index = rnd.Next(0, item.GetTotalNumber());
            QuestionLabel.Text = item.GetQuestion(index);
            pictureBox1.Image = Image.FromFile(item.GetImg(index));

        }

        private void Berries_Click(object sender, EventArgs e)
        {          
            Berries.Visible = false;
            item.Add(new Question("bayas (plural)", "berries", "..\\..\\Img\\berries.jpg"));
            item.Add(new Question("arándano", "blueberry", "..\\..\\Img\\Berry\\blueberry.jpg"));
            item.Add(new Question("frambuesa", "raspberry", "..\\..\\Img\\Berry\\raspberry.jpg"));
            item.Add(new Question("frutilla", "strawberry", "..\\..\\Img\\Berry\\strawberry.jpg"));
            item.Add(new Question("guinda", "cherry", "..\\..\\Img\\Berry\\cherry.png"));
            item.Add(new Question("grosella (dos palabras)", "red currant", "..\\..\\Img\\Berry\\redcurrant.jpg"));
            item.Add(new Question("grosella negra (dos palabras)", "black currant", "..\\..\\Img\\Berry\\blackcurrant.jpg"));
            item.Add(new Question("mora (una palabra)", "blackberry", "..\\..\\Img\\Berry\\blackberry.jpg"));
            item.Add(new Question("mora de los pantanos (una palabra y difícil)", "cloudberry", "..\\..\\Img\\Berry\\cloudberry.jpg"));

            InGameLayout();
            index = rnd.Next(0, item.GetTotalNumber());
            QuestionLabel.Text = item.GetQuestion(index);
            pictureBox1.Image = Image.FromFile(item.GetImg(index));
        }

        private void InGameLayout()
        {
            Back.Visible = false;
            Forward.Visible = false;           
            pictureBox1.Visible = true;
            AnswerBox.Visible = true;
            AnswerButton.Visible = true;
            QuestionLabel.Visible = true;
            AnswerLabel.Visible = true;
            LessonLabel.Visible = false;
            GoBack.Visible = true;
            PointsLabel.Text = "Points: " + score.ToString();
            LeftLabel.Text = "Quedan: " + item.GetTotalNumber().ToString();
            PointsLabel.Visible = true;
            LeftLabel.Visible = true;
            MenuPicture.Visible = false;
            AnswerLabel.Text = "";
            Results.Text = "";
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            page--;
            if(page < 0)
            {
                page = top_page;
            }
            Navigator();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            page++;
            if(page > top_page)
            {
                page = 0;
            }
            Navigator();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            item.ClearList();
            mistakes.ClearList();
            wrong = 0;
            score = 0;
            StartMenu();
            isFirstAttempt = true;
            AnswerWrong.Visible = false;
        }

        private void AnswerWrong_Click(object sender, EventArgs e)
        {
            InGameLayout();
            AnswerWrong.Visible = false;
            isFirstAttempt = false;
            wrong = 0;
            Restart.Visible = false;
            Results.Visible = false;
            index = rnd.Next(0, mistakes.GetTotalNumber());
            QuestionLabel.Text = mistakes.GetQuestion(index);
            pictureBox1.Image = Image.FromFile(mistakes.GetImg(index));
            PointsLabel.Text = "Points: " + score.ToString();
            LeftLabel.Text = "Quedan: " + mistakes.GetTotalNumber().ToString();
        }

        
    }
}
