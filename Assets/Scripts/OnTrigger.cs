using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour
{

    public GameObject gb;

    void OnTriggerEnter(Collider other)
    {
        gb.GetComponent<MeshRenderer>().enabled = false;
        
    }
}