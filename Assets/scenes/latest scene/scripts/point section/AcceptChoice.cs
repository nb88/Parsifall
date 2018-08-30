using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class AcceptChoice : MonoBehaviour {


    private Answers answers;
    private CharacterManager characterManager;
    private CharacterResult characterResult;
    private StoryImageSlideController storyImageSlideController;

    public GameObject agreeBar;
    public GameObject discussText;
    public GameObject hideable;
    public Text StatementTextObject;

    private bool canClickNext = true;
    private bool hasEnded;
    public bool hasAccepted;
    public bool timeEnded;

    private int[] charArray;
    public string[] statementText;

    private int lastStatement;
    private int currentTextIndex = 0;
    public int currentStatement;


    void Start()
    {
        
        answers = FindObjectOfType<Answers>();
        characterManager = FindObjectOfType<CharacterManager>();
        characterResult = FindObjectOfType<CharacterResult>();
        charArray = characterManager.charArray;
        storyImageSlideController = FindObjectOfType<StoryImageSlideController>();
    }

    private void Update()
    {
        hasEnded = FindObjectOfType<CharacterManager>().hasEnded;
        if (hasEnded)
        {
            print("has ended true in accept choice");
            hideable.SetActive(false);
        }
    }


    public void ClickingTask()
    {
        if (timeEnded)
        {
            discussText.SetActive(false);
            timeEnded = false;
            StatementTextObject.GetComponentInChildren<Text>().enabled = true;
            agreeBar.SetActive(true);
        } 

        hasAccepted = true;
        if (canClickNext)
        {
            answers.AnswerValueCheck();
            lastStatement = currentStatement;

            StatementTextObject.text  = statementText[currentTextIndex];
            currentTextIndex++;
            characterManager.SaveAnswer();
            storyImageSlideController.MoveStoryImage();
             currentStatement++;
        }

        if (currentTextIndex == 7 || currentTextIndex == 15)
        {
            canClickNext = false;
            StartCoroutine(Wait(5));
            timeEnded = true;
        }

        hasAccepted = false;
    }

    public IEnumerator Wait(float waitTime)
    {
        agreeBar.SetActive(false);
        StatementTextObject.GetComponentInChildren<Text>().enabled = false;
        this.gameObject.GetComponent<Image>().enabled = false;
        discussText.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        canClickNext = true;
        this.gameObject.GetComponent<Image>().enabled = true;
    }
}