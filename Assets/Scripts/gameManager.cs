using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool isPaused;
    static bool isPlayerDead;
    static bool hasWon;
    public GameObject loseScreen;
    public GameObject winScreen;
    public GameObject pickupScreen;
    // Use this for initialization
    void Start()
    {
        isPlayerDead = false;
        loseScreen.SetActive(false);
        winScreen.SetActive(false);
        pickupScreen.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerDead)
        {
            isPaused = true;
            loseScreen.SetActive(true);
        }
        else if (hasWon)
        {
            isPaused = true;
            winScreen.SetActive(true);
        }

        if (isPaused)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    public static void winGame()
    {
        hasWon = true;
    }
    public static void playerDead()
    {
        isPlayerDead = true;
    }

    public void restart()
    {
        isPlayerDead = false;
        SceneManager.LoadScene(0);
    }
}