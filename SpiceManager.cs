using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiceManager : MonoBehaviour
{
    private ButtonScript BS;
    public GameObject UIManager;

    [SerializeField] public bool Thyme = true;
    [SerializeField] public bool RedPepper = true;
    [SerializeField] public bool Parsley = true;
    private bool checkIfImageChanged = false;

    public void Start()
    {
        BS = UIManager.GetComponent<ButtonScript>();
    }

    public void Update()
    {
        if (Thyme == false && RedPepper == false && Parsley == false && checkIfImageChanged == false)
        {
            Debug.Log("SpiceManager says all needed spices are now false");
            Debug.Log("background change from spice prep to chopping prep");
            BS.SpicePrepToChop();
            checkIfImageChanged = true;
        }
    }
}
