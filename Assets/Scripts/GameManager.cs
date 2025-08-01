using Assets.Scripts;
using SaveSystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerData _playerData;
    [SerializeField]
    private InputHandler inputHandler;
    private BaseController _baseController;
    private Saver _saver;
    private void Awake()
    {
        _baseController = new BaseController(this);
        _saver = new Saver(_baseController);
        StartCoroutine(SaveCicle());
    }

    private IEnumerator SaveCicle()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            _saver.Save();
        }
    }
}
