using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public void LoadGameLevel()
    {
        Application.LoadLevel("MainScene"); //legacy
                                       //  SceneManager.LoadScene("Game"); //new way same function
    }
}
