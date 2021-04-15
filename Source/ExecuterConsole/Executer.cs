using Algorithm;
using Algorithm.ArrayManipulation;
using DataStructure.Stack;
using DataStructure.LinkedList;
using ExecuterConsole.Executers;

namespace ExecuterConsole
{
    class Executer
    {
        static void Main(string[] args)
        {
            //CSharpExecuter.KitchenThread();

            DataStructerExecuter.Execute<LinkedListDemo>();

            //ProgramPracticeExecuter.FindMinimumCommonValueFromTwoArrays();

            //AlgorithmExecuter.Execute<ReverseArray>();
        }
    }
}
