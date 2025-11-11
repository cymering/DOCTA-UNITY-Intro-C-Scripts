using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate: MonoBehaviour
{   
    [SerializeField] float speed;

    [SerializeField] Transform transformDelObjeto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transformDelObjeto.Rotate(Vector3.up * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        speed = 0;
    }
}
