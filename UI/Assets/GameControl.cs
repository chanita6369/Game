using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Button WordSButton, WordHButton, WordYButton;
    public GameObject WordSChanel, WordHChanel, WordYChanel;

    void Start()
    {
        WordSChanel.gameObject.SetActive(false);
        WordHChanel.gameObject.SetActive(false);
        WordYChanel.gameObject.SetActive(false);
    }

    public void ClickWordS()
    {
        WordSChanel.gameObject.SetActive(true);
        WordSButton.interactable = false;
    }
    public void ClickWordH()
    {
        WordHChanel.gameObject.SetActive(true);
        WordHButton.interactable = false;
    }
    public void ClickWordY()
    {
        WordYChanel.gameObject.SetActive(true);
        WordYButton.interactable = false;
    }

}
