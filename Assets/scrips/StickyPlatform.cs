using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
        
    {
        Debug.Log("Platform collision detected: " + collision.gameObject.name);
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
            Debug.Log("Player hit platform.");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
