using System;
using Nancy.Hosting.Self;


namespace NancyTopshelf.Console
{
    public class NancySelfHost
    {
        private NancyHost m_nancyHost;

        public void Start()
        {
            m_nancyHost = new NancyHost(new Uri("http://localhost:5000"));
            m_nancyHost.Start();

        }

        public void Stop()
        {
            m_nancyHost.Stop();
            System.Console.WriteLine("Stopped. Good bye!");
        }
    }
}
