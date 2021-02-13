using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace CSharp.ThreadSynchronization
{
    /// <Note>
    /// 
    /// Developer can use SemaphoreSlim class to restrict the number of threads that can access a piece of code at same time.
    /// In this example it is set to 250.
    /// 
    /// await _gate.WaitAsync(); => this will block(wait) the thread when already specified amount of threads are accessing the code.
    ///  _gate.Release(); => this is an indication that thread has finished accessing the code and has exited.
    ///  
    ///  Semaphore class can be used cross-process. named semaphore object has to be created whoch will be visible to the OS.
    ///  SemaphoreSlim can be used in one process only.
    ///  
    /// </Note>
    public class SemaphoreSlimDemo
    {
        private static HttpClient _httpClient;
        //private const string GOOGLE = "https://www.google.com";
        private const string BING = "https://www.bing.com";
        private SemaphoreSlim _gate = new SemaphoreSlim(250);

        public SemaphoreSlimDemo()
        {
            if(_httpClient == null)
            {
                _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(5) };
            }
        }

        public void execute()
        {
            Task.WaitAll(MakeRepetitiveNetworkCalls(500).ToArray());
        }

        private IEnumerable<Task> MakeRepetitiveNetworkCalls(int rep)
        {
            for (int i = 0; i < rep; i++)
            {
                yield return CallGoogle(i);
            }
        }

        private async Task CallGoogle(int repCount)
        {
            try
            {
                await _gate.WaitAsync();
                var response = await _httpClient.GetAsync(BING);
                _gate.Release();

                Console.WriteLine(repCount + " - " + response.StatusCode);
            }
            catch(Exception e)
            {
                Console.WriteLine($"{repCount} - {e.Message}");
            }
        }
    }
}
