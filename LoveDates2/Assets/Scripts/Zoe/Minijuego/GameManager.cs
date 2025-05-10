using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Player player;
    public GameObject button;
    public GameObject gameOver;
    public int score;

   
    public void GameOver()
    {
        Debug.Log("Game Over");
        gameObject.SetActive(true);
        button.SetActive(true);
        Pause();    
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        Time.timeScale = 1;
        
        scoreText.text = score.ToString();
        button.SetActive(false);
        gameOver.SetActive(false);

        player.enabled =true;

        
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
