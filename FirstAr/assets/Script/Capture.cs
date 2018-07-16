using UnityEngine;
using System.Collections;
using System.IO;

public class Capture : MonoBehaviour {
 
    string filename;

 

    public  void OnMouseDown()
    {
        string path = Application.persistentDataPath;
        path = path.Substring(0, path.LastIndexOf('/'));
        Application.CaptureScreenshot(Path.Combine(path, filename));

        Debug.Log("filename");
        Debug.Log("Path");

        Debug.Log("path");
    }


    

}
