using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveSystemPetriNets_CourseProject
{
    public class Question
    {
        private string _text;
        private int _numberQ;
        private List<Answer> _answers;

        public Question(string question, int number, List<Answer> answers)
        {
            _text = question;
            _numberQ = number;
            _answers = answers;
        }

        public Question(string question, int number)
        {
            _text = question;
            _numberQ = number;
        }

        public string Text
        {
            get {return _text;}
        }

        public int Number
        {
            get {return _numberQ; }
        }

        public List<Answer> Answers
        {
            get { return _answers; }
        }
    }

    public class Answer
    {
        private string _answerText;
        private int _nextPosition;

        public Answer(string answer, int nextPosition)
        {
            _answerText = answer;
            _nextPosition = nextPosition;
        }

        public int NextPosition
        {
            get {return _nextPosition;}
        }

        public string AnswerText
        {
            get {return _answerText;}
        }
    }
}
