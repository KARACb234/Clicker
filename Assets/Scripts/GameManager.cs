using SaveSystem;
using System.Collections;
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
        
        WindowManager.Instance.Show<BackgroundWindow>();
        /*
        WindowManager.Instance.Show<MainMenuWindow>();
        WindowManager.Instance.Show<ShopWindow>();
        WindowManager.Instance.Show<BackgroundWindow>();
        WindowManager.Instance.Hide<MainMenuWindow>();
        */
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
