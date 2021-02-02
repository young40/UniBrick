using PureMVC.Patterns.Mediator;
using TinaX;
using TinaX.VFSKit;
using UnityEngine;

namespace SuperPowerEntry
{
    public class SuperPowerEntrySceneMediator: Mediator
    {
        private const string NAME = nameof(SuperPowerEntrySceneMediator);
        
        public SuperPowerEntrySceneMediator() : base(NAME)
        {
            var vfs = XCore.MainInstance.Services.Get<IVFS>();
            
            vfs.LoadSceneAsync("Assets/Scenes/SuperPowerEntry.unity", (scene, exception) =>
            {
                if (exception == null)
                {
                    scene.OpenScene();
                }
                else
                {
                    Debug.LogError(exception);             
                }
            });
        }
    }
}