using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMeWindow : WindowBase
{
    public void OnCloseWindow()
    {
        WindowManager.Instance.Back();
    }
}
