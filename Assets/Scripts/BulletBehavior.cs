using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public static BulletBehavior Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && this.gameObject.CompareTag("Player"))
        {
            print("hit " + collision.gameObject.name + " !");
            Destroy(gameObject);
        }
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
