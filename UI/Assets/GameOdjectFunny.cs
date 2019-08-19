using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOdjectFunny : MonoBehaviour
{
    public Button WordFButton, WordUButton, WordN1Button, WordN2Button, WordYButton;
    public GameObject WordFChanel, WordUChanel, WordN1Chanel, WordN2Chanel, WordYChanel;

    void Start()
    {
        WordFChanel.gameObject.SetActive(false);
        WordUChanel.gameObject.SetActive(false);
        WordN1Chanel.gameObject.SetActive(false);
        WordN2Chanel.gameObject.SetActive(false);
        WordYChanel.gameObject.SetActive(false);
    }

    public void Chanel1()
    {
        WordFChanel.gameObject.SetActive(true);
        WordFButton.interactable = false;
    }
    public void ClickWordU()
    {
        WordUChanel.gameObject.SetActive(true);
        WordUButton.interactable = false;
    }
    public void ClickWordN1()
    {
        WordN1Chanel.gameObject.SetActive(true);
        WordN1Button.interactable = false;
    }
    public void ClickWordN2()
    {
        WordN2Chanel.gameObject.SetActive(true);
        WordN2Button.interactable = false;
    }
    public void ClickWordY()
    {
        WordYChanel.gameObject.SetActive(true);
        WordYButton.interactable = false;
    }
}
