using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    float movement;
    [SerializeField]
    Rigidbody shot;
    Vector3 upALil=new Vector3(0,1f,0);


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -2, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 2, 0);
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody boolet;
            boolet = Instantiate(shot, transform.position+transform.forward+upALil, transform.rotation);
            boolet.velocity = transform.TransformDirection(Vector3.forward);
        }

        movement = Input.GetAxis("Vertical");
        anim.SetFloat("Movement", movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
        }

    }

}
