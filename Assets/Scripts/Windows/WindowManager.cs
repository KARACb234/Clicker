using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField]
    private WindowBase[] windowPrefabs;
    private Stack<WindowBase> windows = new Stack<WindowBase>();

    public static WindowManager Instance;

    public void Awake()
    {
        Instance = this;
    }

    public void Show<T>() where T : WindowBase
    {
        foreach(WindowBase window in windowPrefabs)
        {
            if (window is T)
            {
                Debug.Log("открываю окно " + window.GetType());
                CreateOrOpen(window);
            }
        }
    }
    public void Hide<T>() where T : WindowBase
    {
        foreach (WindowBase window in windowPrefabs)
        {
            if (window is T)
            {
                Debug.Log("закрываю окно " + window.GetType());
                CloseWindow(window);
            }
        }
    }
    private void CreateOrOpen(WindowBase windowBase)
    {
        if (HasWindowInStack(windowBase))
        {
            OpenWindow(windowBase);
        }
        else
        {
            CreateWindow(windowBase);
        }
    }

    private void CreateWindow(WindowBase window)
    {
        WindowBase newWindow = Instantiate(window, transform);
        newWindow.Show();
        windows.Push(newWindow);
    }

    private void OpenWindow(WindowBase window)
    {
        foreach (WindowBase windowInStack in windows)
        {
            if (window.GetType() == windowInStack.GetType())
            {
                windowInStack.gameObject.SetActive(true);
                windowInStack.Show();
            }
        }
    }
    private void CloseWindow(WindowBase window)
    {
        Destroy(window.gameObject);
    }
    private bool HasWindowInStack(WindowBase window)
    {
        foreach(WindowBase windowInStack in windows)
        {
            if(windowInStack.GetType() == window.GetType())
            {
                return true;
            }
        }
        return false;
    }

    public void Back()
    {
        Debug.Log(windows.Count);
        if(windows.Count <= 2) return;
        CloseWindow(windows.Pop());
    }

    public bool TryGetWindow<T>(out WindowBase windowBase) where T : WindowBase
    {
        foreach (WindowBase window in windowPrefabs)
        {
            if (window is T)
            {
                windowBase = window;
                return true;
            }
        }
        windowBase = null;
        return false;
    }
}
