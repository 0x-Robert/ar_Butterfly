using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour {

    void OnCollisionEnter(Collision other) 
    {
        

        other.gameObject.SetActive(false);
    }
}
