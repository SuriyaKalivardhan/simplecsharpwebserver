using simplewebserverlib;
using System.Net;

HttpListener listener = new HttpListener();
listener.Prefixes.Add("http://localhost:5001/");
listener.Start();
while(true)
{
    var context = listener.GetContext();
    var response = context.Response;
    string responseString = RequestProcessor.GetEnvironment();
    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
    response.ContentLength64 = buffer.Length;
    Stream output = response.OutputStream;
    output.Write(buffer, 0, buffer.Length);
    output.Close();
}