using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

public class GameManager : MonoBehaviour
{

    public Player player;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    private int score;


    private void Awake()
    {
        // at the very beggining we need to pause to actually hit the play button 
        Pause();   
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        
        playButton.SetActive(false);
        gameOver.SetActive(false);

        // do the opposite of pause 
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }

    public void Pause()
    {
        // make sure the whole game is static (bird, pipes, BG and floor )
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
