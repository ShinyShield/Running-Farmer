using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbOfPlayer;
    private Animator anim;
    private Animator death;

    public AudioSource jump;
    public AudioSource down;

    public ParticleSystem ps;
    public ParticleSystem run;

    // Start is called before the first frame update
    void Start()
    {
        rbOfPlayer = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        death = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.y > -1 && transform.position.y < 0.5f) && Input.GetKeyDown(KeyCode.Space))
        {
            rbOfPlayer.AddForce(Vector3.up * 400);
            anim.SetTrigger("Jump_trig");
            run.Stop();
            jump.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //ps.Play();
        run.Play();
        if(collision.transform.tag == "gr")
        {
            down.Play();
        }
        
        if(collision.transform.tag == "wall")
        {
            anim.SetTrigger("Death_b");
            run.Stop();
        }
    }
}
