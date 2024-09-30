using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvL2finishLine : MonoBehaviour
{
    public GameObject youWinPanel; // Reference to YouWin panel
    public float delayBeforeNextLevel = 2f; // Time before transitioning to next level
    // Start is called before the first frame update
    void Start()
    {
        youWinPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if(other.gameObject.CompareTag("Player"))
        // {
        //     SceneManager.LoadScene("Level 2");
        // } 

        if(other.gameObject.CompareTag("Player"))
        {
            youWinPanel.SetActive(true);  // Show the YouWin panel
            Time.timeScale = 0f;          // Stop game movement
            StartCoroutine(LoadNextLevelAfterDelay()); // Start delay before loading next level
        }
    }

    IEnumerator LoadNextLevelAfterDelay()
    {
       yield return new WaitForSeconds(delayBeforeNextLevel);
       SceneManager.LoadScene("Level 2");
        
    }

    public void ReplayGame()
    {
        Time.timeScale = 1f; // Resume game time
        youWinPanel.SetActive(false); // Hide the YouWin panel

        //rest time
        TimeManager timeManager = FindAnyObjectByType<TimeManager>();
        if (timeManager != null)
        {
            timeManager.ResetTime(); //call rest method
        }


        SceneManager.LoadScene("Level 1"); // Load Level 1 again
    }


}
