using System;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Lab1._4
{
    class Program
    {
        private static byte[] ConvertToByteArray(string sentense)
        {
            byte[] convertedString = Encoding.Unicode.GetBytes(sentense);
            return convertedString;
        }

        private static string DeConvertToByteArray(byte[] convertedArray)
        {
            return  Encoding.Unicode.GetString(convertedArray);
        }

        private static void Print(byte[] convertedArray)
        {
            foreach (var item in convertedArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private static void Print(string deconvertedArray)
        {
            Console.WriteLine(deconvertedArray);
        }

        private static void GetConnection()
        {

        }

        static void Main(string[] args)
        {
            /*             
             Task1             
             */
            Console.WriteLine("**********\n Task 1\n**********");
            string _ruSentense = "Эта собака есть слишком много овощей после обеда";
            string _jpSentense = "この犬は昼食後にあまりにも多くの野菜を食べています";
            string _deSentense = "Dieser Hund isst zu viel Gemüse nach dem Abendessen";
            string _encoding;

            byte[] strConvertedToByteArray = ConvertToByteArray(_ruSentense);
            Print(strConvertedToByteArray);
            _encoding = DeConvertToByteArray(strConvertedToByteArray);
            Print(_encoding);

            strConvertedToByteArray = ConvertToByteArray(_jpSentense);
            Print(strConvertedToByteArray);
            _encoding = DeConvertToByteArray(strConvertedToByteArray);
            Print(_encoding);

            strConvertedToByteArray = ConvertToByteArray(_deSentense);
            Print(strConvertedToByteArray);
            _encoding = DeConvertToByteArray(strConvertedToByteArray);
            Print(_encoding);

            /*             
            Task2             
            */

            Console.WriteLine("**********\n Task 2\n**********");
            FileStream fs = null;
            string path = @"C:\Data.bin";
            ExceptionDispatchInfo exceptionDispatchInfo = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
            }
            catch (IOException e)
            {
                exceptionDispatchInfo = ExceptionDispatchInfo.Capture(e);
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            if (exceptionDispatchInfo != null) 
            {
                try
                {
                    exceptionDispatchInfo.Throw();
                }
                catch (Exception)
                {
                    Console.WriteLine("File don't find");
                }
            }
            Console.ReadKey();
        }
    }
}