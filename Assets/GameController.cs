using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("barrier"))
        {
            Debug.Log("hit!");
            PlayerManager.isGameOver = true;
            GetComponent<PlayerMovement>().enabled = false;
            //gameObject.SetActive(false);
        }
    }

   
}
