using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneButton : MonoBehaviour
{
    public void GoToNextScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
