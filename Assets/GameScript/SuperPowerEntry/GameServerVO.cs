using System;

namespace SuperPowerEntry
{
    [Serializable]
    public class GameServerVO
    {
        public GameServerVO(string name, string ip, int port)
        {
            m_Name = name;
            m_IP = ip;
            m_Port = port;
        }

        public string Name
        {
            get => m_Name;
        }
        private string m_Name;

        public string IP
        {
            get => m_IP;
        }
        private string m_IP;

        public int Port
        {
            get => m_Port;
        }
        private int m_Port;

        public override string ToString()
        {
            return string.Format("{0} {1}:{2}", m_Name, m_IP, m_Port);
        }
    }
}