using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime;
    private float countingTime;

    private Text theText;
    
    private static TimeManager instance;

    // Access to the PlayerManager
    private PlayerManager playerManager;

    //continue
    void Awake() 
    { 
        
        if (instance == null)
        {
           instance = this;
           DontDestroyOnLoad(transform.root.gameObject); // This will make the entire Canvas persist
        }
        else
        {
           Destroy(gameObject);
        }
    }

    //private PauseMenu thePauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
        countingTime = startingTime;
        theText = GetComponent<Text>();


        //Find player Manager
        playerManager = FindAnyObjectByType<PlayerManager>();
        
        //thePauseMenu = FindAnyObjectByType<PauseMenu>();


    }

    // Update is called once per frame
    void Update()
    {
        // if(PauseMenu.activeSelf)
        string Scene = SceneManager.GetActiveScene().name;
        if (Scene == "Main Menu")
        {
            Destroy(this.gameObject);
        }
        countingTime -= Time.deltaTime; //will slowly decrease the time 

        if(countingTime <= 0)
        {
            countingTime = 0; // Prevents going negative
            PlayerManager.isGameOver = true;
           // playerManager.isGameOver();
        
        }

        theText.text = "" + Mathf.Round(countingTime);
   
    }

    public void ResetTime()
    {
        countingTime = startingTime;

    }


}
