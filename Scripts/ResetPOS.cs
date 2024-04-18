using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetPOS : MonoBehaviour
{
    Vector3 ogpos;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 ogpos=transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HITWALL"))
        {
            transform.localPosition=ogpos;
        }
        
    }
}
