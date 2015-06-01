using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main()
        {

            
            

            Console.WriteLine(@"Magic 8 Ball!

Ask a question: ");
            Console.ReadLine();
            Answer();
        }



        static void Answer()
            {
                
                    string[] answers = new string[9];
                    answers[0] = "Yes.";
                    answers[1] = "No.";
                    answers[3] = "Maybe.";
                    answers[4] = "Ask again.";
                    answers[5] = "I can't be too sure on that.";
                    answers[6] = "Looks promising.";
                    answers[7] = "I doubt it.";
                    answers[8] = "Ask again later.";
                    Random rnd = new Random();
                    int answer = rnd.Next(0, 9);
                    Console.WriteLine(answers[answer]);

                    Console.WriteLine("Press Enter to ask another question: ");
                    Console.ReadLine();
                    Console.Clear();
                    Main();

                    
                        
                    }

                    
            
           
        }
        
    }

