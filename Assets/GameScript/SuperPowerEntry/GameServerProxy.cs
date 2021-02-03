using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PureMVC.Patterns.Proxy;
using UniRx;

namespace SuperPowerEntry
{
    public class GameServerProxy: Proxy
    {
        public static string NAME = nameof(GameServerProxy);

        private readonly string filePath = Path.Combine(UnityEngine.Application.dataPath, "SpeDebug", "GameServers.dat");
        
        public GameServerProxy() : base(NAME, new ReactiveCollection<GameServerVO>())
        {
            var rs = this.TryGetData();

            if (!rs)
            {
                ServerList.Add(new GameServerVO("测试服", "1.1.1.1", 8000));
                ServerList.Add(new GameServerVO("线上服", "2.2.2.2", 8001));
            }
        }

        public ReactiveCollection<GameServerVO> ServerList
        {
            get => (ReactiveCollection<GameServerVO>) Data;
        }

        private bool TryGetData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var obj = new ReactiveCollection<GameServerVO>();
                    var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    var bf = new BinaryFormatter();

                    obj = bf.Deserialize(fs) as ReactiveCollection<GameServerVO>;
                    
                    fs.Close();

                    Data = obj;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            
            return false;
        }

        private void SaveData()
        {
            
        }
    }
}