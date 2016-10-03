using UnityEngine;
using System.Collections;

public class OnTriggerEntryshot : MonoBehaviour {

    public GameObject gb1;
    public GameObject gb2;
    void OnTriggerEnter(Collider other)
    {
        gb1.SetActive(true);
        gb2.SetActive(true);

    }
    void OnTriggerExit(Collider other)
    {
        gb1.SetActive(false);
        gb2.SetActive(false);
    }
}
