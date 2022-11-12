using System;
using System.IO;
using System.Net;
using System.Threading;

namespace shadownaive
{
    public class PacServer
    {
        public HttpListener httpListener;
        public readonly string host;
        public readonly int port;
        public readonly string path;
        public string content { get; set; }
        public Thread thread { get; set; }
        private bool state = false;

        public PacServer(string host,int port,string path,string content)
        {
            this.host = host;
            this.port = port;
            this.path = path;
            this.content = content;
        }

        public void Start()
        {
            
            try
            {
                httpListener = new HttpListener();
                httpListener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
                httpListener.Prefixes.Add($"http://{this.host}:{this.port}/");
                httpListener.Start();
                state = true;
                thread = new Thread(new ThreadStart(delegate {
                    while (state)
                    {
                        try
                        {
                            HttpListenerContext httpListenerContext = httpListener.GetContext();
                            if (httpListenerContext.Request.HttpMethod == "GET" && httpListenerContext.Request.RawUrl.ToLower() == this.path.ToLower())
                            {
                                httpListenerContext.Response.StatusCode = 200;
                                httpListenerContext.Response.ContentType = "application/x-ns-proxy-autoconfig";
                                using (StreamWriter writer = new StreamWriter(httpListenerContext.Response.OutputStream))
                                {
                                    writer.WriteLine(content);
                                }
                            }
                            else
                            {
                                httpListenerContext.Response.StatusCode = 200;
                                using (StreamWriter writer = new StreamWriter(httpListenerContext.Response.OutputStream))
                                {
                                    writer.WriteLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/><title>PacServers</title></head><body>");
                                    writer.WriteLine("<div style=\"height:20px;color:blue;text-align:center;\"><p>404</p></div>");
                                    writer.WriteLine("<ul>");
                                    writer.WriteLine("</ul>");
                                    writer.WriteLine("</body></html>");
                                }
                            }
                        }
                        catch
                        {


                        }
                    }
                }));
                thread.Start();
            }
            catch (Exception)
            {

            }

           
        }

        public void Stop()
        {
            try
            {
                httpListener.Abort();
            }
            catch (Exception){
                
            }
            try
            {
                state = false;
                thread.Abort();
                thread = null;
                
            }
            catch (Exception)
            {

            }
        }
    }
}
