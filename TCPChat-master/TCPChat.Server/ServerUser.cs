using System.Net.Sockets;

namespace TCPChat.Server
{
    public class ServerUser
    {
        public TcpClient Client { get; set; }
        public string Name { get; set; }

        public ServerUser(TcpClient client, string name)
        {
            Client = client;
            Name = name;
        }
    }
}