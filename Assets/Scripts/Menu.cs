using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TapGame
{
    public class Menu : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene("Game");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
