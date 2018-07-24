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

    public GameObject discussText;
    public Text StatementTextObject;
  //  public GameObject pauseText;

    private bool canClickNext = true;
    public bool hasAccepted;

    private int[] charArray;
    public string[] statementText;//= new string[] {"Statement1", "Statement2", "Statement3"};

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



    public void ClickingTask()
    {
        hasAccepted = true;
        if (canClickNext)
        {
            answers.AnswerValueCheck();
            var statementDatas = ScriptableObject.CreateInstance<ScoreKeeper>(); // obsolete?
            lastStatement = currentStatement;

            StatementTextObject.text  = statementText[currentTextIndex];
            currentTextIndex++;
            characterManager.SaveAnswer();
            storyImageSlideController.MoveStoryImage();
             currentStatement++;
            Debug.Log(currentStatement);
        }

        if (currentTextIndex == 7 || currentTextIndex == 15)
        {
            canClickNext = false;
          //  pauseText.SetActive(true);
            StartCoroutine(Wait(5));
         //   pauseText.SetActive(false);
        }

        hasAccepted = false;
    }

    public IEnumerator Wait(float waitTime)
    {
        StatementTextObject.GetComponentInChildren<Text>().enabled = false;
        this.gameObject.GetComponent<Image>().enabled = false;
        discussText.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        canClickNext = true;
        this.gameObject.GetComponent<Image>().enabled = true;
        StatementTextObject.GetComponentInChildren<Text>().enabled = true;
        discussText.SetActive(false);
    }
}