using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BoostersData", menuName = "Products Data", order = 51)]
public class ProductsData : ScriptableObject
{
    [SerializeField]
    private string _productName;
    public string ProductName => _productName;
    [SerializeField, TextArea(3, 7)]
    private string description;
    [SerializeField]
    private int price;
    [SerializeField]
    private Sprite icon;
    public Sprite IconSprite => icon;

}
