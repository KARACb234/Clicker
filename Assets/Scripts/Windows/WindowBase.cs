using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
[RequireComponent(typeof(CanvasGroup))]
public class WindowBase : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    private const float SHOW_DURATION = 1;
    private void Awake()
    {
    }
    private void OnEnable()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;
    }
    public virtual void Show()
    {
        _canvasGroup.DOFade(1, SHOW_DURATION);
    }
    public virtual void Hide()
    {
        _canvasGroup.DOFade(0, SHOW_DURATION);
    }
}
