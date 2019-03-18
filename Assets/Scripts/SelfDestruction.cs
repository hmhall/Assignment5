using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(Wait());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        //This is a coroutine
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
