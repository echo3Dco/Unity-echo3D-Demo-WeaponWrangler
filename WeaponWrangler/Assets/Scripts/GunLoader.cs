using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Chooses weapons at random
public class GunLoader : MonoBehaviour
{
    public GameObject[] weapons;
    public int currentWeapon;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomWeapon();
        }
    }

    public void SpawnRandomWeapon()
    {
        // 
        foreach (GameObject weapon in weapons)
        {
            weapon.SetActive(false);
        }

        // Chooses random item from array in Inspector
        int i = Random.Range(0, weapons.Length); 
        weapons[i].SetActive(true); 
        print("Spawning weapons"); 
    }
}
