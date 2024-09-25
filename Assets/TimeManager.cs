using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime;
    private float countingTime;

    private Text theText;

    //private PauseMenu thePauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        countingTime = startingTime;
        theText = GetComponent<Text>();
        
        //thePauseMenu = FindAnyObjectByType<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(PauseMenu.activeSelf)

        countingTime -= Time.deltaTime; //will slowly decrease the time 

        if(countingTime <= 0)
        {
                //game over
        }

        theText.text = "" + Mathf.Round(countingTime);
   
    }

    public void RestTime()
    {
        countingTime = startingTime;

    }
}
