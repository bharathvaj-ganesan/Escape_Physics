using UnityEngine;
using System.Collections;

public class pauseScript : MonoBehaviour {

    public bool pause;
    public GameObject dark;
    void Start()
    {
        pause = false;
        dark.SetActive(false);
    }
    public void OnPause()
    {
        pause = !pause;
        if(pause)
        {
            dark.SetActive(true);
            Time.timeScale = 0;
            
        }
        else if(!pause)
        {
            dark.SetActive(false);
            Time.timeScale = 1;
            
        }
        
    }
    
}
