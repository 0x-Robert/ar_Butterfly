using UnityEngine;
using System.Collections;

public class WarPlaneManager : MonoBehaviour {


    public GameObject warplane;
    public float spawnTime = 0.1f;
    float deltaSpawnTime = 0.0f;

    GameObject[] warplanepool = null;
    int poolSize = 10;


    void Start()
    {

       warplanepool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; ++i)
        {
            warplanepool[i] = Instantiate(warplane) as GameObject;
            warplanepool[i].name = "WarPlane_" + i;
            warplanepool[i].SetActive(false);
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
                GameObject warplaneObj = warplanepool[i];
                if (warplaneObj.activeSelf == true)

                    continue;

                warplaneObj.SetActive(true);


                Vector3 spawnPos = new Vector3(-1, 0, 0) * Random.Range(3.0f, 13.0f);
                spawnPos.x = Random.Range(10.0f, 20.00f);
                spawnPos.z = 0;
                spawnPos.y = Random.Range(-6.0f, 2.0f);
                warplaneObj.transform.position = spawnPos;
                break;

            }




            if (warplane)
            {
                Debug.Log(warplane);
            }

        }






    }
}
