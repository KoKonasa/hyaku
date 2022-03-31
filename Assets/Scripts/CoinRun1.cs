
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinRun1 : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float x_val;
    public float force;
    public float maxspeed;
    public float hp;
    public float damage;
    public float damegefire;
    public float speed;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "DeadArea")
        {

            SceneManager.LoadScene("GameOver");
        }

        if (other.gameObject.tag == "Goal")
        {

            SceneManager.LoadScene("GameClear");
        }
        if (other.gameObject.tag == "HitArea")
        {

            hp -= damage;
            Debug.Log(hp);
        }
        if (other.gameObject.tag == "Fire")
        {

            hp -= damegefire;
            Debug.Log(hp);
        }
        if (other.gameObject.tag == "Drop")
        {

            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Drop")
        {
            // Õ“Ë‚µ‚½‘ŠŽè‚ðˆÅ‚Ì”Þ•û‚ÉÁ‚µ‹Ž‚è‚Ü‚·B
            Destroy(other.gameObject);
        }
    }

        void Update()
        {
            x_val = Input.GetAxis("Horizontal");
        }
        void FixedUpdate()
        {


            //‰E‚ÉˆÚ“®
            if (x_val > 0)
            {
                if (rb2d.velocity.magnitude < maxspeed)
                {
                    rb2d.AddForce(new Vector2(force, 0));
                }

            }
            //¶‚ÉˆÚ“®
            else if (x_val < 0)
            {
                if (rb2d.velocity.magnitude < maxspeed)
                {
                    rb2d.AddForce(new Vector2(force * (-1), 0));
                }

            }
            if (hp <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        speed = rb2d.velocity.magnitude;
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("StageSelect");
        }
    }

    }
