using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StudentGrades
{
    public class Student
    {
        private double MinimumGrade = 60.0;
        
        public string Name;

        public double FirstGrade;
        
        public double SecondGrade;
        
        public double ThirdGrade;


        public double FinalResult()
        {
            return (FirstGrade + SecondGrade + ThirdGrade);
        }

        public double MissingPoints()
        {
            return MinimumGrade - FinalResult();
        }

        public override string ToString()
        {
            if(FinalResult() >= MinimumGrade)
                return string.Format("Final Result = {0}, Student Approved", FinalResult().ToString("F2", CultureInfo.InvariantCulture));
            else
                return string.Format("Final Result = {0}, Student Reproved. {1} Missing Points",
                                    FinalResult().ToString("F2", CultureInfo.InvariantCulture), 
                                    MissingPoints().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
