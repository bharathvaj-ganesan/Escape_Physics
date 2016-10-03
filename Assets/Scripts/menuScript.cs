using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour
{

    public Canvas quitMenu;
    public Canvas setMenu;
    public Button startText;
    public Button exitText;
    public GameObject gb;
    public GameObject setbutton;
    public GameObject bgm;
    
    
    
    
        
   public void Start ()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        setMenu = setMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        setMenu.enabled = false;
       
        
    }
    public void SetPress()
    {
        gb.SetActive(false);
        quitMenu.enabled = false;
        setMenu.enabled = true;

    }
	
	public void ExitPress()
    {
        quitMenu.enabled = true;
        setMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        gb.SetActive(false);
        setbutton.SetActive(false);
    }

    public void NoPress()
    {

        quitMenu.enabled = false;
        setMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        gb.SetActive(true);
        setbutton.SetActive(true);
    }
    public void BackPress()
    {
        gb.SetActive(true);
        setbutton.SetActive(true);
        quitMenu.enabled = false;
        setMenu.enabled = false;
    }
    public void BgmOn()
    {
        bgm.SetActive(true);
    }
    public void BgmOff()
    {
        bgm.SetActive(false);
    }

public void  StartLevel()
    {

       
   Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
 }

