using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPACalculator.Helpers
{
    public static class GlobalHelpers
    {
        public static double getGradePoint(int marks) {
            double point=0;
            if (marks >= 80) {
                point = 4.00;
            }else if (marks >= 75 && marks<80) {
                point = 3.75;
            }else if (marks >= 70 && marks<75) {
                point = 3.50;
            }else if (marks >= 65 && marks<70) {
                point = 3.25;
            }else if (marks >= 60 && marks<65) {
                point = 3.00;
            }else if (marks >= 55 && marks<60) {
                point = 2.75;
            }else if (marks >= 50 && marks<55) {
                point = 2.5;
            }else if (marks >= 45 && marks<50) {
                point = 2.25;
            }else if (marks >= 40 && marks<45) {
                point = 2.0;
            }
            return point;
        }

        public static double getGpa(List<double> gradePointList){
            double gpa = 0;
            double creditXgradePoint = 0;
            List<double> credits = new List<double>() { 
                3.0, 2.0, 3.0, 3.0, 1.5, 3.0, 1.5, 1.5, 1.5,
            };

            for (int i = 0; i < credits.Count; i++)
            {
                creditXgradePoint += credits[i] * gradePointList[i];
            }

            gpa = creditXgradePoint/20;

            return gpa;
        }

        public static String getLetterGrade(double gradePoint) {
            String letter = "F";
            if (gradePoint == 4.0)
            {
                letter = "A+";
            }
            else if (gradePoint == 3.75)
            {
                letter = "A";
            }
            else if (gradePoint == 3.5)
            {
                letter = "A-";
            }
            else if (gradePoint == 3.25)
            {
                letter = "B+";
            }
            else if (gradePoint == 3.0)
            {
                letter = "B";
            }
            else if (gradePoint == 2.75)
            {
                letter = "B-";
            }
            else if (gradePoint == 2.5)
            {
                letter = "C+";
            }
            else if (gradePoint == 2.25)
            {
                letter = "C";
            }
            else if (gradePoint == 2.0)
            {
                letter = "D";
            }
            else {
                letter = "F";
            }
            return letter;  
        
        }
    }

    
}
