using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

    private WebCamTexture webcamTexture;
    private GUITexture BackgroundTexture;
    void Start()
    {
        Debug.Log("카메라셋팅");
        GetComponent<GUITexture>().pixelInset = new Rect(0, 0, Screen.width, Screen.height);

        webcamTexture = new WebCamTexture();
        webcamTexture.requestedWidth = 1920;
        webcamTexture.requestedHeight = 1080;
        webcamTexture.Play();


        GetComponent<GUITexture>().texture = webcamTexture;


    }

}

