using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuManager : MonoBehaviour 
{
    public void GoTo(int scene)
    {
        Application.LoadLevel(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void ToggleVisible(Animator anim)
    {
        if (anim.GetBool("isDisplayed"))
        {
            anim.SetBool("isDisplayed", false);
        }
        else
        {
            anim.SetBool("isDisplayed", true);
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
