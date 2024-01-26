using Engine;
using Raylib_cs;

public static class EngineTest
{
    static void ReGenerateTest()
    {
        // Scenes created (But not in game yet)
        Scene scene1 = new Scene("Scene 1", "Scenes");
        Scene scene2 = new Scene("Scene 2", "Scenes");

        // I recommend to load all assets before managing GameObjects
        Sprite happyBoySprite = new Sprite("HappyBoySprite", Application.DataPath + "Textures\\me002.png");


        // Scene 1
        // {
                GameObject exampleTextObject1 = new GameObject("exampleTextObject");
                
                // exampleTextObject1 components
                // {
                        SpriteRenderer spriteRenderer1 = new SpriteRenderer();
                        exampleTextObject1.AddComponent(spriteRenderer1);
                        spriteRenderer1.sprite = happyBoySprite;

                        ExampleText text1 = new ExampleText();
                        text1.text = "Created in scene 1!!";
                        text1.color = Color.LIME;
                // }

                exampleTextObject1.AddComponent<Rotate>();
                exampleTextObject1.AddComponent(text1);
                exampleTextObject1.AddComponent<SceneChanger>();

                scene1.AddGameObject(exampleTextObject1);
        // }

        // Scene 2
        // {
                GameObject exampleTextObject2 = new GameObject("exampleTextObject2");
                
                // exampleTextObject2 components
                // {
                        ExampleText text2 = new ExampleText();
                        text2.text = "Created in scene 2!!";
                        text2.color = Color.YELLOW;
                // }

                exampleTextObject2.AddComponent(text2);
                exampleTextObject2.AddComponent<SceneChanger>();

                scene2.AddGameObject(exampleTextObject2);
        // }

        // Saving the scene files
        scene1.SaveChanges();
        scene2.SaveChanges();
    }
    
    public static void Initialize()
    {
        // If you change something on the above code
        // uncomment this method to update the test
        //ReGenerateTest();

        // Loading the scenes to the game
        // {
                SceneManager.AddSceneToBuild(new Scene("Scene 1", "Scenes"));
                SceneManager.AddSceneToBuild(new Scene("Scene 2", "Scenes"));
                
                // This is where the game starts
                // The scene has to be in the buildList to be played
                SceneManager.LoadScene(0);
        // }
        

    }

    
}