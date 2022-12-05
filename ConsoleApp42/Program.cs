using System;

namespace ConsoleApp42
{
    class Program
    {
        //добавленные изменения
        static string OrdNumStr(string str, string str2)
        {
            string s = "";
            string s2 = "";

            for (int i = 0; i < str.Length; i++)
            {
                int c = 0;
                int n = 0;
                bool a = false;

                if (str[i] >= '0' && str[i] <= '9')
                {
                    for (int i1 = 0; i1 < str2.Length; i1++)
                    {
                        if (str[i] >= '0' && str[i] <= '9')
                        {
                            if (str[i] == str2[i1] )
                            {
                              n++;
                            }
                        }
                    }        
                }
                if (n > 0)
                { 
                  while(c<s.Length && a == false)
                  {
                        if (s[c] == str[i])
                            a = true;
                        c++;
                  }

                    if (a == false)
                        s = s + str[i];
                    
                }

            } 

            
 
               
            for (int i = 0; i< 10; i++)       
            {
                
                
                for (int i2 = 0; i2 < s.Length; i2++)
                {
                   

                    if (s[i2] == i )
                    {
                        s2 = s2 + s[i2];

                    }
                }
                
              
            }


            return s2;
        }


        static void Main(string[] args)
        {
            string str2 = "1723444лд98";
            string str = "фыв745555у7и8125";

            Console.WriteLine(OrdNumStr(str, str2));


        }
    } 
}