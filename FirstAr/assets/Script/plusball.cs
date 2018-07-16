using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class plusball : MonoBehaviour
{
    public GameObject ball = null;
    public float speed = 10;
    public int score = 10;
   
    public float rotationSpeed = 10.0f;


    void Start()
    {
       
        GetComponent<Rigidbody>().velocity = new Vector3(-1,0,0) * speed;
     

    }
 
    

 

    void OnCollisionEnter(Collision other) //물리적충돌사용시에 사용 무너지거나 부딫치는거나 밀린는 작용은 
    {
        //위치
        //this.gameObject;
       
       GameObject obj = Instantiate(ball);
       obj.transform.position = transform.position;
        //ScoreManager.Instance().myScore += score;  
      if (other.gameObject.tag == "Player") //태그값이 에너미일때만 파괴해라 
        {

            gameObject.SetActive(false);
            ball.SetActive(false);
            ScoreManager.Instance().myScore += score;
        }
    }


    

}
