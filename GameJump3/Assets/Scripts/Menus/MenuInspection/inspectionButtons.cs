using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inspectionButtons : MonoBehaviour
{
    public Button exit;
    public GameObject inspectionMenu;

    public void exitMenu()
    {
        Time.timeScale = 1;
        inspectionMenu.SetActive(false);
    }
}
