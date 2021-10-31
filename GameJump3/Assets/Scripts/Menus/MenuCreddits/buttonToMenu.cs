using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace creddits
{
    public class buttonToMenu : MonoBehaviour
    {
        public Button backToMenu;


        public void toMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
