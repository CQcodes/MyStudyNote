using DataStructure;

namespace ExecuterConsole.Executers
{
    public static class DataStructerExecuter
    {
        public static void Execute<T>() where T : IDataStructure, new() => new T().Execute();
    }
}
