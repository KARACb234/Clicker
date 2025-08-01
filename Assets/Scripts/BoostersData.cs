using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BoostersData", menuName = "Boosters Data", order = 51)]
public class BoostersData : ScriptableObject
{
    [SerializeField]
    private string boosterName;
    public string BoosterName => boosterName;
    [SerializeField, TextArea(3, 7)]
    private string description;
    [SerializeField]
    private Sprite icon;
    public Sprite IconSprite => icon;
    [SerializeField]
    private float multiplier;
    public float Multiplier => multiplier;
    [SerializeField]
    private float activeTimePerSeconds;
    public float ActiveTimePerSeconds => activeTimePerSeconds;
    [SerializeField]
    private float reloadTimePerSeconds;
    [SerializeField]
    private float _spawnChance;
    public float SpawnChance => _spawnChance;
}
