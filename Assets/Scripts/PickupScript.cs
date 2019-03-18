using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject particulates, door1, door2, enemy1, enemy2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            door1.GetComponent<Animation>().Play();
            door2.GetComponent<Animation>().Play();
            enemy1.GetComponent<EnemyScript>().enabled = true;
            enemy2.GetComponent<EnemyScript>().enabled = true;
            particulates.GetComponent<ParticleSystem>().Play();
            particulates.GetComponent<SelfDestruction>().enabled = true;
            Destroy(gameObject);
        }

    }
}
