using Engine;
using Raylib_cs;

public static class GodTest
{
    public static void InitializeGame()
    {
        Scene scene1 = new Scene("Escena 1");
        Scene scene2 = new Scene("Escena 2");

        // Objeto con texto y cambiador de escenas
        GameObject exampleTextObject1 = new GameObject("exampleTextObject");

        
        SpriteRenderer spriteRenderer1 = new SpriteRenderer();
        exampleTextObject1.AddComponent(spriteRenderer1);
        spriteRenderer1.sprite = new Sprite(Application.DataPath + "Textures\\me002.png");

        exampleTextObject1.AddComponent<Rotate>();

        ExampleText text1 = new ExampleText();
        text1.text = "He sido creado en la escena 1!!";
        text1.color = Color.LIME;
        exampleTextObject1.AddComponent(text1);

        exampleTextObject1.AddComponent<SceneChanger>();
        //exampleTextObject1.AddComponent<DDOL>();

        scene1.CreateGameObject(exampleTextObject1);

        GameObject exampleTextObject2 = new GameObject("exampleTextObject2");
        ExampleText text2 = new ExampleText();
        text2.text = "He sido creado en la escena 2!!";
        text2.color = Color.YELLOW;
        exampleTextObject2.AddComponent(text2);
        exampleTextObject2.AddComponent<SceneChanger>();

        scene2.CreateGameObject(exampleTextObject2);

        SceneManager.AddSceneToBuild(scene1);
        SceneManager.AddSceneToBuild(scene2);
        
        // SceneManager.LoadScene(scene1);
        SceneManager.LoadScene(0);

    }
}