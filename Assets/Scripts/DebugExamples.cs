using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExamples : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Debug script is active. AWAKE");
    }

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Debug START");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Debug UPDATE");
    }

    void LateUpdate()
    {
        Debug.Log("Debug LATEUPDATE");
    }

    void FixedUpdate()
    {
        Debug.Log("Debug FIXUPDATE");
    }
}
