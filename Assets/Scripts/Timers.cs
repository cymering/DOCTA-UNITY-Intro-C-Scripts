using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timers : MonoBehaviour
{
    [SerializeField] float timer1;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Timers script is active. START");
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("timer1" + timer1);
    }
}
