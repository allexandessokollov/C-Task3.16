using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace task3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Ut imperdiet elit a enim vulputate, non aliquam nisi pellentesque." +
                " Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Class aptent taciti sociosqu ad litora torquent per conubia nostra, " +
                "per inceptos himenaeos. Nulla lacinia ligula a arcu pretium lobortis. " +
                "Etiam ultricies hendrerit nunc.";

           
            
            Sign[] sng = new Sign[s.Length];
            for(int i = 0; i < sng.Length; i++)
                sng[i] = new Sign();
            Sign max;
            
            sng[0].setSign(s[0]); 

            for (int i = 0; i < s.Length; i++)
            {
                
                if (alreadyExist(sng, s[i]))              
                    sng[i].addCount(1);              
                else
                    sng[i].setSign(s[i]);
            }

            max = mostFrequently(sng);
            Console.WriteLine(max.getChar() + "  Quantity is " + max.getCount());
        }

        static bool alreadyExist(Sign[] sng, char ch)
        {
            bool ret = true;
            

            for (int i = 0; i < sng.Length; i++)
            {
                if (sng[i].getChar() == ch)
                    return ret;
                
            }
            ret = false;
            return ret;
        }
        static Sign mostFrequently(Sign[] sng)
        {
            Sign max = sng[1];
            for (int i = 1; i < sng.Length; i++)
            {
                if (sng[i].getCount() > sng[i - 1].getCount())
                    max = sng[i];
            }
            return max;
        }
    }
}
