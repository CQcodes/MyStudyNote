using Algorithm;

namespace ExecuterConsole.Executers
{
    public static class AlgorithmExecuter
    {
        public static void Execute<T>() where T : IAlgorithm, new() => new T().Execute();
    }
}
