using TinaX;
using UnityEngine;

using TinaX.Services;

public class Init : MonoBehaviour
{
    private void Start()
    {
        var core = XCore.New()
            .UseVFS()
            .UseUIKit()
#if !NO_ILRUNTIME
            .UseXILRuntime()
#endif
            .OnServicesStartException((service, exception) =>
            {
                Debug.LogError(exception);
                
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #endif
            });

        core.RunAsync(err =>
        {
            if (err != null)
            {
                Debug.LogError(err);
            }
            else
            {
                Debug.Log("App Started.");
            }
        });
    }
}
