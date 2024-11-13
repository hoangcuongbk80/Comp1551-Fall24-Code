using System;
using System.Collections.Generic;

namespace GeographyQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>
            {
                new MultipleChoiceQuestion("What is the capital of France?",
                    new List<string> { "Berlin", "Madrid", "Paris", "Lisbon" }, "Paris"),
                new OpenEndedQuestion("What is the largest desert in the world?",
                    new List<string> { "Antarctica" }),
                new TrueFalseQuestion("Mount Everest is the tallest mountain in the world.", true),
                new MultipleChoiceQuestion("Which river flows through Egypt?",
                    new List<string> { "Nile", "Amazon", "Yangtze", "Ganges" }, "Nile"),
                new OpenEndedQuestion("What is the smallest country in the world?",
                    new List<string> { "Vatican City", "Vatican" }),
                new TrueFalseQuestion("Africa is a country.", false)
            };

            int score = 0;

            foreach (var question in questions)
            {
                Console.WriteLine(question.Text);
                bool isCorrect = question.Ask();
                if (isCorrect)
                {
                    score++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n");
                }
            }

            Console.WriteLine($"Your final score: {score}/{questions.Count}");
        }
    }

    abstract class Question
    {
        public string Text { get; }

        protected Question(string text)
        {
            Text = text;
        }

        public abstract bool Ask();
    }

    class MultipleChoiceQuestion : Question
    {
        private readonly List<string> _options;
        private readonly string _correctAnswer;

        public MultipleChoiceQuestion(string text, List<string> options, string correctAnswer)
            : base(text)
        {
            _options = options;
            _correctAnswer = correctAnswer;
        }

        public override bool Ask()
        {
            for (int i = 0; i < _options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_options[i]}");
            }

            Console.Write("Your answer (1-4): ");
            int answerIndex;
            if (int.TryParse(Console.ReadLine(), out answerIndex) &&
                answerIndex >= 1 && answerIndex <= _options.Count)
            {
                return _options[answerIndex - 1].Equals(_correctAnswer, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
    }

    class OpenEndedQuestion : Question
    {
        private readonly List<string> _correctAnswers;

        public OpenEndedQuestion(string text, List<string> correctAnswers)
            : base(text)
        {
            _correctAnswers = correctAnswers;
        }

        public override bool Ask()
        {
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine().Trim();

            foreach (var answer in _correctAnswers)
            {
                if (userAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }

    class TrueFalseQuestion : Question
    {
        private readonly bool _correctAnswer;

        public TrueFalseQuestion(string text, bool correctAnswer)
            : base(text)
        {
            _correctAnswer = correctAnswer;
        }

        public override bool Ask()
        {
            Console.Write("Your answer (true/false): ");
            string userAnswer = Console.ReadLine().Trim().ToLower();

            return (userAnswer == "true" && _correctAnswer) ||
                   (userAnswer == "false" && !_correctAnswer);
        }
    }
}
