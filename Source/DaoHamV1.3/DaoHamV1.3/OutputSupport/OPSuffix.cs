using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class OPSuffix : OutputSupport
    {
        //Do uu tien toan tu
        Stack<string> stack;
        public static int GetPriority(string op)
        {
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        // co cau list<string> input
        //string a = "22 * ( ( 33 + 44 ) / 55 )";
            //List<string> input = new List<string>();
            //input.Add("22");
            //input.Add("*");
            //input.Add("(");
            //input.Add("(");
            //input.Add("33");
            //input.Add("+");
            //input.Add("44");
            //input.Add(")");
            //input.Add("/");
            //input.Add("55");
            //input.Add(")");
        // co the chuyen string cung dc ko can list<string>
        public string XuLy(List<string> a)
        {
            // DOi trung to sang hau to
            try
            {
                //string a = "22 * ( ( 33 + 44 ) / 55 )";
                stack = new Stack<string>();
                
                string chuoidaxuly = "";
                //a = a.Replace(" ", "");
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] != "+" && a[i] != "-" && a[i] != "*" && a[i] != "/" && a[i] != ")")
                    {
                        chuoidaxuly = chuoidaxuly + a[i]+" ";
                    }
                    if (a[i] == "(")
                    {
                        stack.Push(a[i]);
                    }
                    if (a[i] == ")")
                    {
                        string temp="";
                        while(temp!="(")
                        {
                            temp = stack.Pop();
                            if (temp != "(")
                                chuoidaxuly = chuoidaxuly + temp + " ";                          
                        }
                        chuoidaxuly = chuoidaxuly + a[i] + " ";
                    }
                        if (a[i] == "+" || a[i] == "-" || a[i] == "*" || a[i] == "/")
                        {
                            string temp="no";
                            if(stack.Count!=0)
                                temp = stack.Peek();
                            int temp1 = GetPriority(temp);
                            int ai = GetPriority(a[i]);
                            if (temp1 >= ai)
                            {
                                temp = stack.Pop();
                                chuoidaxuly = chuoidaxuly + temp + " ";
                            }
                            stack.Push(a[i]);
                        }
                        
                    
                }
                while (stack.Count != 0)
                {
                    string temp = stack.Pop();
                    chuoidaxuly = chuoidaxuly + temp + " ";
                }

                return chuoidaxuly;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
