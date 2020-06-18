using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCourse
{
    class Items
    {
        public List<Question> list;
        public Items()
        {
            list = new List<Question>();
        }

        public void Add(Question question)
        {
            list.Add(question);
        }

        public string GetQuestion(int x)
        {
            return list[x].question;
        }
        public string GetAnswer(int x)
        {
            return list[x].answer;
        }
        public int GetTotalNumber()
        {
            return list.Count;
        }
        public void RemoveAt(int x)
        {
            list.RemoveAt(x);
        }

        public string ShowWrongAnswers()
        {
            string txt = "";
            for(int i = 0; i< list.Count; i++)
            {
                txt += list[i].question + " = " + list[i].answer + "\n";
            }
            return txt;
        }
    }
}
