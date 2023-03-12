using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    //public Vector3[] pos = new Vector3[2];
    private int count = 0;
    public GameObject[] wall = new GameObject[2];
    // Start is called before the first frame update
    
    void Start()
    {
        
        InvokeRepeating("SpawnWall", 1, 2);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnWall()
    {
        //GameObject randomAnimal = animals[Random.Range(0, 2)];
        //Vector3 randomPos = new Vector2(Random.Range(-10f, 10f), 4.9f);
        Instantiate(wall[Random.Range(0, 2)], new Vector3(15, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));

    }

}
