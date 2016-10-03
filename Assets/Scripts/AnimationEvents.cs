using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


//This script should be attached to each animated button on the menu 
//(New Game, Load Game, Settings & Quit)
public class AnimationEvents : MonoBehaviour 
{
    Animator thisAnim;

    void Start()
    {
        thisAnim = GetComponent<Animator>();
        SetupEvents();
    }

    void SetupEvents()
    {
        //Holds several different trigger events
        EventTrigger ButtonEventTriggers = gameObject.AddComponent<EventTrigger>();

        //Add a trigger for pointer/mouse down
        EventTrigger.Entry triggerDown = new EventTrigger.Entry();
        triggerDown.eventID = EventTriggerType.PointerDown;
        triggerDown.callback.AddListener((eventData) => { PointerDown(); });
        ButtonEventTriggers.triggers.Add(triggerDown);

        //Add a trigger for pointer/mouse enter
        EventTrigger.Entry triggerEnter = new EventTrigger.Entry();
        triggerEnter.eventID = EventTriggerType.PointerEnter;
        triggerEnter.callback.AddListener((eventData) => { PointerEnter(); });
        ButtonEventTriggers.triggers.Add(triggerEnter);

        //Add a trigger for pointer/mouse exit
        EventTrigger.Entry triggerExit = new EventTrigger.Entry();
        triggerExit.eventID = EventTriggerType.PointerExit;
        triggerExit.callback.AddListener((eventData) => { PointerExit(); });
        ButtonEventTriggers.triggers.Add(triggerExit);

        //Add a trigger for pointer/mouse up
        EventTrigger.Entry triggerUp = new EventTrigger.Entry();
        triggerUp.eventID = EventTriggerType.PointerUp;
        triggerUp.callback.AddListener((eventData) => { PointerUp(); });
        ButtonEventTriggers.triggers.Add(triggerUp);
    }

    public void PointerEnter()
    {
        thisAnim.ResetTrigger("PointerExit");
        thisAnim.SetTrigger("PointerEnter");
    }

    public void PointerDown()
    {
        thisAnim.ResetTrigger("PointerEnter");
        thisAnim.SetTrigger("PointerDown");
    }

    public void PointerUp()
    {
        thisAnim.ResetTrigger("PointerDown");
        thisAnim.SetTrigger("PointerEnter");

    }
    public void PointerExit()
    {
        thisAnim.ResetTrigger("PointerEnter");
        thisAnim.SetTrigger("PointerExit");
    }
}
