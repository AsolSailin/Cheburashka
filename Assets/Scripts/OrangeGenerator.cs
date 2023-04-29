using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _orangePrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            var rnd = Random.Range(0, 4);
            switch (rnd)
            {
                case 0:
                    transform.position = new Vector3(-6.5f, 3.5f, 0);
                    Instantiate(_orangePrefab, transform.position, Quaternion.identity);
                    break;
                case 1:
                    transform.position = new Vector3(-6.5f, 1f, 0);
                    Instantiate(_orangePrefab, transform.position, Quaternion.identity);
                    break;
                case 2:
                    transform.position = new Vector3(6.5f, 3.5f, 0);
                    Instantiate(_orangePrefab, transform.position, Quaternion.identity);
                    break;
                case 3:
                    transform.position = new Vector3(6.5f, 1f, 0);
                    Instantiate(_orangePrefab, transform.position, Quaternion.identity);
                    break;
            }
            yield return new WaitForSeconds(3f);
        }
    }
}
