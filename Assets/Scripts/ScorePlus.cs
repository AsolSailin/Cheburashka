using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlus : MonoBehaviour
{
    [SerializeField]
    private Text _score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        var text = int.Parse(_score.text);
        text++;
        _score.text = text.ToString();
    }
}
