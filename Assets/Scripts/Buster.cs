using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Buster : MonoBehaviour
{
    private BoostersData _boostersData;
    private bool _isActivate;
    public bool IsActivate => _isActivate;
    private BustersElement _bustersElement;
    public void Initialize(BoostersData boostersData, BustersElement busterElement)
    {
        _boostersData = boostersData;
        _bustersElement = busterElement;
    }

    public float GetAmount()
    {
        return _boostersData.Multiplier;
    }
    public float GetSpawnChance()
    {
        return _boostersData.SpawnChance;
    }
    public string GetName()
    {
        return _boostersData.BoosterName;
    }

    public bool TryActivate()
    {
        if (_isActivate == false)
        {
            StartCoroutine(ActiveTime());
            return true;
        }
        return false;
    }

    public IEnumerator ActiveTime()
    {
        _isActivate = true;
        StartCoroutine(UpdateUi());

        yield return new WaitForSeconds(_boostersData.ActiveTimePerSeconds);
        _isActivate = false;
    }

    public IEnumerator UpdateUi()
    {
        float timer = 0;
        while(timer < _boostersData.ActiveTimePerSeconds)
        {
            timer += Time.deltaTime;
            _bustersElement.UpdateProgress(timer / _boostersData.ActiveTimePerSeconds);
            yield return new WaitForEndOfFrame();
        }
    }
}
