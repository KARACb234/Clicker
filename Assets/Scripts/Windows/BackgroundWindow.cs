using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWindow : WindowBase
{
    private void Start()
    {
        WindowManager.Instance.Show<MainMenuWindow>();
    }
}
