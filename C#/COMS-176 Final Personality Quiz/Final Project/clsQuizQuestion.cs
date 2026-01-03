using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class clsQuizQuestion
    {
        /// <summary>
        /// Basic constructor setting values to blank/empty. A constuctor that takes arguments seemed impractical because the arguments to be added
        /// will be long strings and that would be pretty illegible to construct in one line of code.
        /// </summary>
        public clsQuizQuestion()
        {
            this._Question = "";
            this._Answers = new List<string>();
        }
        
        // create variable and lists for class
        string _Question;
        List<string> _Answers;

        public string Question
        {
            get { return _Question; }
            set { _Question = value; }
        }

        public List<string> Answers
        {
            get { return _Answers; } // readonly, for the same reason a constructor with all the values would be impractical
        }

        public void AddAnswer(string value) // as _Answers list is readonly, use a method to add individual answers
        {
            _Answers.Add(value);
        }

        /// <summary>
        /// this method shouldn't be necessary, since I'll likely only be adding questions as needed and thus shouldn't have a need to remove any,
        /// but I still found it practical to include, in the event this code was expanded on in the future.
        /// </summary>
        public void RemoveAnswer(int value)
        {
            _Answers.RemoveAt(value);
        }
    }


}
