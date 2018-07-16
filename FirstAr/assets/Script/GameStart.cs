using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

    

    public void OnPause()
    {



        if (true)
        { Time.timeScale = 1.0f; }
        else if (false)
        {
            Time.timeScale = 0.0f;
        }

    }

}

