using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
    bool gamePause = false;



public	void OnPause()
    {
        gamePause = !gamePause;
        if (gamePause== true)
        {
            Time.timeScale = 0.0f;
        }

         else 
        {
            Time.timeScale = 1.0f;
        }
}
	
}
