using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class GradingStudent
    {

                //HackerLand University has the following grading policy:
                //Every student receives a  in the inclusive range from  to.
                //Any less than  is a failing grade.
                //Sam is a professor at the university and likes to round each student's  according to these rules:
                //If the difference between the and the next multiple of  is less than, round  up to the next multiple of.
                //If the value of  is less than, no rounding occurs as the result will still be a failing grade.
                //Examples
                // round to  (85 - 84 is less than 3)
                // do not round(result is less than 40)
                // do not round(60 - 57 is 3 or higher)
                //Given the initial value of  for each of Sam's  students, write code to automate the rounding process.
                //Function Description
                //Complete the function gradingStudents in the editor below.
                //gradingStudents has the following parameter(s) :
                //int grades[n]: the grades before rounding
                //Returns
                //int[n]: the grades after rounding as appropriate


        public static List<int> gradingStudents(List<int> grades)
        {
            var studentGrade = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {

                if ((5 - grades[i] % 5) < 3)
                {
                    if (grades[i] >= 38)
                    {
                        studentGrade.Add(grades[i] + (5 - grades[i] % 5));
                    }
                    else
                    {
                        studentGrade.Add(grades[i]);
                    }
                }
                else
                {
                    studentGrade.Add(grades[i]);
                }


            }
            return studentGrade;
        }
    }
}
