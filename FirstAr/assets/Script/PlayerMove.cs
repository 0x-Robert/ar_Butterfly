using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public GameObject gameOvertext;
    public GameObject restarttext;
    bool isDead = false;
    public GameObject heart;

    float distance = 10;

    void Awake()
    {
        gameOvertext.SetActive(false);
    }
    void Start()
    {
       // heart.SetActive(true);
        /*   for (int i = 0; i < 3; i++)
        {
            Instantiate
                (heart, new Vector3(i * 2.0f, 5.3f, 0), Quaternion.identity);
        }*/




    }


    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

  void  OnCollisionEnter (Collision other)
    {
        if( other.gameObject.tag == "Enemy")
        {
           
           // heart.SetActive(false);
            //heart.SetActive(false);
            gameOvertext.SetActive(true);
            restarttext.SetActive(true);
            Time.timeScale = 0;
            if (isDead == true)
            {
                
                return;
                    
            }
        }
    }

   
}