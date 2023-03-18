using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //etot script otvechaet za proigrovanie zvukov 
    public AudioSource audioSource;
    //
    public AudioClip damageSound;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int damage = 2;
    public int health = 10;
    public int dmg = 2;


    public void TakeDamage(int damage)
    {
        dmg = 2;
        health -= dmg;
        print("zdorovye igroka "+health);

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}

