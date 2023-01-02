using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifePositionScript : MonoBehaviour
{
    public Image KnifeImage;
    public Image CBImage; //Chicken Breast Image
    public Image GCImage; // Garlic Clove Image
    public Image CompleteBannerImage;
    private ButtonScript BS;
    public GameObject UIManager;

    [SerializeField] public Image GL1Image; //Guideline 1 Image
    [SerializeField] public Image GL2Image; //Guideline 2 Image
    [SerializeField] public Image GL3Image; //Guideline 3 Image
    [SerializeField] public Image GL4Image; //Guideline 4 Image
    [SerializeField] public Image GL5Image; //Guideline 5 Image
    [SerializeField] public Image GL6Image; //Guideline 6 Image
    [SerializeField] public Image GL7Image; //Guideline 7 Image
    [SerializeField] public Image GL8Image; //Guideline 8 Image
    [SerializeField] public Image GL9Image; //Guideline 9 Image

    [SerializeField] public Sprite WholeChkn;
    [SerializeField] public Sprite ChknGuide1;//vertical guide 1
    [SerializeField] public Sprite ChknGuide2;//vertical guide 2
    [SerializeField] public Sprite ChknGuide3;//vertical guide 3
    [SerializeField] public Sprite ChknGuide4;//vertical guide 4
    [SerializeField] public Sprite ChknHZ1;//Horizontal guide 1
    [SerializeField] public Sprite ChknHZ2;//Horizontal guide 2
    [SerializeField] public Sprite ChknHZ3;//Horizontal guide 3
    [SerializeField] public Sprite ChknHZ4;//Horizontal guide 4
    [SerializeField] public Sprite ChknHZ5;//Horizontal guide 5

    [SerializeField] public Sprite ChknFinalSlice;//Final Diced Chicken

    //public Image KnifeEdge;
    //public Image Guideline1;

    private float timeRemaining = 45f; //total time until timer ends
    private readonly float ogTime = 45f; // if resetting timer needed, when timer is not running, set time remainging to ogTime
    private bool timerIsRunning = false; //boolean which checks if timer is running
    private bool runOnce = false;
    private bool runOnlyOnce = false;

    private string TimeLeftString;
    public Text TimeText;

    private int numberOfChops;

    // Start is called before the first frame update
    void Start()
    {
        BS = UIManager.GetComponent<ButtonScript>();

        KnifeImage.rectTransform.localEulerAngles = new Vector3(0, 0, 51.806f); // set knife to horizontal rotation
        CBImage.sprite = WholeChkn; // set chicken image

        CBImage.gameObject.SetActive(true); //set Chick breast to active, since it's chopped first
        GCImage.gameObject.SetActive(false); //set garlic image to off

        GL1Image.gameObject.SetActive(false); //set gridline images to inactive until needed
        GL2Image.gameObject.SetActive(false);
        GL3Image.gameObject.SetActive(false);
        GL4Image.gameObject.SetActive(false);
        GL5Image.gameObject.SetActive(false);
        GL6Image.gameObject.SetActive(false);
        GL7Image.gameObject.SetActive(false);
        GL8Image.gameObject.SetActive(false);
        GL9Image.gameObject.SetActive(false);

        CompleteBannerImage.gameObject.SetActive(false); //set win banner till false
    }

    // Update is called once per frame
    void Update()
    {
        if(runOnce == false && KnifeImage.gameObject.activeSelf == true)
        {
            timerIsRunning = true;
            runOnce = true;
        }
        ChickenGridlineAppear();
        Timer();
        TimeToString();
        KnifeImage.rectTransform.position = Input.mousePosition;
        FinishFunction();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Guideline1" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject); //destroy guideline 1
            GL2Image.gameObject.SetActive(true); //set guideline 2 to active
            CBImage.sprite = ChknGuide2; //change chicken breast image
        }
        else if (collision.gameObject.tag == "Guideline2" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL3Image.gameObject.SetActive(true);
            CBImage.sprite = ChknGuide3;
        }
        else if (collision.gameObject.tag == "Guideline3" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL4Image.gameObject.SetActive(true);
            CBImage.sprite = ChknGuide4;
        }
        else if (collision.gameObject.tag == "Guideline4" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL5Image.gameObject.SetActive(true);
            CBImage.sprite = ChknHZ1;

            KnifeImage.rectTransform.localEulerAngles = new Vector3(0, 0, -33); //rotate knife to vertical position
        }
        else if (collision.gameObject.tag == "Guideline5" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL6Image.gameObject.SetActive(true);
            CBImage.sprite = ChknHZ2;
        }
        else if (collision.gameObject.tag == "Guideline6" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL7Image.gameObject.SetActive(true);
            CBImage.sprite = ChknHZ3;
        }
        else if (collision.gameObject.tag == "Guideline7" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL8Image.gameObject.SetActive(true);
            CBImage.sprite = ChknHZ4;
        }
        else if (collision.gameObject.tag == "Guideline8" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            GL9Image.gameObject.SetActive(true);
            CBImage.sprite = ChknHZ5;
        }
        else if (collision.gameObject.tag == "Guideline9" && Input.GetButton("Fire1"))
        {
            Destroy(collision.gameObject);
            CBImage.gameObject.SetActive(false);
            GCImage.gameObject.SetActive(true);
        }

        if (collision.gameObject.tag == "Garlic" && Input.GetButtonUp("Fire1"))
        {
            numberOfChops++;
            Debug.Log(numberOfChops + " number of Chops");
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Garlic" && Input.GetButtonDown("Fire1"))
    //    {
    //        numberOfChops++;
    //        Debug.Log(numberOfChops + " number of Chops");
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Garlic" && Input.GetButtonDown("Fire1"))
    //    {
    //        numberOfChops++;
    //        Debug.Log(numberOfChops + " number of Chops");
    //    }
    //}

    private void TimeToString()
    {
        TimeLeftString = Mathf.Round((timeRemaining * 100.0f) * 0.01f).ToString();
        TimeText.text = TimeLeftString;
    }

    private void Timer()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                //any code that needs to run once the timer runs out goes here
                Debug.Log("you took too long, display fail message");
            }
        }
        else //if timer is not running
        {
        }
    }

    private void ChickenGridlineAppear()
    {
        if(timeRemaining <= ogTime - .8f && runOnlyOnce == false)
        {
            Debug.Log("eight tenths of a second down");
            CBImage.sprite = ChknGuide1; //set guideline chicken image
            GL1Image.gameObject.SetActive(true);
            runOnlyOnce = true;
        }
    }

    private void FinishFunction()
    {
        if (numberOfChops >= 10)
        {
            //Debug.Log("chopped garlic 10 times");
            CompleteBannerImage.gameObject.SetActive(true);
            timerIsRunning = false;
            if (Input.GetButton("Fire2"))
            {
                BS.ChopToCook();
            }
        }
    }
}
