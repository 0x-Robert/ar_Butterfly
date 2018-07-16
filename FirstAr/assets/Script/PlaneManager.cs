using UnityEngine;
using System.Collections;

public class PlaneManager : MonoBehaviour {



    public GameObject plane;
    public float spawnTime = 0.1f;
    float deltaSpawnTime = 0.0f;

    GameObject[] planepool = null;
    int poolSize = 10;


    void Start()
    {
       
        planepool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; ++i)
        {
            planepool[i] = Instantiate(plane) as GameObject;
            planepool[i].name = "Plane_" + i;
            planepool[i].SetActive(false);
        }
    }


    void Update()
    {



        deltaSpawnTime += Time.deltaTime;


        if (deltaSpawnTime > spawnTime)
        {
            deltaSpawnTime = 0.0f;

            for (int i = 0; i < poolSize; ++i)
            {
                GameObject planeObj = planepool[i];
                if (planeObj.activeSelf == true)

                    continue;

                planeObj.SetActive(true);


                Vector3 spawnPos =new Vector3(-1,0,0) * Random.Range(1.0f, 5.0f);
                spawnPos.x = Random.Range(10.0f, 30.00f);
                spawnPos.z = 0;
                spawnPos.y = Random.Range(-6.0f, 2.0f);
                planeObj.transform.position = spawnPos;
                break;

            }

          


            if (plane)
            {
                Debug.Log(plane);
            }

        }






    }
}
