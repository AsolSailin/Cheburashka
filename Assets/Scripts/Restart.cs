using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(Click);
    }

    private void Click()
    {
        HeartMinus.count = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
