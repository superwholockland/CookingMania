using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RecipeClickScript : MonoBehaviour, IPointerClickHandler
{
    private RecipeScript RS;
    private ButtonScript BS;
    public GameObject UIManager;
    public Text RecipeName;
    public Text IngredientsText;
    public Text RecipeText1;
    public Text RecipeText2;
    public Image RecipeImage;

    public Text SpiceListText;
    //public string[] NeededSpicesA;

    // Start is called before the first frame update
    void Start()
    {
        RS = UIManager.GetComponent<RecipeScript>();
        BS = UIManager.GetComponent<ButtonScript>();
    }

    public void ClearOldRecipe()
    {
        RecipeName.text = null;
        RecipeImage.sprite = null;
        IngredientsText.text = null;
        RecipeText1.text = null;
        RecipeText2.text = null;
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        ClearOldRecipe();
        BS.RecipeSelect();
        if (this.gameObject.tag == "1")
        {
            //RS.CurrentRecipe = "lemonZoodles";
            RecipeName.text = RS.lemonZoodlesName;
            RecipeImage.sprite = RS.lemonZoodlesImage;
            IngredientsText.text = RS.lemonZoodlesIngredients;
            RecipeText1.text = RS.lemonZoodlesRecipe;
            RecipeText2.text = RS.lemonZoodlesRecipe2;

            //NeededSpicesA = RS.lemonZoodleSpicesA;
            //for (int i = 0; i < NeededSpicesA.Length; i++)
            //{
            //    Debug.Log(NeededSpicesA[i]);
            //}
            SpiceListText.text = RS.lemonZoodleSpiceText;
        }
        else if (this.gameObject.tag == "2")
        {
            RecipeName.text = RS.cabbageName;
            RecipeImage.sprite = RS.cabbageImage;
            IngredientsText.text = RS.cabbageIngredients;
            RecipeText1.text = RS.cabbageRecipe;
            RecipeText2.text = RS.cabbageRecipe2;
        }
        else if (this.gameObject.tag == "3")
        {
            RecipeName.text = RS.fajitaBowlName;
            RecipeImage.sprite = RS.fajitaBowlImage;
            IngredientsText.text = RS.fajitaBowlIngredients;
            RecipeText1.text = RS.fajitaBowlRecipe;
            RecipeText2.text = RS.fajitaBowlRecipe2;
        }
        else if (this.gameObject.tag == "4")
        {
            RecipeName.text = RS.pumpkinSoupName;
            RecipeImage.sprite = RS.pumpkinSoupImage;
            IngredientsText.text = RS.pumpkinSoupIngredients;
            RecipeText1.text = RS.pumpkinSoupRecipe;
            RecipeText2.text = RS.pumpkinSoupRecipe2;
        }
        else if (this.gameObject.tag == "5")
        {
            RecipeName.text = RS.garlicChickenSoupName;
            RecipeImage.sprite = RS.garlicChickenSoupImage;
            IngredientsText.text = RS.garlicChickenSoupIngredients;
            RecipeText1.text = RS.garlicChickenSoupRecipe;
            RecipeText2.text = RS.garlicChickenSoupRecipe2;
        }
        else if (this.gameObject.tag == "6")
        {
            RecipeName.text = RS.chickpeaSaladName;
            RecipeImage.sprite = RS.chickpeaSaladImage;
            IngredientsText.text = RS.chickpeaSaladIngredients;
            RecipeText1.text = RS.chickpeaSaladRecipe;
        }
        else if (this.gameObject.tag == "7")
        {
            RecipeName.text = RS.tacoSoupName;
            RecipeImage.sprite = RS.tacoSoupImage;
            IngredientsText.text = RS.tacoSoupIngredients;
            RecipeText1.text = RS.tacoSoupRecipe;
            RecipeText2.text = RS.tacoSoupRecipe2;
        }
        else if (this.gameObject.tag == "8")
        {

        }
    }

}
