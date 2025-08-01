using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopWindow : WindowBase
{
    public void OnCloseWindow()
    {
        WindowManager.Instance.Back();
    }
}
