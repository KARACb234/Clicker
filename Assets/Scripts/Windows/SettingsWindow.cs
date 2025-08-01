using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SettingsWindow : WindowBase
{

    public void OnCloseWindow()
    {
        WindowManager.Instance.Back();
    }
    public void OnOpenAboutMe()
    {
        WindowManager.Instance.Show<AboutMeWindow>();
        Debug.Log("рек");
    }
}
