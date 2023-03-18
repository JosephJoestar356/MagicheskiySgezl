using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        //vrag zdoh XD
        Enemy enemy = other.GetComponent<Enemy>();

        //patron tosge sdoh XD x2
        Destroy(gameObject);

    }


}
