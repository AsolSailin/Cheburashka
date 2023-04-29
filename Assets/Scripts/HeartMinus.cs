using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HeartMinus : MonoBehaviour
{
    [SerializeField]
    private GameObject _image;
    [SerializeField]
    private GameObject _heart1;
    [SerializeField]
    private GameObject _heart2;
    [SerializeField]
    private GameObject _heart3;
    [SerializeField]
    private GameObject _button;
    public static int count = 0;
    private bool isActive = false;
    private void Update()
    {
        if (isActive)
        {
            StartCoroutine(Minus());
        }

        if (count == 1)
        {
            _heart1.GetComponent<SpriteRenderer>().material.color = Color.black;
        }
        else if (count == 2)
        {
            _heart2.GetComponent<SpriteRenderer>().material.color = Color.black;
        }
        else if (count == 3)
        {
            _heart3.GetComponent<SpriteRenderer>().material.color = Color.black;
            Time.timeScale = 0.0f;
            _button.SetActive(true);
        }
    }

    private IEnumerator Minus()
    {
        _image.SetActive(true);
        yield return new WaitForSeconds(1f);
        isActive = false;
        _image.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        count++;
        Debug.Log(count.ToString());
        isActive = true;
    }
}
