using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            string line = Console.ReadLine();
            if (line == "exit")
            {
                Environment.Exit(0);
            }

            string[] split = line.Split(new string[] { "  " }, StringSplitOptions.None);
            var Black = split[0].Substring(7, 14).ToString();
            var White = split[1].Substring(7, 14).ToString();

             ////Create lists
            string[] B = Black.Split(new Char[] { ' ' });
            List<string> BlackList =new List<string>(B);
            string[] W = White.Split(new Char[] { ' ' });
            List<string> WhiteList =new List<string>(W);
            
            Hand(BlackList);
      



            int Handvalue = 0;

            public class Flush{
                if(x => x.suit !=suit[0])
            }

            ///////////////////////////tests
            //////////////////////////Console.WriteLine(Black);
            //////////////////////////Console.WriteLine(B[0] + "|" + B[1] + "|" + B[2] + "|" + B[3] + "|" + B[4]);
            //////////////////////////BlackList.ForEach(i => Console.Write("{0}\t", i));
            //////////////////////////Console.WriteLine("Press any key to stop...");
            //////////////////////////Console.ReadKey();



            
            
 


         //public class Hand    
         //{        
         //    public Hand()
         //    {           
         //        foreach (var suit in Enum.GetValues(typeof (Suit)))
         //        {         
         //            foreach (var face in Enum.GetValues(typeof (Face)))
         //            {     
         //                Add(new Card((Face) face, (Suit) suit));  
         //            }  
         //        }
         //    } 
        // }














          //public class Flush{
          //    return(Card(x =>x.suit !=b[0])
          //}
            
          //  //FLUSH Check
          //  if(B[0].ToString().Substring(2,1) == B[1].ToString().Substring(2,1) == B[2].ToString().Substring(2,1) == B[3].ToString().Substring(2,1) == B[4].ToString().Substring(2,1))
          //  {

          //  }


            //Console.WriteLine(Black);
            //Console.WriteLine(B[0] + "|" + B[1] + "|" + B[2] + "|" + B[3] + "|" + B[4]);

            //Console.WriteLine(White);
            //Console.WriteLine("Press any key to stop...");
            //Console.ReadKey();

           // B.Sort<int>(B,[].substring(1,1);
          
            
            
            //Array.Sort(B.substring(1,1));
            //if(B[0]
            





           


        }
    }
}
