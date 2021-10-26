using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace menubuttons
{
    public class menubuttonsLogic : MonoBehaviour
    {
        public Button start, creddits, exit;

        public void StartGame()
        {
            SceneManager.LoadScene("LivingRoom");
        }
        public void CreditsScene()
        {
            SceneManager.LoadScene("CreditsScene");
        }
        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
