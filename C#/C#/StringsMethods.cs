using System;
namespace StringsMethods
{
    class Program
    {
        static void Main()
        {
            string sentence = "My name is Davut Gunduz ";

            SentenceLength(sentence);
            SentenceClone(sentence);

            var sentenceEndsWithResult = SentenceEndsWith(sentence);
            if(sentenceEndsWithResult == true)
            {
                Console.WriteLine("your sentence is complete");
            }
            else
            {
                Console.WriteLine("your sentence isnt complete");
            }

            var sentenceStartWithResult = SentenceEndsWith(sentence);
            if (sentenceStartWithResult == true)
            {
                Console.WriteLine("Erorr !!! ");
            }
            else
            {
                Console.WriteLine(sentence);
            }

            SentenceIndexOf(sentence);
            SentenceIndexOfSpace(sentence);
            SentenceLastIndexOf(sentence);
            SentenceInsert(sentence);
            SentenceSubstring(sentence);
            SentenceToLower(sentence);
            SentenceToUpper(sentence);
            SentenceReplace(sentence);
            SentenceRemove(sentence);
            SentenceRemoveTwo(sentence);


            Console.ReadLine();
        }

        static void SentenceLength(string sentence)
        {
            int sentenceLength = sentence.Length;
            Console.WriteLine(sentenceLength);
        }

        static void SentenceClone(string sentence)
        {
            var sentenceClone = sentence.Clone();
            Console.WriteLine(sentenceClone);
        }

        static bool SentenceEndsWith(string sentence)
        {
            bool sentenceEndWith = sentence.EndsWith(".");
            return sentenceEndWith;
        }

        static bool SentenceStartWith(string sentence)
        {
            bool sentenceStartWith = sentence.StartsWith("ğ");
            return sentenceStartWith;
        }

        static void  SentenceIndexOf(string sentence)
        {
            var sentenceIndexOfResult = sentence.IndexOf("name");
            
            if (sentenceIndexOfResult == 3)
            {
                Console.WriteLine("Erorr !!! ");
            }
            else
            {
                Console.WriteLine(sentenceIndexOfResult);
            }
        }

        static void SentenceIndexOfSpace(string sentence)
        {
            var sentenceIndexOfSpaceResult = sentence.IndexOf("name");

            if (sentenceIndexOfSpaceResult == 3)
            {
                Console.WriteLine("Erorr !!! ");
            }
            else
            {
                Console.WriteLine(sentenceIndexOfSpaceResult);
            }
        }

        static void SentenceLastIndexOf(string sentence)
        {
            var sentenceLastIndexOfResult = sentence.LastIndexOf(" ");

            Console.WriteLine(sentenceLastIndexOfResult);
        }

        static void SentenceInsert(string sentence)
        {
            var sentenceInsertResult = sentence.Insert(0,"Hello , ");

            Console.WriteLine(sentenceInsertResult);
        }

        static void SentenceSubstring(string sentence)
        {
            var sentenceSubstringResult = sentence.Substring(11);

            Console.WriteLine(sentenceSubstringResult);
        }

        static void SentenceToLower(string sentence)
        {
            var sentenceToLowerResult = sentence.ToLower();

            Console.WriteLine(sentenceToLowerResult);
        }

        static void SentenceToUpper(string sentence)
        {
            var sentenceToUpperResult = sentence.ToUpper();

            Console.WriteLine(sentenceToUpperResult);
        }

        static void SentenceReplace(string sentence)
        {
            var sentenceReplaceResult = sentence.Replace(" ","-");

            Console.WriteLine(sentenceReplaceResult);
        }

        static void SentenceRemove(string sentence)
        {
            var sentenceRemoveResult = sentence.Remove(2);

            Console.WriteLine(sentenceRemoveResult);
        }

        static void SentenceRemoveTwo(string sentence)
        {
            var sentenceRemoveTwoResult = sentence.Remove(0,11);

            Console.WriteLine(sentenceRemoveTwoResult);
        }
    }
}