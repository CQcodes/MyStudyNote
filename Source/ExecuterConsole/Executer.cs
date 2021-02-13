using ExecuterConsole.Executers;
using System;

namespace ExecuterConsole
{
    class Executer
    {
        static void Main(string[] args)
        {
            #region CSharp

            CSharpExecuter.MutexDemo();

            #endregion

            #region DataStructure

            //DataStructerExecuter.Tree();

            #endregion

            #region ProgramPractice

            //ProgramPracticeExecuter.Anagram();

            #endregion

            #region Algorithm

            //AlgorithmExecuter.BubbleSort();

            #endregion
        }
    }
}
