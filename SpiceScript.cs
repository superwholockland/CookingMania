using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpiceScript : MonoBehaviour, IPointerClickHandler
{
    public Image ThymeImage;
    public Image PepperFlakesImage;
    public Image ParsleyImage;

    private SpiceManager SM;
    public GameObject SpiceManager;

    public void Start()
    {
        SM = SpiceManager.GetComponent<SpiceManager>();
        ThymeImage.gameObject.SetActive(true);
        PepperFlakesImage.gameObject.SetActive(true);
        ParsleyImage.gameObject.SetActive(true);
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (this.gameObject.tag == "Thyme")
        {
            ThymeImage.gameObject.SetActive(false);
            SM.Thyme = false;
            //Debug.Log("Clicked on Thyme");
            //Debug.Log("Thyme Bool " + SM.Thyme);
        }
        if (this.gameObject.tag == "Parsley")
        {
            ParsleyImage.gameObject.SetActive(false);
            SM.Parsley = false;
            //Debug.Log("Clicked on parsley");
            //Debug.Log("Parsley Bool " + SM.Parsley);
        }
        if (this.gameObject.tag == "RedPepper")
        {
            PepperFlakesImage.gameObject.SetActive(false);
            SM.RedPepper = false;
            //Debug.Log("Clicked on redpepper");
            //Debug.Log("Red Pepper Bool " + SM.RedPepper);
        }
    }
}
