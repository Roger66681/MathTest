using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Windows;
using System.Collections.Generic;

namespace MathTest2
{
    public class QuestionsAndAnswers
    {
        public string Question{get; set; }
        public int Answer{get; set; }

        public void QA()
        {
            List<QuestionsAndAnswers> QandA = new List<QuestionsAndAnswers>();
            QandA.Add(new QuestionsAndAnswers() { Question = "What is ten plus two?", Answer = 12});
            QandA.Add(new QuestionsAndAnswers() { Question = "What is four times twenty?", Answer = 80});
            QandA.Add(new QuestionsAndAnswers() { Question = "what is a hundred times twelve?", Answer = 1200});
            QandA.Add(new QuestionsAndAnswers() { Question = "what is five hundred times twenty?", Answer = 10000});
            QandA.Add(new QuestionsAndAnswers() { Question = "what is one hundred eighty seven times sixty divided by 2?", Answer = 5610});
            QandA.Add(new QuestionsAndAnswers() { Question = "What is one hundred twenty times four?", Answer = 480});
            QandA.Add(new QuestionsAndAnswers() { Question = "Divide five hundred from ten thousand.", Answer = 20});
            QandA.Add(new QuestionsAndAnswers() { Question = "What is fifty times sixty?", Answer = 3000});
            QandA.Add(new QuestionsAndAnswers() { Question = "What is five times five?", Answer = 25});
            QandA.Add(new QuestionsAndAnswers() { Question = "What is six times six?", Answer = 36});
            

            foreach (QuestionsAndAnswers question in QandA)
            {
                bool quit = false; //used to exit the foreach loop
                int response = -1; //used to start the "while" loop
                int quitNumber = -1000; //Used to exit the foreach loop with response on same line

                while (response != question.Answer)
                {
                    //Console.Clear();
                    Console.WriteLine(question.Question);
                    
                    if (!int.TryParse(Console.ReadLine(), out response)) //returns false if the user doesn't enter a number
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    else if (response == quitNumber)
                    {
                        quit = true;
                        break; //this exits the "while" loop
                    }
                    else if (response != question.Answer) //user provided a number, but it's wrong
                    {
                        Console.WriteLine("Incorrect answer, please try again.");
                    }
                    else //user provided the correct answer
                    {
                        Console.WriteLine("Correct!");
                    }

                }

                if (quit)
                {
                    break; //this exits the "foreach" loop
                }
            }

        }
    }
    
    public class Test
    {
        static void Main()
        {
              Test test = new Test();
              QuestionsAndAnswers QA = new QuestionsAndAnswers();
              Console.Clear();
              System.Console.WriteLine("Hello and Welcome T MathTest2.0!!!");
              System.Console.WriteLine("Press Enter To Continue...");
              Console.ReadLine();
              Console.Clear();
              QA.QA();
              //QA.TakeInput();

        }
        
    }

}
