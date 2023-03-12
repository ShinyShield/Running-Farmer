using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private backGround bg;
    private spawner sp;
    private Obstacle obs1;
    private PlayerController player;

    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("SimpleFarmer_Woman_02_White").GetComponent<PlayerController>();

        bg = GameObject.Find("Background").GetComponent<backGround>();
        sp = GameObject.Find("spawner").GetComponent<spawner>();
        obs1 = GetComponent<Obstacle>();
       // obs2 = GameObject.Find("Prop_StoneWall_01(Clone)").GetComponent<Obstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "wall")
        {
            Destroy(collision.gameObject);
        }
        if(collision.transform.tag == "Player")
        {
            //Time.timeScale = 0;
            player.ps.Play();
            sp.CancelInvoke("SpawnWall");
            bg.speed = 0;
            obs1.speed = 0;

            //stop the anim
            //player.SetActive(false);
        }
    }
}
