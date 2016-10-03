using UnityEngine;
using System.Collections;

public class OnTriggerTourch : MonoBehaviour {

    public GameObject gb;
    void OnTriggerEnter(Collider other)
    {
        gb.SetActive(true);

    }
    void OnTriggerExit(Collider other)
    {
        gb.SetActive(false);
    }
}
