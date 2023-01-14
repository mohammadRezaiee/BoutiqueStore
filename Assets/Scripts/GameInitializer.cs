using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BS
{
    public static class GameInitializer
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

        public static void Init()
        {
            SceneManager.LoadScene(0);

            GameObject prefab = Resources.Load<GameObject>("GameManager");
            GameObject gameManagerObj = Object.Instantiate(prefab);
            gameManagerObj.name = "GameManager";
            GameObject.DontDestroyOnLoad(gameManagerObj);
        }
    }
}
