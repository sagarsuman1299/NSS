using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class RandomizeAnimals : MonoBehaviour
{
    int t,k=0;
    public GameObject[] Ques;
    public Text HeadingText, BottomText;
    private string temporaryText;
    private string WildText = "Choose a Wild Animal";
    private string DomesticText = "Choose a Domestic Animal";
    public AudioSource wildSound;
    public AudioSource domesticSound;
    private void Start()
    {
        NumberRandomise();

    }
    private void Update()
    {
        //  if(temporaryText==)
    }
    public void Elephant()
    {
        temporaryText = WildText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct! Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Dog()
    {
        temporaryText = DomesticText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Cow()
    {
        temporaryText = DomesticText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Goat()
    {
        temporaryText = DomesticText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Giraffe()
    {
        temporaryText = WildText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Horse()
    {
        temporaryText = DomesticText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Rhino()
    {
        temporaryText = WildText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Zebra()
    {
        temporaryText = WildText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;

            StartCoroutine(WaitForTime());
        }
    }
    public void Tiger()
    {
        temporaryText = WildText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }
    public void Lion()
    {
        temporaryText = WildText;
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";

            BottomText.color = Color.green;
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            BottomText.color = Color.red;
            StartCoroutine(WaitForTime());
        }
    }


    public void NumberRandomise()
    {
        t = Random.Range(1, 7);
        if(k==t)
        {
            t = Random.Range(1, 7);
        }
        if (t == 1)
        {
            wildSound.Play();
            HeadingText.text = WildText;
            Ques[0].SetActive(true);
            Ques[1].SetActive(false);
            Ques[2].SetActive(false);
            Ques[3].SetActive(false);
            Ques[4].SetActive(false);
            Ques[5].SetActive(false);
            k=t;
        }
        if (t == 2)
        {
            domesticSound.Play();
            HeadingText.text = DomesticText;
            Ques[0].SetActive(false);
            Ques[1].SetActive(true);
            Ques[2].SetActive(false);
            Ques[3].SetActive(false);
            Ques[4].SetActive(false);
            Ques[5].SetActive(false);
            k=t;
        }
        if (t == 3)
        {
            domesticSound.Play();
            HeadingText.text = DomesticText;
            Ques[0].SetActive(false);
            Ques[1].SetActive(false);
            Ques[2].SetActive(true);
            Ques[3].SetActive(false);
            Ques[4].SetActive(false);
            Ques[5].SetActive(false);
            k = t;
        }
        if (t == 4)
        {
            domesticSound.Play();
            HeadingText.text = DomesticText;
            Ques[0].SetActive(false);
            Ques[1].SetActive(false);
            Ques[2].SetActive(false);
            Ques[3].SetActive(true);
            Ques[4].SetActive(false);
            Ques[5].SetActive(false);
            k = t;
        }
        if (t == 5)
        {
            wildSound.Play();
            HeadingText.text = WildText;
            Ques[0].SetActive(false);
            Ques[1].SetActive(false);
            Ques[2].SetActive(false);
            Ques[3].SetActive(false);
            Ques[4].SetActive(true);
            Ques[5].SetActive(false);
            k = t;
        }
        if (t == 6)
        {
            wildSound.Play();
            HeadingText.text = WildText;
            Ques[0].SetActive(false);
            Ques[1].SetActive(false);
            Ques[2].SetActive(false);
            Ques[3].SetActive(false);
            Ques[4].SetActive(false);
            Ques[5].SetActive(true);
            k = t;
        }
    }
    public IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(2);
        BottomText.text = "_______________";
        BottomText.color = Color.black;
    }

}
