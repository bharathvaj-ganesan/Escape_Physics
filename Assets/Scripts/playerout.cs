using UnityEngine;
using System.Collections;

public class playerout : MonoBehaviour
{


    public GameObject gb1;
    public GameObject gb2;
    public GameObject gb3;
    public GameObject gb4;

    

    void OnTriggerEnter(Collider col)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        gb1.SetActive(false);
        gb2.SetActive(false);
        gb3.SetActive(false);
        gb4.SetActive(false);
    }
}