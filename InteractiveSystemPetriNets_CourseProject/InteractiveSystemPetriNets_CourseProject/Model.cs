using System;
using System.Data;
using System.Collections.Generic;

namespace InteractiveSystemPetriNets_CourseProject
{
    class Model
    {
        public Question GetNextQuestion(int nextPosition, List<Question> questions)
        {
            foreach (Question question in questions)
            {
                if (question.Number == nextPosition)
                {
                    return question;
                }
            }

            return null;
        }

    }
}
