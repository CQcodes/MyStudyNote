﻿using System;
using System.Collections.Generic;
using System.Text;
using ProgramPractice;

namespace ExecuterConsole.Executers
{
    public static class ProgramPracticeExecuter
    {
        public static void FindMinimumCommonValueFromTwoArrays()
        {
            var findMinCommonValueInTwoArrays = new FindMinCommonValueInTwoArrays();
            findMinCommonValueInTwoArrays.Execute();
        }

        public static void Anagram()
        {
            var anagramObj = new Anagram();
            anagramObj.Execute();
        }
    }
}
