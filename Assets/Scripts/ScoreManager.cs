using Assets.Scripts;
using SaveSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    private float _money;
    public float GetMoney => _money;
    private int _diamond = 0;
    public int GetDiamond => _diamond;
    [SerializeField]
    private ShellPanel _shellPanel;
    private PointUtils _pointUtils = new PointUtils();
    private BusterController _busterController;  


    private void Awake()
    {
        _busterController = GetComponentInChildren<BusterController>();
    }
    private void Start()
    {
        LoadData();
        UpdateShell();
    }

    public void AddMoney()
    {
        float extraPointsPerClick = 40;
        float multiplier = _busterController.GetMultiply();
        Debug.Log(multiplier);
        float money = _pointUtils.PointsCalculation(extraPointsPerClick, multiplier);
        _money += money;
        UpdateShell();
        Saver.Instance.GetPlayerData.UpdateMoney(_money);
        Saver.Instance.Save();
    }


    private void LoadData()
    {
        var playerData =  Saver.Instance.Load();
        _money = playerData.money;
        _diamond = playerData.diamond;
        UpdateShell();
    }
    private void UpdateShell()
    {
        _shellPanel.UpdateMoneyInfo(_money);
        _shellPanel.UpdateDiamondInfo(_diamond);
    }

}
