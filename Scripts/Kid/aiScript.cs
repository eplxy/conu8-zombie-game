using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiScript : MonoBehaviour
{


    private int hitpoints = 1;
    private GameObject player;
    float speed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        checkHealth();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Bullet")
            hitpoints--;
    }

    void checkHealth()
    {
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
;

        }

    }



}
