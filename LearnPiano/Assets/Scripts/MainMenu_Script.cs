using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour
{
    public void ChangeScene(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}