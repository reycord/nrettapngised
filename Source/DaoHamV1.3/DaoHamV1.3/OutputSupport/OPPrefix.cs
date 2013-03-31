using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class OPPrefix : OutputSupport
    {
        public string XuLy(List<string> Input)
        {
            //string kq = ConvertInfixToPrefix("2*((1*2*3+4*1)/5)");
            //Console.WriteLine(kq);
            //2*((3+4)/5)
            //List<string> Input = new List<string>(new string[]{"2", "*", "(", "(", "3", "+", "4", ")", "/", "5", ")"});
            //12X^3 + 1
            //List<string> Input = new List<string>(new string[] { "12", "X", "^", "3", "+", "1"});
            //5X^4+12-x^2-12x
            //List<string> Input = new List<string>(new string[] { "5", "X", "^", "4", "+", "12", "-", "X", "^", "2", "-", "12", "X" });
            //5+12-1-12
            //List<string> Input = new List<string>(new string[] { "5", "+", "12", "-", "1", "-", "12"});

            Stack<string> operatorStack = new Stack<string>();
            Stack<string> resultStack = new Stack<string>();
            
            operatorStack.Push("(");
            Input.Add(")");
            for (int i = 0; i < Input.Count; i++)
            //foreach (string str in Input)
            {
                string str = Input.ElementAt(i);
                if (str == "(")
                {
                    operatorStack.Push(str);
                }
                else
                {
                    if (str == ")")
                    {
                        string poppedOperator = operatorStack.Pop();
                        while (poppedOperator != "(")
                        {
                            resultStack.Push(GetPrefix2Operand1Operator(resultStack, poppedOperator));
                            poppedOperator = operatorStack.Pop();
                        }
                    }
                    else
                    {
                        if (CheckOperator(str))
                        {
                            string popedOperator = operatorStack.Pop();
                            bool priority = CheckPriority(popedOperator, str);
                            while (priority)
                            {
                                resultStack.Push(GetPrefix2Operand1Operator(resultStack, popedOperator));
                                popedOperator = operatorStack.Pop();
                                priority = CheckPriority(popedOperator, str);
                            }
                            operatorStack.Push(popedOperator);
                            operatorStack.Push(str);
                        }
                        else
                        {
                            if (str == "X" && i > 0 && !CheckOperator(Input[i - 1]))
                            {
                                operatorStack.Push("*");
                            }

                            resultStack.Push(str);

                        }
                    }
                }
            }

            return resultStack.Pop();
            
        }

        private static bool CheckOperator(string operatorString)
        {

            if ((operatorString == "^") || (operatorString == "+") || (operatorString == "-") || (operatorString == "*") || (operatorString == "/"))
            {
                return true;
            }

            return false;

        }

        private static bool CheckPriority(string operatorInStack, string operatorCurrent)
        {

            bool flag = false;

            switch (operatorInStack)
            {
                case "^":

                    flag = true;
                    break;

                case "/":
                case "*":
                    if ((operatorCurrent != "^"))
                    {
                        flag = true;
                    }
                    break;

                case "+":
                case "-":

                    if ((operatorCurrent == "+") || (operatorCurrent == "-"))
                    {

                        flag = true;

                    }
                    break;

                default: // for any other popped element

                    flag = false;
                    break;

            }

            return flag;

        }

        private static string GetPrefix2Operand1Operator(Stack<string> operandStack, string operatorString)
        {

            string operand2 = operandStack.Pop();
            string operand1 = operandStack.Pop();

            string result = string.Format("{0} {1} {2}", operatorString, operand1, operand2);

            return result;

        }
    }
}
