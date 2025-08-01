using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductController : MonoBehaviour
{
    [SerializeField]
    private ProductsData[] _productsData;
    [SerializeField]
    private Product _productPrefab;
    private List<Product> products = new List<Product>();
    [SerializeField]
    private Transform _productContainer;
    [SerializeField]
    private ProductElement _productElement;
    // Start is called before the first frame update
    void Start()
    {
        CreateProducts();
    }
    private void CreateProducts()
    {
        foreach (var data in _productsData)
        {
            Product product = Instantiate(_productPrefab ,transform);
            ProductElement element = Instantiate(_productElement, _productContainer);
            element.Initialize(data.IconSprite);
            product.Initialize(data, element);
            products.Add(product);
        }
    }
}
