using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public void Pause ()
    {
        SceneManager.LoadScene("Menu");
    }
}
