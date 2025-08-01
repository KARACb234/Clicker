using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    private ProductsData _productsData;
    private ProductElement _productElement;
    public void Initialize(ProductsData productsData, ProductElement productElement)
    {
        _productsData = productsData;
        _productElement = productElement;
    }

}

