using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    [SerializeField] int maxHealth;
    private bool destroyed = false;
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            destroyed= true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bullet>() != null) //colliding object is a bullet
        {
            var bullet = collision.gameObject.GetComponent<Bullet>(); //setting collision object to bullet
            health -= bullet.getBullet(); //removing damage from health
        }
    }

    public bool getDestroyed()
    {
        return destroyed;
    }

}
