using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class BusterController : MonoBehaviour
{
    private int chance = 0;
    [SerializeField]
    private GeneralSettingsData _generalSettings;
    private float _multiplier = 1f;
    [SerializeField]
    private BoostersData[] _boostersData;
    [SerializeField]
    private Buster _boosterPrefab;
    private List<Buster> boosts = new List<Buster>();
    [SerializeField]
    private Transform _busterContainer;
    [SerializeField]
    private BustersElement _bustersElement;
    // Start is called before the first frame update
    void Start()
    {
        CreateBusters();
        RecalculateMultiplier();
        StartCoroutine(BusterUpdater());
    }
    private void CreateBusters()
    {
        foreach(var data in _boostersData)
        {
            Buster boost = Instantiate(_boosterPrefab, transform);
            BustersElement element = Instantiate(_bustersElement, _busterContainer);
            element.Initialize(data.IconSprite);
            boost.Initialize(data, element);
            boosts.Add(boost); 
        }
    }
    public IEnumerator BusterUpdater()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            foreach (var buster in boosts)
            {
                if (buster.IsActivate == false)
                {
                    chance = Random.Range(0, 100);
                    if (chance < buster.GetSpawnChance())
                    {
                        if(buster.TryActivate() == true)
                        {
                            RecalculateMultiplier();
                            print($"{buster.GetName()} был активирован");
                        }
                    }
                }
            }
        }
    }
    private void RecalculateMultiplier()
    {
        var multiplier = 1f;
        foreach (var bust in boosts)
        {
            if (bust.IsActivate == true)
            {

                if (bust.GetAmount() <= 1f)
                {
                    multiplier = multiplier * bust.GetAmount();
                }
                else
                {
                    float p = bust.GetAmount() - 1;
                    multiplier = multiplier + p;
                }
            }
        }
        _multiplier = multiplier;
    }
    public float GetMultiply()
    {
        return _multiplier;
    }
        
}