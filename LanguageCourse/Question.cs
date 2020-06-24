using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCourse
{
    class Question
    {
        public string question;
        public string answer;
        public string img;


        public Question(string question, string answer, string img)
        {
            this.question = question;
            this.answer = answer;
            this.img = img;
        }
    }
}
