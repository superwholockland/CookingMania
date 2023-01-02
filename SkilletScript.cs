using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkilletScript : MonoBehaviour
{
    public Image CookingScreen;
    public Image NutritionScreen;

    public Image Pan;
    public Sprite CleanPan;
    public Sprite ButterPan;
    public Sprite BrothPan;

    public Image ButterPat; //Pan Images Reference
    public Image DicedChicken;
    public Image CookedChicken;
    public Image Zoodles;
    public Image FinishedMeal;

    public Image FinishBanner;

    public Image ButterIcon; //Image Icon References
    public Image ChickenIcon;
    public Image LemonIcon;
    public Image BrothIcon;
    public Image GarlicIcon;
    public Image ZoodlesIcon;

    private float timeRemaining = 15f; //total time until timer ends
    /*private readonly float ogTime = 15f;*/ // if resetting timer needed, when timer is not running, set time remainging to ogTime
    private bool timerIsRunning = false; //boolean which checks if timer is running

    // Start is called before the first frame update
    void Start()
    {
        Pan.sprite = CleanPan;
        NutritionScreen.gameObject.SetActive(false);

        ButterPat.gameObject.SetActive(false);
        DicedChicken.gameObject.SetActive(false);
        CookedChicken.gameObject.SetActive(false);
        Zoodles.gameObject.SetActive(false);
        FinishedMeal.gameObject.SetActive(false);

        FinishBanner.gameObject.SetActive(false);

        ButterIcon.gameObject.SetActive(true);
        ChickenIcon.gameObject.SetActive(false);
        LemonIcon.gameObject.SetActive(false);
        BrothIcon.gameObject.SetActive(false);
        GarlicIcon.gameObject.SetActive(false);
        ZoodlesIcon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        MoveToNuteScreen();
    }

    public void ClickedButterIcon()
    {
        //ButterIcon.gameObject.SetActive(false); //butter icon disappears
        Destroy(ButterIcon); //butterIcon destroyed
        ButterPat.gameObject.SetActive(true); // butter in pan appears
        Pan.sprite = ButterPan; // set pan image to butterpan
        ChickenIcon.gameObject.SetActive(true); //chicken icon appears
    }

    public void ClickedChickenIcon()
    {
        Destroy(ChickenIcon);
        //ChickenIcon.gameObject.SetActive(false); //chicken icon disappears
        DicedChicken.gameObject.SetActive(true); // chicken in pan appears
        timerIsRunning = true;
    }

    public void LemonIconAppear()
    {
        Destroy(DicedChicken);
        //DicedChicken.gameObject.SetActive(false);
        CookedChicken.gameObject.SetActive(true);
        LemonIcon.gameObject.SetActive(true);
    }

    public void ClickedLemonIcon()
    {
        Destroy(LemonIcon);
        //LemonIcon.gameObject.SetActive(false);
        BrothIcon.gameObject.SetActive(true);
    }

    public void ClickedBrothIcon()
    {
        Destroy(BrothIcon);
        //BrothIcon.gameObject.SetActive(false);
        GarlicIcon.gameObject.SetActive(true);
        Pan.sprite = BrothPan;
    }

    public void ClickedGarlicIcon()
    {
        Destroy(GarlicIcon);
        //GarlicIcon.gameObject.SetActive(false);
        ZoodlesIcon.gameObject.SetActive(true);
    }

    public void ClickedZoodlesIcon()
    {
        Destroy(ZoodlesIcon);
        //ZoodlesIcon.gameObject.SetActive(false);
        //insert timer like for chicken?

        FinishedMeal.gameObject.SetActive(true);
        FinishBanner.gameObject.SetActive(true);
    }

    public void MoveToNuteScreen()
    {
        if (FinishBanner.gameObject.activeSelf == true && Input.GetButtonDown("Fire2"))
        {
            //MOVE TO NEXT SCREEN CODE HERE
            CookingScreen.gameObject.SetActive(false);
            NutritionScreen.gameObject.SetActive(true);
        }
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
                Debug.Log("Chicken's Ready");
                LemonIconAppear();
            }
        }
        else //if timer is not running
        {
        }
    }
}
