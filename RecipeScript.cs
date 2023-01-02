using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeScript : MonoBehaviour
{
    [SerializeField] public string cabbageIngredients;
    [SerializeField] public string cabbageRecipe;
    [SerializeField] public string cabbageRecipe2;
    [SerializeField] public string cabbageName;
    [SerializeField] public Sprite cabbageImage;

    [SerializeField] public string garlicChickenSoupIngredients;
    [SerializeField] public string garlicChickenSoupRecipe;
    [SerializeField] public string garlicChickenSoupRecipe2;
    [SerializeField] public string garlicChickenSoupName;
    [SerializeField] public Sprite garlicChickenSoupImage;

    [SerializeField] public string lemonZoodlesIngredients;
    [SerializeField] public string lemonZoodlesRecipe;
    [SerializeField] public string lemonZoodlesRecipe2;
    [SerializeField] public string lemonZoodlesName;
    [SerializeField] public Sprite lemonZoodlesImage;
    [SerializeField] public string lemonZoodleSpiceText;
    //[SerializeField] public string[] lemonZoodleSpicesA = { "Parsley", "Thyme", "RedPepperFlakes"};

    [SerializeField] public string pumpkinSoupIngredients;
    [SerializeField] public string pumpkinSoupRecipe;
    [SerializeField] public string pumpkinSoupRecipe2;
    [SerializeField] public string pumpkinSoupName;
    [SerializeField] public Sprite pumpkinSoupImage;

    [SerializeField] public string fajitaBowlIngredients;
    [SerializeField] public string fajitaBowlRecipe;
    [SerializeField] public string fajitaBowlRecipe2;
    [SerializeField] public string fajitaBowlName;
    [SerializeField] public Sprite fajitaBowlImage;

    [SerializeField] public string chickpeaSaladIngredients;
    [SerializeField] public string chickpeaSaladRecipe;
    [SerializeField] public string chickpeaSaladName;
    [SerializeField] public Sprite chickpeaSaladImage;

    [SerializeField] public string tacoSoupIngredients;
    [SerializeField] public string tacoSoupRecipe;
    [SerializeField] public string tacoSoupRecipe2;
    [SerializeField] public string tacoSoupName;
    [SerializeField] public Sprite tacoSoupImage;

    //[SerializeField] public string CurrentRecipe;

    // Start is called before the first frame update
    void Start()
    {
        cabbageName = "Cabbage Stir Fry";
        lemonZoodlesName = "Garlic Chicken with Lemon Zoodles";
        fajitaBowlName = "Chicken Fajita Bowl";
        pumpkinSoupName = "Spiced Pumpkin Soup";
        garlicChickenSoupName = "Roasted Garlic Chicken Soup";
        chickpeaSaladName = "Smashed Chickpea Salad Toasts";
        tacoSoupName = "Chicken Taco Soup";

        cabbageIngredients = "5 cloves minced garlic\n 2 tablespoons minced fresh ginger" +
            "\n ½ teaspoon red pepper flakes\n 1/4 teaspoon ground cloves" +
            "\n 4 tablespoons low sodium soy sauce\n 2 tablespoons rice vinegar" +
            "\n 1 ½ tablespoons pure maple syrup\n 1 small cabbage about 1 to 1 ½ pounds" +
            "\n 2 tablespoons extra virgin olive oil divided" +
            "\n 1 pound ground meat (chicken, beef, turkey, pork)\n 2 cups shredded carrots" +
            "\n 1 small bunch green onions finely chopped" +
            "\n ½ cup fresh cilantro leaves and tender stems, chopped";
        cabbageRecipe = "•In a small bowl, combine the garlic, ginger, red pepper flakes and cloves." +
            "In a separate bowl, combine 2 tablespoons of the soy sauce, the rice vinegar, and the " +
            "maple syrup. Keep both close by.\n•Cut the stem end off of the cabbage. Next, cut it in half " +
            "from the top of the cabbage down through the stem. Place the flat, cut side against the surface " +
            "of your cutting board, then each half into quarters(again, from the top down towards the stem). " +
            "Turn each quarter crosswise, then cut into thin, 1 / 8 - inch strips. Keep handy(I like to pile my " +
            "cut cabbage into a bowl as I go).\n•Heat a large, deep skillet, Dutch oven, or wok with a ";
        cabbageRecipe2 = "tight - fitting lid over medium - high heat. Add 1 tablespoon of the oil. Once hot and shimmering, " +
            "add the chicken. Cook, breaking up the meat. Stir in the remaining 2 tablespoons soy sauce. Continue " +
            "cooking until the meat is fully cooked through and any liquid that has collected in the pan has " +
            "mostly cooked off, about 5 minutes. Transfer to a plate or bowl. Make sure you have the skillet lid " +
            "handy.\n•Add the remaining 1 tablespoon oil to the skillet. Add the cabbage and carrots. Cook for 2 " +
            "minutes, stirring occasionally, until the cabbage is just starting to wilt.\n•Add the soy sauce and " +
            "spice mixture. Cover the skillet and cook over high heat for one minute, until the cabbage is completely " +
            "wilted but isn’t mushy.\n•Uncover, and stir in the green onion, cilantro, and reserved chicken. " +
            "Let cook 30 additional seconds. The cabbage should be crisp tender(if it’s not, cook it a bit longer). " +
            "Serve hot with rice or noodles and an extra dash of soy sauce as desired.";

        garlicChickenSoupIngredients = "20 cloves garlic unpeeled\n 2 tbsp olive oil" +
            "\n Salt and pepper to taste\n 2 tbsp butter\n 1 medium onion thinly sliced" +
            "12 cloves garlic peeled\n ½ tsp dried thyme\n 4 cups chicken stock" +
            "½ cup whipping cream\n 1 ½ lbs cooked chicken thighs or breasts cubed";
        garlicChickenSoupRecipe = "Preheat oven to 350F and place unpeeled garlic cloves in a shallow baking dish. " +
            "Add olive oil, salt and pepper and toss to coat.\n•Roast until garlic is golden brown, about 35 minutes." +
            "\n•Cool and squeeze out garlic with fingers into a small bowl.\n•In a large saucepan over medium heat, " +
            "melt butter. Add onions and cook until translucent, about 6 minutes.\n•Add roasted garlic, additional " +
            "garlic cloves, and thyme and cook 2 to 3 minutes, until fragrant.\n•Add chicken stock and bring to a " +
            "simmer. Cook 20 minutes.";
            garlicChickenSoupRecipe2 = "\n•Puree using a blender or immersion blender.This step can be " +
            "ommitted if you chopped the onion and garlic finely.\n•Stir in whipping cream and cooked chicken and season " +
            "with salt and pepper. Warm through and serve";

        lemonZoodleSpiceText = "•Parsley\n•Thyme\n•Red Pepper Flakes\n";
        lemonZoodlesIngredients = "3-4 chicken breasts, cut into bite-sized chunks\n" +
            "1 package of zucchini noodles\n 4 tablespoons butter, divided\n 2 teaspoons minced garlic\n" +
            "1 / 4 cup low-sodium chicken broth\n 2-3 tbsp of lemon juice\n 1 tablespoon minced parsley\n" +
            "1 teaspoon fresh thyme leaves\n Crushed red chili pepper flakes, optional" +
            "\n Slices of lemon, for garnish";
        lemonZoodlesRecipe = "Slice chicken breasts into bite-sized chunks and combine with olive oil, salt, pepper, " +
            "garlic powder, Italian seasoning, and hot sauce or chili powder, mixing until evenly seasoned. Marinate " +
            "in the refrigerator for 30 minutes to one hour.\n•In the meantime, wash and trim the ends of the zucchini. " +
            "Using a spiralizer, make the zucchini noodles, then set aside. This step can be ommitted if you buy " +
            "pre-made zucchini noodles\n•Bring the marinated chicken bites to room temperature and heat two tablespoons " +
            "butter in a large skillet over medium-low heat. Gently stir-fry the chicken pieces on all sides until golden " +
            "brown.";
        lemonZoodlesRecipe2 = "Remove the chicken bites from the skillet and set aside to a plate. You might have to work in batches " +
            "to avoid crowding the pan and have steamed chicken instead of browned.\n•In the same skillet over " +
            "medium-high, add two tablespoons butter, lemon juice, hot sauce, and chicken broth. Bring to a simmer and " +
            "allow to reduce for 1-2 minutes, stirring regularly.\n•Stir in fresh parsley and minced garlic, then add " +
            "the zucchini noodles and toss for two to three minutes to cook it up. Allow the cooking juices to reduce " +
            "for one minute if the zucchini noodles render too much water. Add the chicken bites back to the pan and stir " +
            "for another minute to reheat. Garnish with more parsley, fresh thyme, crushed chili pepper, and lemon slices " +
            "and serve immediately. Enjoy!";

        pumpkinSoupIngredients = "1 1/2 cups chicken broth\n1 cup pumpkin puree\n4 tbsp.butter" +
            "1 / 2 medium shallot, chopped\n2 cloves garlic, minced\n1 / 2 tsp.salt" +
            "1 / 2 tsp.pepper\n1 / 2 tsp.ginger, minced\n1 / 4 tsp.cinnamon\n1 / 4 tsp.coriander" + 
            "1 / 8 tsp.nutmeg\n1 bay leaf\n1 / 2 cup heavy cream\n4 slices bacon\n" +
            "~3 tbsp.leftover bacon grease\nfreshly grated Parmesan(optional, for garnish)" +
            "chives, chopped(optional, for garnish)";
        pumpkinSoupRecipe = "•Melt the butter in a large saucepan on med-low heat. when it stops foaming, " +
            "add the minced garlic, shallots, and ginger. Sautée for 2-3 mins.\n• Mix all the spices together " +
            "in a small bowl and add them to the pot once the shallots have become translucent, stir for 1 - 2 " +
            "mins.\n•Add the pumpkin pureé, stir well.\n•Stir in the chicken broth, bring to a boil, then let simmer " +
            "on low heat for 30 - 40 mins.\n• As the soup simmers, cook 4 slices of bacon in a frying pan. When bacon " +
            "is fully cooked, set it to the side and crumble.";
        pumpkinSoupRecipe2 = "\n•Add heavy cream and (~2 - 3tbsp) leftover bacon grease to the soup." +
            "\n•Garnish with crumbled bacon bits and freshly grated Parmesan.";

        fajitaBowlIngredients = "1 pound chicken breast tenderloins\n" +
            "2 cups cooked rice white or brown rice, Mexican rice, Cilantro rice" +
            "\n1 poblano pepper sliced thin\n1 red pepper sliced thin\n1 small onion sliced thin" +
            "\n15 ounce canned black beans drained and rinsed\n15 ounce canned corn drained" +
            "\n1 tablespoon fajita seasoning\n 1 tablespoon oil\nOptional ingredients: " +
            "shredded cheese, sour cream, avocado, salsa, limes";
        fajitaBowlRecipe = "Preheat a large skillet to medium high heat and add oil. Season chicken, onions, and " +
            "peppers with half of the fajita seasoning.\n•When skillet is hot, add the chicken, peppers, and onions. " +
            "Cook 3 - 4 minutes per side, or until chicken is cooked through. Transfer chicken and vegetables to a " +
            "plate and cover with foil to keep warm.\n•To the same skillet, add corn and black beans with the remaining " +
            "fajita seasoning. Cook, stirring frequently, until warmed through.\n•Fill bowls with rice, then top with " +
            "chicken, onions, peppers, corn,";
        fajitaBowlRecipe2 = "and black beans. Add additional toppings as desired, like sour cream, salsa, avocado and " +
            "a squeeze of lime.";

        chickpeaSaladIngredients = "1 (15-oz.) can unsalted chickpeas, drained and rinsed\n" +
            "1/4 cup diced celery\n1/4 cup diced dill pickle\n1/4 cup canola mayonnaise" +
            "2 tablespoons minced red onion\n1 1/2 teaspoons fresh lemon juice\n1/4 teaspoon " +
            "kosher salt\n1/4 teaspoon black pepper\n3 slices whole-grain bakery bread, toasted";
        chickpeaSaladRecipe = "Place chickpeas in a bowl; coarsely mash.\n•Stir in celery, pickle, " +
            "mayonnaise, onion, lemon juice, salt, and pepper.\n•Spread about 2 / 3 cup chickpea salad " +
            "onto each slice of toasted bread.";

        tacoSoupIngredients = "1 / 2 tablespoon chili powder\n1 teaspoon cumin\n1 / 2 teaspoon " +
            "garlic powder\n2 tablespoons coconut oil\n1 pound boneless skinless chicken thighs" +
            "1 / 4 cup chopped white onion 1 / 2 4'inch jalapeno, diced\n1 / 2 green bell " +
            "pepper, chopped\n1 / 2 cup diced tomatoes and chilies, drained\n3 cups chicken broth" +
            "2 tablespoons tomato paste\n2 tablespoons butter\n1 / 4 cup cilantro, chopped, divided" +
            "\n1 avocado, pitted, peeled, and diced\n4 tablespoons sour cream, for topping" +
            "1 cup mild cheddar cheese, for topping\nSalt and pepper, to taste";
        tacoSoupRecipe = "•In a small bowl, mix the chili powder, cumin, and garlic powder. Sprinkle " +
            "half of the mixture over the chicken thighs and add salt and pepper to your preference.\n" +
            "•In a large pot over medium-high heat, warm the coconut oil, about 2 - 3 minutes. Carefully " +
            "add the chicken thighs to the pot and sear then reduce the heat and continue cooking until " +
            "chicken is cooked fully, reaching at least 165 degrees(F) internal temperature.\n• Remove the " +
            "chicken from the pan and set aside. Add the onion, jalapeno, and green bell pepper to the pan. " +
            "Saute in oil for 2 minutes then add diced tomatoes and chilies. Use a wooden spoon to scrape the "; 
        tacoSoupRecipe2 = "bottom of the pan as the tomatoes release juice. This will get all the tasty chicken seasoning into " +
            "the soup.Let the veggies cook for about 5 minutes or until they begin to soften and become fragrant. " +
            "Sprinkle with remaining seasoning from the small bowl in step 1 and stir.\n•Pour the broth and tomato " +
            "paste into the pan, stir, and bring to a boil.Let the soup boil for 1-2 minutes then reduce to a " +
            "simmer.\n•Cut the cooled chicken into small bite size cubes. Add back into simmering soup along " +
            "with butter. The butter will remove any extra acidity in the soup.\n•Let the soup simmer for 15 " +
            "minutes to let the flavors come together. When done, turn off the heat and sprinkle with half of " +
            "the cilantro. Omit this step if you don't like cilantro.\n•To serve, add 1/4 of avocado to each " +
            "dish, 1 tablespoon of sour cream,1/4 cup of shredded cheese and a sprinkle of cilantro for garnish. ";
    }
}
