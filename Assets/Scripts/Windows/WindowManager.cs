using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField]
    private WindowBase[] windowPrefabs;
    private Stack<WindowBase> windows;

    public void Show<T>() where T : WindowBase
    {
        foreach(WindowBase window in windows)
        {
        }
    }
}
