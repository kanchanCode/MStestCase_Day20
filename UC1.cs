using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class UC1
    {
        private string message;
        public UC1()
        {
            message="I am in Happy Mood";
        }
        public UC1(string message)
        {
            this.message = message;
        }

        public string Analyze()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

            


        }

        public string ForDefault()
        {
            if (this.message.Contains("Happy"))

                return "SAD";
            else
                return "HAPPY";
            
        }
    }
}
