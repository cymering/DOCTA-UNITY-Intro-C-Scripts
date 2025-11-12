using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate: MonoBehaviour
{   
    [SerializeField] float speed;
    [SerializeField] Transform transformDelObjeto;

    void Awake()
    {
        Debug.Log("Debug script is active. AWAKE " +  transformDelObjeto.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Debug START");
        Debug.Log("Start " + transformDelObjeto.name + " " + transformDelObjeto.rotation);
        speed = 3.0F;
    }

    // Update is called once per frame
    void Update()
    {
        transformDelObjeto.Rotate(Vector3.up * speed * (Time.deltaTime * 1000));
       
        if ((speed * Time.deltaTime) < 1)
            transformDelObjeto.Translate(Vector3.forward * 0.01F);
       
           
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(transformDelObjeto.name + " colisionó con " + collision.gameObject.name);
        speed = 0;
       
    }
}
