using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Rotate: MonoBehaviour
{   
    [SerializeField] float speed;
    [SerializeField] Transform transformDelObjeto;
    //[SerializeField] TMP_Text saludo;

   float tiempo_de_comienzo; 
    float tiempo_de_collision; 
    void Awake()
    {
        tiempo_de_comienzo = Time.time;
        Debug.Log("Debug script is active. AWAKE " +  transformDelObjeto.name);
        Debug.Log("Tiemp de comienzo: " + tiempo_de_comienzo);

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Debug START");
        Debug.Log("Start " + transformDelObjeto.name + " " + transformDelObjeto.rotation);
        speed = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transformDelObjeto.Rotate(Vector3.up * speed * (Time.deltaTime * 1000));
      
        if ((speed * Time.deltaTime) < 1)
            transformDelObjeto.Translate(Vector3.forward * 0.01F);   

        //saludo.text = "Hola! Estoy rotando a una velocidad de " + speed.ToString("F2");

    }

    private void OnCollisionEnter(Collision collision)
    {
        tiempo_de_collision = Time.time;
        Debug.Log(transformDelObjeto.name + " colisionó con " + collision.gameObject.name + " at " + Time.time);
        Debug.Log(tiempo_de_collision - tiempo_de_comienzo + " segundos después de comenzar.");
        speed = 0;
       
    }
}
