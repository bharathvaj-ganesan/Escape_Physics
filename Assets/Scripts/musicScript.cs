using UnityEngine;
using System.Collections;


public class musicScript : MonoBehaviour {
    static bool AudioBegin = false;
    GameObject otherSound;

    void Awake()
    {
        otherSound = GameObject.FindGameObjectWithTag("bgm");

        if (otherSound == this.gameObject)
        {
            if (!AudioBegin)
            {
                DontDestroyOnLoad(this.gameObject);
                AudioBegin = true;
            }
        }
        else
        {
            Destroy(this.gameObject);
        }



    }
}
