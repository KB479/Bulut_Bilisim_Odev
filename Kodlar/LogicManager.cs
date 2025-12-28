using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText; 
    public GameObject gameOverScreen;
    public TextMeshProUGUI infoText;




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            infoText.gameObject.SetActive(false);
        }
    }





    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
