using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmQuiz : Form
    {
        // create a public reference to this instance of frmQuiz for reference in frmResult
        public static frmQuiz instance;

        public frmQuiz()
        {
            InitializeComponent();
            instance = this; // make the instance reference part of initialization
        }

        // create variables at form level for tracking current question count and scores towards each result
        int intCurrentQuestion = 0;
        int intSpringScore = 0;
        int intSummerScore = 0;
        int intFallScore = 0;
        int intWinterScore = 0;
        // create list at form level for storing the question/answer class objects
        List<clsQuizQuestion> questionList = new List<clsQuizQuestion>();

        private void quiz_Load(object sender, EventArgs e)
        {
            // create each question/answer set and store inside a class object, then store that class object inside a list
            clsQuizQuestion First = new clsQuizQuestion();
            First.Question = "Are you more of a morning person or a night owl?";
            First.AddAnswer("The early bird gets the worm! I want to be ready for the day.");
            First.AddAnswer("I have more time for my hobbies at night, with my responsibilities out of the way.");
            questionList.Add(First);

            clsQuizQuestion Second = new clsQuizQuestion();
            Second.Question = "Pick a hot beverage.";
            Second.AddAnswer("I love a relaxing cup of tea.");
            Second.AddAnswer("Coffee! Need that energy boost.");
            Second.AddAnswer("Hot apple cider is the eighth wonder of the world.");
            Second.AddAnswer("Nothing like warm hot chocolate!");
            questionList.Add(Second);

            clsQuizQuestion Third = new clsQuizQuestion();
            Third.Question = "Do you thrive in warm weather or cold weather?";
            Third.AddAnswer("Warm weather! I love to soak up the sun.");
            Third.AddAnswer("Cold, please. I can always put more layers on, but there's only so many to take off.");
            questionList.Add(Third);

            clsQuizQuestion Fourth = new clsQuizQuestion();
            Fourth.Question = "What's a flavor you like?";
            Fourth.AddAnswer("I could go for a fresh strawberry rhubarb pie right now.");
            Fourth.AddAnswer("Mango ice cream! Yum!");
            Fourth.AddAnswer("I'll just finish off this entire plate of maple cookies, thanks.");
            Fourth.AddAnswer("Pour me some egg nog!");
            questionList.Add(Fourth);

            clsQuizQuestion Fifth = new clsQuizQuestion();
            Fifth.Question = "What's a flavor that fits your personality? (You don't have to like the taste.)";
            Fifth.AddAnswer("Honey! Sweet, good for you, and adaptable for lots of situations.");
            Fifth.AddAnswer("Cinnamon! Spicy, intense, and not about to go unnoticed.");
            Fifth.AddAnswer("Salted caramel! Salty-sweet, distinctive, and if you love it you REALLY love it.");
            Fifth.AddAnswer("Mint! Refreshing, always welcome, and a nice palate cleanser (from previous company or previous flavors - take the metaphor as far as you want!).");
            questionList.Add(Fifth);

            clsQuizQuestion Sixth = new clsQuizQuestion();
            Sixth.Question = "Do you like colors that are bold and bright, or muted and pastel";
            Sixth.AddAnswer("I'll go with muted and pastel - they fit nicely with other colors that way.");
            Sixth.AddAnswer("Bold and bright! There's so much visual interest.");
            questionList.Add(Sixth);

            clsQuizQuestion Seventh = new clsQuizQuestion();
            Seventh.Question = "Pick something to wear.";
            Seventh.AddAnswer("A nice, light jacket is all I need.");
            Seventh.AddAnswer("Baseball cap! Gotta keep the sun out of my eyes.");
            Seventh.AddAnswer("Fingerless gloves. Sure, I wanna be warm, but I need those fingers.");
            Seventh.AddAnswer("A really warm scarf seems like it would be nice.");
            questionList.Add(Seventh);

            clsQuizQuestion Eighth = new clsQuizQuestion();
            Eighth.Question = "Do you usually plan ahead, or live in the moment?";
            Eighth.AddAnswer("Live in the moment, baby! I'm spontaneous. I adapt!");
            Eighth.AddAnswer("I plan ahead. It's nice to be prepared for anything.");
            questionList.Add(Eighth);

            clsQuizQuestion Ninth = new clsQuizQuestion();
            Ninth.Question = "Which of these is closest to a flaw of yours?";
            Ninth.AddAnswer("I might be a little TOO spontaneous - even I can't predict something as personal as my own moods.");
            Ninth.AddAnswer("When I get angry, I get REAL angry.");
            Ninth.AddAnswer("Some say I'm a little petty, or at least a little obnoxious.");
            Ninth.AddAnswer("I can be very stingy.");
            questionList.Add(Ninth);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the application when clicked
            this.Close();
        }

        // seemed silly to use three separate functions for this, so i combined them with an additional argument and conditionals
        private void showControls(Boolean bolVisible, string strControls)
        {
            // items with no visibility are not rendered and by default usually shouldn't be interactable, so only adjusting visibility should suffice
            if (strControls == "pnl") // "pnl" specifies switching panels (and showing/hiding the restart button)
            {
                pnlStart.Visible = !bolVisible;
                pnlQuiz.Visible = bolVisible;
                btnRestart.Visible = bolVisible;
                lblRestart.Visible = bolVisible;
            }
            else if (strControls == "rad") // "rad" specifies showing/hiding the third and fourth radio buttons
            {
                radThirdAnswer.Visible = bolVisible;
                radFourthAnswer.Visible = bolVisible;
            }
            else // "btn" specifies swapping the continue button and the results button
            {
                btnContinue.Visible = !bolVisible;
                btnResults.Visible = bolVisible;
            }
        }

        private void loadQuestions()
        {
            // update lblQuestionCount to show how far the user is into the quiz
            lblQuestionCount.Text = (intCurrentQuestion + 1).ToString() + " / " + questionList.Count().ToString();
            // check to see how many questions are stored in the current class object
            if (questionList[intCurrentQuestion].Answers.Count() == 4)
            {
                showControls(true, "rad"); // if four questions are stored, enable all radio buttons
                // display the question and answers in associated label and radio buttons
                lblQuestion.Text = questionList[intCurrentQuestion].Question;
                radFirstAnswer.Text = questionList[intCurrentQuestion].Answers[0];
                radSecondAnswer.Text = questionList[intCurrentQuestion].Answers[1];
                radThirdAnswer.Text = questionList[intCurrentQuestion].Answers[2];
                radFourthAnswer.Text = questionList[intCurrentQuestion].Answers[3];
            }
            else if (questionList[intCurrentQuestion].Answers.Count() == 2)
            {
                showControls(false, "rad"); // if two questions are stored, disable and hide the bottom two radio buttons
                // display the question and answers in associated label and radio buttons
                lblQuestion.Text = questionList[intCurrentQuestion].Question;
                radFirstAnswer.Text = questionList[intCurrentQuestion].Answers[0];
                radSecondAnswer.Text = questionList[intCurrentQuestion].Answers[1];
            }
            else
            {
                // this shouldn't be possible, but i still wanted to cover this base in the event of code tampering
                MessageBox.Show("Something went wrong.");
            }
        }

        private void incrementScores()
        {
            // questions 1, 3, 6, and 8 have only two answers, so they're incremented differently
            if (intCurrentQuestion == 0 || intCurrentQuestion == 2 || intCurrentQuestion == 7)
            {
                // check if first or second answer is chosen, increment seasons accordingly, and uncheck buttons for next set of questions
                if (radFirstAnswer.Checked == true) { intSpringScore++; intSummerScore++; radFirstAnswer.Checked = false; }
                else if (radSecondAnswer.Checked == true) { intFallScore++; intWinterScore++; radSecondAnswer.Checked = false; }
            }
            else if (intCurrentQuestion == 5)
            {
                // check if first or second answer is chosen, increment seasons accordingly, and uncheck buttons for next set of questions
                if (radFirstAnswer.Checked == true) { intSpringScore++; intWinterScore++; radFirstAnswer.Checked = false; }
                else if (radSecondAnswer.Checked == true) { intSummerScore++; intFallScore++; radSecondAnswer.Checked = false; }
            }
            else
            {
                // all four-answer questions increment scores the same. increment scores according to which button is checked, uncheck buttons for next set
                if (radFirstAnswer.Checked == true) { intSpringScore++; radFirstAnswer.Checked = false; }
                else if (radSecondAnswer.Checked == true) { intSummerScore++; radSecondAnswer.Checked = false; }
                else if (radThirdAnswer.Checked == true) { intFallScore++; radThirdAnswer.Checked = false; }
                else if (radFourthAnswer.Checked == true) { intWinterScore++; radFourthAnswer.Checked = false; }
            }
            // increment counter to load next question/answer set
            intCurrentQuestion++;
            // if the final question has been reached, disable and hide btnContinue to avoid index errors
            if (intCurrentQuestion == questionList.Count() - 1)
            {
                showControls(true, "btn");
            }
        }

        private void resetQuiz()
        {
            // reset variables to initial value
            intSpringScore = 0;
            intSummerScore = 0;
            intFallScore = 0;
            intWinterScore = 0;
            intCurrentQuestion = 0;
        }

        // set to public so it can be accessed by frmResult as well
        public void resetForm()
        {
            // reset variables to initial values
            resetQuiz();
            // reset to start panel and make sure btnContinue is showing instead of btnRestart
            showControls(false, "pnl");
            showControls(false, "btn");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // hide  pnlStart and show pnlQuiz
            showControls(true, "pnl");
            // load the first question
            loadQuestions();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // validate something is checked
            if (radFirstAnswer.Checked == true || radSecondAnswer.Checked == true || radThirdAnswer.Checked == true || radFourthAnswer.Checked == true)
            {
                // increment scores based on checked button
                incrementScores();
                // load the next set of questions
                loadQuestions();
            }
            else
            {
                // prompt user to select an option if they haven't
                MessageBox.Show("Select an option!");
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            // increment the score from the final question
            incrementScores();
            // conditionals are in this order to establish a priority level in the event of a tie
            if (intFallScore >= intSpringScore && intFallScore >= intSummerScore && intFallScore >= intWinterScore) // as long as nothing is higher than fall, it wins
            {
                frmResult ResultForm = new frmResult("Fall"); // create and show new form with Fall argument
                ResultForm.ShowDialog();
            }
            else if (intSpringScore >= intSummerScore && intSpringScore >= intWinterScore) // as long as summer and winter aren't higher than spring, it wins
            {
                frmResult ResultForm = new frmResult("Spring"); // create and show new form with Spring argument
                ResultForm.ShowDialog();
            }
            else if (intWinterScore >= intSummerScore) // as long as summer isn't higher than winter, winter wins
            {
                frmResult ResultForm = new frmResult("Winter"); // create and show new form with Winter argument
                ResultForm.ShowDialog();
            }
            else
            {
                frmResult ResultForm = new frmResult("Summer"); // create and show new form with Summer argument
                ResultForm.ShowDialog();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // call function to reset the form 
            resetForm();
        }
    }
}
