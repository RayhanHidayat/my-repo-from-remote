using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    // Activating UI Level Complete 
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    // Making game over with restarting the game again
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            // For restarting the game
            Invoke("Restart", restartDelay);
        }
        
    }

    // For restarting the game
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
