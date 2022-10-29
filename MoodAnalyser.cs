using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day21_MSMODEANALYSER_ASGMNT_uc1
{
    public class MoodAnalyser
    {

        public string  analyseMood(string message)
        {
           
                if (message.Equals(string.Empty))
                {
                return "Mood should not be empty";
                }
            if (message.Contains("Sad"))
            {  return "Sad" ; }
           else
            {
              return "Happy" ;
            }
       
        }
        public static void Main(string[] args)
        {

        }
       

    }
    
        
    
  
}
