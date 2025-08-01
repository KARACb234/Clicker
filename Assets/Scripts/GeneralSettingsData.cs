using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GeneralSettingsData", menuName = "General Settings Data")]
public class GeneralSettingsData : ScriptableObject
{
    [SerializeField]
    private float _energetikGenerateChance;
    public float GetEnergetikGenerateChance => _energetikGenerateChance;
    [SerializeField]
    private float _energetikActiveTime;
    public float GetEnergetikActiveTime => _energetikActiveTime;



    [SerializeField]
    private float _insightGenerateChance;
    public float GetinsightGenerateChance => _insightGenerateChance;
    [SerializeField]
    private float _insightActiveTime;
    public float GetinsigtActiveTime => _insightActiveTime;
}
