using PureMVC.Patterns.Proxy;
using UniRx;

namespace SuperPowerEntry
{
    public class GameServerProxy: Proxy
    {
        public static string NAME = nameof(GameServerProxy);
        
        public GameServerProxy() : base(NAME, new ReactiveCollection<GameServerVO>())
        {
            
        }

        public ReactiveCollection<GameServerVO> ServerList
        {
            get => (ReactiveCollection<GameServerVO>) Data;
        }
    }
}