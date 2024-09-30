using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Game over screen hidden
    public static bool isGameOver;
     
    public GameObject gameOverScreen;

    private TimeManager timeManager;
    public void Awake()
    {
        isGameOver = false;
    } 




    // Start is called before the first frame update
    void Start()
    {
        timeManager = FindAnyObjectByType<TimeManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gameover shows the screen
        if(isGameOver)
        {
            //Debug.Log("Game Over Triggered!");

             if (!gameOverScreen.activeInHierarchy)
             {
                Debug.Log("Displaying Game Over Screen");
                gameOverScreen.SetActive(true);
             }
        }
        
    }
    
    //Replay game function
    public void ReplayLevel()
    {
        // SceneManager.LoadScene("Level 1");
        
        isGameOver = false;

        // Deactivate the game over screen
        gameOverScreen.SetActive(false);

        //Reset the timer
        timeManager.ResetTime();

        // Reload the scene
        SceneManager.LoadScene("Level 1");

    }
}
