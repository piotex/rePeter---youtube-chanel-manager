﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YT_Master.Operations.Slaves
{
    public class OperationGetText : OperationCutting
    {
        public string GetText(string body)
        {
            int startIndex = 0;
            string startString = @"/ /";
            string criticString = "Źródło:";

            return _getBetterValue(ref body, ref startIndex, startString, criticString);
        }
    }
}
