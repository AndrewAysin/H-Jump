using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public static bool isGameWin;
    public GameObject gameWinScreen;

    private void Awake()
    {
        isGameOver = false;
        isGameWin = false;
    }
    
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            
        }
        if (isGameWin)
        {
            gameWinScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
