using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Falling : MonoBehaviour
{


    [SerializeField] Transform transformDelObjeto;
    [SerializeField] float speed1;
 

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
       transformDelObjeto.Translate(Vector3.down * speed1);

    }
}
