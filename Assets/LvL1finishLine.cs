using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvL1finishLine : MonoBehaviour
{
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 2");
        } 

        
    }



}
