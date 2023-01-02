using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    //References to Image Gameobjects to enable and disable transitions between screens
    public Image StartScreen;
    public Image MainScreen;
    public Image CookBookScreen;
    public Image PracticeScreen;
    //public Image AvatarMainScreen;
    //public Transform AvatarDresserScreen;
    //public Image AvatarHealthScreen;
    public Image RecipeScreen;
    public Image SpicePrepScreen;
    public Image ChoppingScreen;
    public Image CookingScreen;

    ////references to spice Images to enable and disable
    //public Image ThymeImage;
    //public Image PepperFlakesImage;
    //public Image ParsleyImage;

    // Start is called before the first frame update
    void Start()
    {
        StartScreen.gameObject.SetActive(true);
        MainScreen.gameObject.SetActive(false);
        CookBookScreen.gameObject.SetActive(false);
        PracticeScreen.gameObject.SetActive(false);
        //AvatarMainScreen.gameObject.SetActive(false);
        //AvatarDresserScreen.gameObject.SetActive(false);
        RecipeScreen.gameObject.SetActive(false);
        SpicePrepScreen.gameObject.SetActive(false);
        ChoppingScreen.gameObject.SetActive(false);
        CookingScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Destroy(StartScreen);
        //StartScreen.gameObject.SetActive(false);
        MainScreen.gameObject.SetActive(true);
    }

    public void CookBook()
    {
        MainScreen.gameObject.SetActive(false);
        CookBookScreen.gameObject.SetActive(true);
    }

    //public void Avatar()
    //{
    //    MainScreen.gameObject.SetActive(false);
    //    AvatarMainScreen.gameObject.SetActive(true);
    //}

    public void Practice()
    {
        MainScreen.gameObject.SetActive(false);
        PracticeScreen.gameObject.SetActive(true);
    }

    public void RecipeSelect()
    {
        CookBookScreen.gameObject.SetActive(false);
        RecipeScreen.gameObject.SetActive(true);
    }

    public void BackToCookbook()
    {
        RecipeScreen.gameObject.SetActive(false);
        CookBookScreen.gameObject.SetActive(true);
    }

    public void BackToMainScreen()
    {
        CookBookScreen.gameObject.SetActive(false);
        MainScreen.gameObject.SetActive(true);
    }

    //public void AvatarToDresser()
    //{
    //    AvatarMainScreen.gameObject.SetActive(false);
    //    AvatarDresserScreen.gameObject.SetActive(true);
    //}

    //public void DresserToAvatar()
    //{
    //    AvatarDresserScreen.gameObject.SetActive(false);
    //    AvatarMainScreen.gameObject.SetActive(true);
    //}

    //public void AvatarToHealth()
    //{
    //    AvatarMainScreen.gameObject.SetActive(false);
    //    AvatarHealthScreen.gameObject.SetActive(true);
    //}

    //public void HealthToAvatar()
    //{
    //    AvatarHealthScreen.gameObject.SetActive(false);
    //    AvatarMainScreen.gameObject.SetActive(true);
    //}

    public void RecipeToSpicePrep()
    {
        RecipeScreen.gameObject.SetActive(false);
        SpicePrepScreen.gameObject.SetActive(true);
    }

    public void SpicePrepToChop()
    {
        SpicePrepScreen.gameObject.SetActive(false);
        ChoppingScreen.gameObject.SetActive(true);
    }

    public void ChopToCook()
    {
        ChoppingScreen.gameObject.SetActive(false);
        CookingScreen.gameObject.SetActive(true);
    }
}
