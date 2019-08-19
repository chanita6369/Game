using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    [Header("leave empty if you want randomized")]
    public string desiredRandom;

    public string GetString()
    {
        if (!string.IsNullOrEmpty(desiredRandom))
        {
            return desiredRandom;
        }

        string result = word;

        while (result == word)
        {
            result = "";
            List<char> characters = new List<char>(word.ToCharArray());
            while (characters.Count > 0)
            {
                int indexChar = Random.Range(0, characters.Count - 1);
                result += characters[indexChar];

                characters.RemoveAt(indexChar);
            }
        }

        return result;
    }
}

public class WordSpell : MonoBehaviour
{
    public Word[] word;

    [Header("UI REFERENCE")]
    public CharObject prefebA;
    public Transform containerA;
    //public Transform containerB;
    public float space;

    List<CharObject> charObject = new List<CharObject>();

    public int currentWord;

    public static WordSpell main;

    void Awake()
    {
        main = this;
    }

    void Start()
    {
        ShowSpell(currentWord);
    }

    void Update()
    {
        RepositionObject();
    }

    void RepositionObject()
    {
        if (charObject.Count == 0)
        {
            return;
        }

        float center = (charObject.Count - 1) / 2;
        for (int i = 0; i < charObject.Count; i++)
        {
            charObject[i].rectTransform.anchoredPosition = new Vector2((i - center) * space, 0);
            charObject[i].index = i;

        }
    }

    public void ShowSpell()
    {
        ShowSpell(Random.Range(0, word.Length - 1));
    }

    public void ShowSpell(int index)
    {
        charObject.Clear();
        foreach (Transform child in containerA)
        {
            Destroy(child.gameObject);
        }
        if (index > word.Length - 1)
        {
            Debug.LogError("index out of rang, please enter rang between 0-" + (word.Length - 1).ToString());
            return;
        }

        char[] chars = word[index].GetString().ToCharArray();
        foreach (char c in chars)
        {
            CharObject clone = Instantiate(prefebA.gameObject).GetComponent<CharObject>();
            clone.transform.SetParent(containerA);

            charObject.Add(clone.Init(c));
        }
        currentWord = index;
    }
}

