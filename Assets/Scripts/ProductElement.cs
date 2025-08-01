using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductElement : MonoBehaviour
{
    [SerializeField]
    private Image _icon;
    public void Initialize(Sprite icon)
    {
        _icon.sprite = icon;
    }
}
