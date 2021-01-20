using System;
using System.Collections;
using System.Collections.Generic;
using TinaX;
using UnityEngine;

using TinaX.Core;
using TinaX.Services;

public class Init : MonoBehaviour
{
    private async void Start()
    {
        var core = XCore.New()
            .UseVFS()
            .UseUIKit()
            .UseXILRuntime()
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
