using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class OPInfix : OutputSupport
    {
        public override string XuLy(List<string> Input)
        {
            if (Input.Count > 0)
            {
                string temp = String.Empty;
                for (int i = 0; i < Input.Count; i++)
                {
                    temp = temp + Input[i];
                }
                return temp;
            }
            return null;
        }
    }
}
