using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;

namespace InteractiveSystemPetriNets_CourseProject
{
    class Provider
    {
        public List<Question> Load()
        {
            List<Question> questions = new List<Question>();

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "(*.xml)|*.xml" };
            openFileDialog.ShowDialog();
            XDocument xDocument = XDocument.Load(openFileDialog.FileName);

            foreach (XElement el in xDocument.Root.Elements())
            {
                string text = el.Element("text").Value;
                string number = el.Attribute("number").Value;
                List<Answer> answers = new List<Answer>();

                var answers1 = el.Element("answers");
                foreach (var answer in answers1.Elements())
                {
                    string answertext = answer.Value;
                    string nextPosition = answer.Attribute("nextquestion").Value;
                    answers.Add(new Answer(answertext, Convert.ToInt32(nextPosition)));
                }

                questions.Add(new Question(text, Convert.ToInt32(number), answers));
            }

            return questions;
        }

    }
}
