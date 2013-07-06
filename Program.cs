using System;

namespace HometaskStrings
{
    class Program
    {
        static void WriteArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ' ' );
            }
            Console.WriteLine("");
        }

        static int CountCharacters(string text, char toCount)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == toCount)
                    count++;
            }

            return count;
        }

        static string IsBracketsBalanced(string text)
        {
            if (CountCharacters(text, '[') != CountCharacters(text, ']') ||
                CountCharacters(text, '(') != CountCharacters(text, ')') ||
                CountCharacters(text, '{') != CountCharacters(text, '}')
                )
            {
                return "no";
            }
         
            return "yes";
        }

        static string DoubleNumbers(string str)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(str);
            
            for (var i = 0; i < str.Length; i++)
            {                 
                 if( Char.IsNumber( str[ i ] ) )
                 {
                     sb.Replace(str[i].ToString(), str[i].ToString() + str[i].ToString());     
                 }            
            }
            return sb.ToString();
        }

        static string MockString(string str)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(str);

            sb.Replace("1", "Ignasio");
            sb.Replace("a", "alpha");
            sb.Replace("b", "bravo");
            sb.Replace(" ", "");
            sb.Replace("va", "");

            return sb.ToString();
        }


        static void Main(string[] args)
        {
            string[] strArr = new string[5];
            string tmp = "\0";
            string assembled = "";
            char[] punct = ",'-".ToCharArray();

            ////enter name--------------------------------------------------------
            //Console.WriteLine("Enter your name");                               
            //tmp = Console.ReadLine();                                           

            //tmp = tmp.ToLower();

            //tmp = tmp.Replace(tmp[0], Char.ToUpper(tmp[0]));//big letter at first

            //if (tmp.IndexOfAny(punct) > 0 )//if punctuacial characters present
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Punctuacial present ");
            //    Console.ResetColor();
            //}

            //strArr[0] = new String(tmp.ToCharArray());//add to array
            //assembled += tmp + " ";//add to group
            ////------------------------------------------------------------------

            ////enter surname-----------------------------------------------------
            //Console.WriteLine("Enter your surname");
            //tmp = Console.ReadLine();

            //tmp = tmp.ToLower();

            //tmp = tmp.Replace(tmp[0], Char.ToUpper(tmp[0]));//big letter at first

            //if (tmp.IndexOfAny(punct) > 0)//if punctuacial characters present
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Punctuacial present ");
            //    Console.ResetColor();
            //}

            //strArr[0] = new String(tmp.ToCharArray());//add to array
            //assembled += tmp + " ";//add to group
            ////------------------------------------------------------------------
           
            //strArr[1] = new String(tmp.ToCharArray());
            //assembled += tmp + " ";

            ////enter your male---------------------------------------------------
            //Console.WriteLine("Enter your ");
            //tmp = Console.ReadLine();

            //tmp = tmp.ToLower();

            //tmp = tmp.Replace(tmp[0], Char.ToUpper(tmp[0]));//big letter at first

            //if (tmp.IndexOfAny(punct) > 0)//if punctuacial characters present
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Punctuacial present ");
            //    Console.ResetColor();
            //}

            //strArr[2] = new String(tmp.ToCharArray());
            //assembled += tmp + " ";
            ////------------------------------------------------------------------

            ////enter login-------------------------------------------------------
            //Console.WriteLine("Enter your login");
            //tmp = Console.ReadLine();

            //tmp = tmp.ToLower();

            //tmp = tmp.Replace(tmp[0], Char.ToUpper(tmp[0]));//big letter at first

            //if (tmp.IndexOfAny(punct) > 0)//if punctuacial characters present
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Punctuacial present ");
            //    Console.ResetColor();
            //}
       
            //strArr[3] = new String(tmp.ToCharArray());
            //assembled += tmp + " ";
            ////------------------------------------------------------------------

            ////enter password----------------------------------------------------
            //Console.WriteLine("Enter your password");
            //tmp = Console.ReadLine();

            //tmp = tmp.ToLower();

            //tmp = tmp.Replace(tmp[0], Char.ToUpper(tmp[0]));//big letter at first

            //if (tmp.IndexOfAny(punct) > 0)//if punctuacial characters present
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Punctuacial present ");
            //    Console.ResetColor();
            //}
        
            //strArr[4] = new String(tmp.ToCharArray());
            //assembled += tmp + " ";
            //------------------------------------------------------------------
            
            
           // Console.WriteLine( IsBracketsBalanced( Console.ReadLine( ) ) );
            //write assembled
           // Console.WriteLine(assembled); 
          //  Console.WriteLine("abcd ".Remove(1));
            //Console.WriteLine(String.Empty.Length);
            //string a = null;
            //Console.WriteLine(a.Length);

            //string text = Console.ReadLine();

            //System.Text.StringBuilder sb = new System.Text.StringBuilder(text);
            //text = text.ToLower();
            
            //Console.WriteLine( text );
            var a = Console.ReadLine( );
            a = DoubleNumbers(a);
            Console.WriteLine(a);

            a = MockString(a);
            Console.WriteLine(a);
        }
    }
}
