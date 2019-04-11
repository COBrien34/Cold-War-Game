using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuReturnScript : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}