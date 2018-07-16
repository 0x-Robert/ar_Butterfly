using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
public class Restart : MonoBehaviour {
  

    public void OnGameStart() //Ui버튼 호출 
    {
        // Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(0);
         Time.timeScale = 1;//시간의흐름 1일경우 정상,2일경우 2배 
        return;
    }



}

