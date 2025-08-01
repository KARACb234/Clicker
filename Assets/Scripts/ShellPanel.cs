using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShellPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI moneyText;
    [SerializeField]
    private TextMeshProUGUI diamondText;
    public void UpdateMoneyInfo(float money)
    {
        moneyText.text = money.ToString("F0");
    }
    public void UpdateDiamondInfo(int diamond)
    {
        diamondText.text = diamond.ToString("F0");
    }
}
