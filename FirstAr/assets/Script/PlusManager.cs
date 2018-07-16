using UnityEngine;
using System.Collections;

public class PlusManager : MonoBehaviour {


    Transform playerTransform;

    public GameObject star;
    public float spawnTime = 0.1f;
    float deltaSpawnTime = 0.0f;
  

    //  int enemyLeft = 0;

    GameObject[] starPool = null;
    int poolSize = 10;


    void Start()
    {
       

        playerTransform = GameObject.FindWithTag("Player").transform;

        starPool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; ++i)
        {
            starPool[i] = Instantiate(star) as GameObject;
            starPool[i].name = "Star_" + i;
            starPool[i].SetActive(false);
        }




    }


    void Update()
    {

        deltaSpawnTime += Time.deltaTime;


        if (deltaSpawnTime > spawnTime)
        {
            deltaSpawnTime = 0.0f;
            //     GameObject enemyObj = Instantiate(enemy) as GameObject;
            for (int i = 0; i < poolSize; ++i)
            {
                GameObject starObj = starPool[i];
                if (starObj.activeSelf == true)
                  
                    continue;

                starObj.SetActive(true);
                // float x = Random.Range(-20.0f, 20.0f);
                // enemyObj.transform.position = new Vector3(x, 0.1f, 20.0f);

               

                Vector3 spawnPos = new Vector3(-1, 0, 0) * Random.Range(1.0f, 3.0f);
                spawnPos.x = Random.Range(10.0f, 14.00f);
                spawnPos.z = 0;
                spawnPos.y = Random.Range(-3.0f, 4.0f);
                starObj.transform.position = spawnPos;
                break;

            }

            /*    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                 enemyLeft = enemies.Length;

                 if (enemyLeft == 10)
                 {
                     Destroy(gameObject);
                 }
                 //   배열로 10마리 생성제한    */







            //end of it 






            if (star)
            {
                Debug.Log(star);
            }

        }






    }
}

	
	

