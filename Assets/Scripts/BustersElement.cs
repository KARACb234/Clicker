using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BustersElement : MonoBehaviour
{
    [SerializeField]
    private Image _progressImage;
    [SerializeField]
    private Image _icon;

    // Update is called once per frame
    public void Initialize(Sprite icon)
    {
        _icon.sprite = icon;
    }
    public void UpdateProgress(float progress)
    {
        _progressImage.fillAmount = progress;
    }
}
