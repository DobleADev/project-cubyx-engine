using Newtonsoft.Json;

namespace Engine
{
    public class SceneManager
    {
        private static List<Scene> _buildScenes = new List<Scene>();
        public static List<Scene> GetScenesInBuild() => _buildScenes;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        static Scene currentScene;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static Scene GetCurrentScene() 
        {
            try
            {
                return currentScene;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There's no active scene! \n\n{ex.Message}");
            }
            return null;
        }
        
        public static void AddSceneToBuild(Scene scene)
        {
            _buildScenes.Add(scene);
            scene.BuildIndex = _buildScenes.IndexOf(scene);
            // SerializeScene(scene);
        }

        public static void LoadScene(string sceneName)
        {
            if (currentScene != null) currentScene.Dispose();
            Scene? sceneTarget = null;
            sceneTarget = _buildScenes.Where(i => i.Name == sceneName).FirstOrDefault();
            LoadProcess(sceneTarget);
        }

        public static void LoadScene(int buildIndex)
        {
            if (currentScene != null) currentScene.Dispose();
            Scene? sceneTarget = _buildScenes[buildIndex];
            LoadProcess(sceneTarget);
        }

        private static void LoadProcess(Scene scene)
        {
            scene = DeserializeScene(scene.Name);
            currentScene = scene;
            try
            {
                currentScene.Load();
            }
            catch
            {
                Console.WriteLine("Failed to load! null scene");
            }
            
        }

        

        private static Scene? GetScene(string sceneName)
        {
            Scene? sceneTarget = null;
            sceneTarget = _buildScenes.Where(i => i.Name == sceneName).FirstOrDefault();
            return sceneTarget;
        }

        // public static Scene? LoadFromFile(string sceneName)
        // {
            
        // }

        static Scene? DeserializeScene(string sceneName)
        {
            Scene sceneToLoad = GetScene(sceneName);
            if (sceneToLoad == null) return null;

            string filepath = Application.DataPath + $"{sceneToLoad.Path}\\{sceneName}.json";
            if (File.Exists(filepath)) // -------------------------------- Cargar datos ------------------ //
            {
                try
                {
                    string json = File.ReadAllText(filepath);
                    Scene sceneTarget = JsonConvert.DeserializeObject<Scene>(json, new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });
                    Console.WriteLine("Escena cargada correctamente.");
                    return sceneTarget;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al cargar los datos.");
                }
            }
            
            return null;
        }

        static void SerializeScene(Scene sceneToSave)
        {
            try
            {
                //if (_buildScenes.Count == 0) throw new JsonException("No hay datos");
                string temp = JsonConvert.SerializeObject(sceneToSave, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                });
                string directoryPath = Application.DataPath + sceneToSave.Path;
                if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                File.WriteAllText(directoryPath + $"\\{sceneToSave.Name}.json", temp);
                Console.WriteLine("Escena guardada correctamente.");
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar los datos. ", ex);
            }
            
        }

        internal static void CreateScene(Scene scene)
        {
            SerializeScene(scene);
        }
    }
}