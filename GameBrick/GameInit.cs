﻿using UnityEngine;

using TinaX;
using TinaX.UIKit;
using TinaX.VFSKit;

public class GameInit
{
    public static void Start()
    {
        Debug.Log("Hello from ILRuntime.");

        var core = XCore.GetMainInstance();
        var uikit = core.Services.Get<IUIKit>();

        uikit.OpenUIAsync("Assets/UI/SetDebug.prefab", new SetDebug(), (entity, exception) =>
        {
            if (exception != null)
            {
                Debug.LogError(exception);
            }
        });

        var vfs = core.Services.Get<IVFS>();
        vfs.LoadSceneAsync("Assets/Scenes/Debug.unity", (scene, exception) =>
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