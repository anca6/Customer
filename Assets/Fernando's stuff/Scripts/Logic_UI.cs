using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logic_UI : MonoBehaviour
{
    
  

    public void LoadLevel(string level)
    {

        Debug.Log("Jogo to load: " + level);
        SceneManager.LoadScene(level);

    }

    public void LoadGame(string game)
    {

        Debug.Log("Jogo to load: " + game);
        SceneManager.LoadScene(game);

    }

    public void LoadMenu(string menu)
    {

        Debug.Log("Jogo to load: " + menu);
        SceneManager.LoadScene(menu);

    }

    public void LeaveGame()
    {
        Application.Quit();
    }

}
