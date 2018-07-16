using UnityEngine;
using System.Collections;

public class WarPlane : MonoBehaviour {


    public float speed = 10;
    public GameObject particle = null;
    public Transform transform;



    void Start()
    {

       

    }
    void Update()
    {
        transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0) * speed;
    }

    void OnCollisionEnter(Collision other) //물리적충돌사용시에 사용 무너지거나 부딫치는거나 밀린는 작용은 
    {
        if (other.gameObject.tag == "Enemy")
        {
            return;
        }
        if (other.gameObject.tag == "Star")
        {
            return;
        }
        if (other.gameObject.tag == "Player") //태그값이 에너미일때만 파괴해라 
        {
            /* GameObject partObj = Instantiate(particle) as GameObject;
            Vector3 partObjPos = transform.position;
            partObjPos.y = 2.0f;
            partObj.transform.position = partObjPos;*/


        }


    }




}

