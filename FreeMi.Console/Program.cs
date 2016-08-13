using System;
using System.Threading;
using FreeMi.Core;

namespace FreeMi.Console
{
    internal class Program
    {
        private static Device Device { get; set; }

        private static void Main(string[] args)
        {
            Device = new Device();
            Device.Start();
            try
            {
                var arr = new WaitHandle[1];
                arr[0] = new ManualResetEvent(false);

                while (false == WaitHandle.WaitAll(arr, new TimeSpan(0, 0, 10)))
                {
                }

                //System.Console.WriteLine(Resources.PressEnterToQuit);
                //System.Console.ReadLine();
            }
            finally
            {
                if (Device != null)
                {
                    Device.Stop();
                    Device = null;
                }
            }
        }
    }
}