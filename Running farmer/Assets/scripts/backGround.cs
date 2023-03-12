using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class backGround : MonoBehaviour
{
    Vector3 startPos;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < startPos.x - 50)
        {
            gameObject.transform.position = startPos;
        }
        else
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
