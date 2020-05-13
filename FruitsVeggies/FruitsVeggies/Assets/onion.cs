using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using System;
using System.Linq;

public class onion : MonoBehaviour, ITrackableEventHandler
{

	public GameObject buttonh, buttone, buttons, textH, textE, textS;
	private TrackableBehaviour mTrackableBehaviour;	
    // Start is called before the first frame update
    void Start()
    {
        //mybutton = GetComponent<Button> ();
	buttonh.SetActive(true);
	buttone.SetActive(true);
	buttons.SetActive(true);
		textH.SetActive(false);
		textE.SetActive(false);
		textS.SetActive(false);

	
	mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        	if (mTrackableBehaviour)
        	{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
        	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonInteractH()
    {
        textH.SetActive(true);

	
			textE.SetActive(false);
			textS.SetActive(false);
	//t1.SetActive(true);
        Debug.Log("Button Pressed");
    }

 public void ButtonInteractE()
    {
        textE.SetActive(true);

	textH.SetActive(false);
			
	textS.SetActive(false);
	//t1.SetActive(true);
        Debug.Log("Button Pressed");
    }

 public void ButtonInteractS()
    {
        textS.SetActive(true);

	textH.SetActive(false);
	textE.SetActive(false);
			//t1.SetActive(true);
        Debug.Log("Button Pressed");
    }


	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
	{
        	if (newStatus == TrackableBehaviour.Status.DETECTED ||newStatus == TrackableBehaviour.Status.TRACKED ||newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        	{
			buttons.SetActive(true);	
			buttonh.SetActive(true);	
			buttone.SetActive(true);	
			
}
		else
		{
			buttons.SetActive(false);	
			buttonh.SetActive(false);	
			buttone.SetActive(false);
			textH.SetActive(false);
			textE.SetActive(false);
			textS.SetActive(false);
	
			
}	
        	
    	}	



	//public void disable()
	//{
	//	button.SetActive(false);
	//}
}