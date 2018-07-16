using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed = 10;
    public Transform target = null;
    
	

	void Start ()
    {
        target = GameObject.Find("Player").transform;

        Vector3 dir = target.position - transform.position;
        dir.y = 0.0f;
        dir.Normalize();
        GetComponent<Rigidbody>().velocity = new Vector3(-1,0,0) * speed;
      
    }

    void OnCollisionEnter(Collision other) //물리적충돌사용시에 사용 무너지거나 부딫치는거나 밀린는 작용은 
    {
      if(other.gameObject.tag== "Enemy")
        {
            return;
        }  
        if(other.gameObject.tag == "Star")
        {
            return;
        }
        
        if (other.gameObject.tag == "Player") //태그값이 에너미일때만 파괴해라 
        {
          
        }
    }


   
}
