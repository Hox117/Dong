using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AutoDestroy());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
            
        
        AutoDestroy();
    }
    IEnumerator AutoDestroy()
    {
        yield return new  WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
