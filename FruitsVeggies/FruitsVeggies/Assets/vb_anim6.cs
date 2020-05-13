using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim6 : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject vbButton1,text1,vbButton2,text2,vbButton3,text3;
    // Start is called before the first frame update
	public string vbName;
    void Start()
    {
        vbButton1 = GameObject.Find("BTHindiPapaya");
	//text1 = GameObject.Find("HindiText");
	vbButton1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	text1.SetActive(false);
        vbButton2 = GameObject.Find("BTEnglishPapaya");
	//text2 = GameObject.Find("EnglishText");
	vbButton2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	text2.SetActive(false);
	vbButton3 = GameObject.Find("BTSanskritPapaya");
	//text1 = GameObject.Find("HindiText");
	vbButton3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	text3.SetActive(false);
    }
	
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		vbName =  vb.VirtualButtonName;
		if(vbName=="BTHindiPapaya")
		{
		text1.SetActive(true);
		text2.SetActive(false);
		text3.SetActive(false);
		}
		else if(vbName=="BTEnglishPapaya")
		{
		text2.SetActive(true);
		text1.SetActive(false);
		text3.SetActive(false);
		}
		else if(vbName=="BTSanskritPapaya")
		{
		text3.SetActive(true);
		text1.SetActive(false);
		text2.SetActive(false);
		}
		Debug.Log("Button Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		text3.SetActive(false);
		text1.SetActive(false);
		text2.SetActive(false);
		
		Debug.Log("Button Released");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
