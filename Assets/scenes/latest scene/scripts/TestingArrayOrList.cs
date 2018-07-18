    using System.Collections;
    using System.Collections.Generic;
using UnityEngine;

public class TestingArrayOrList : MonoBehaviour {

    public List<Character1PointsData> char1Points = new List<Character1PointsData>();
    public List<Character2PointsData> char2Points = new List<Character2PointsData>();
    public List<Character3PointsData> char3Points = new List<Character3PointsData>();

    private AcceptChoice acceptChoice;
    private Answers answers;
    private CharacterResult characterResult;
    private DataSavingTest savingData;
  
    private int characterOne =0;
    private int characterTwo =1;
    private int characterThree =2;
    private int characterFour;
    private int characterFive;
    private int characterSix;
    private int highestInt;
    public int currentCharacter = 0;

    public int[] answerValue;
    public int[] statementAnswers;
    public int[] charArray;

    [SerializeField]
    private int maxStatements;


    void Start ()
    {
        statementAnswers = new int[18];
        charArray = new int[3];
        answerValue = new int[18]; //MOET 18 WORDEN
        acceptChoice = FindObjectOfType<AcceptChoice>();
        answers = FindObjectOfType<Answers>();
        savingData = FindObjectOfType<DataSavingTest>();
        characterResult = FindObjectOfType<CharacterResult>();

        #region Point selection

        #region Character1

        char1Points.Add(new Character1PointsData(100, 25, 0, 50)); // Eerste stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 25)); // Tweede stelling)
        char1Points.Add(new Character1PointsData(25, 100, 50, 0)); // derde stelling)
        char1Points.Add(new Character1PointsData(25, 100, 50, 0)); // vierde stelling)
        char1Points.Add(new Character1PointsData(25, 100, 50, 0)); // vijfde stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // zesde stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // zevende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // achtste stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // negende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // tiende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // elfde stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // twaalfde stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // dertiende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // veertiende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // vijftiende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // zestiende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // zeventiende stelling)
        char1Points.Add(new Character1PointsData(50, 50, 25, 100)); // achtiende stelling)
        #endregion Character1

        #region Character2

        char2Points.Add(new Character2PointsData(0, 50, 100, 25)); // Eerste stelling)
        char2Points.Add(new Character2PointsData(100, 25, 0, 50)); // tweede stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // derde stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // vierde stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // vijfde stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // zesde stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // zevende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // achtste stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // negende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // tiende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // elfde stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // twaalfde stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // dertiende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // veertiende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // vijftiende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // zestiende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // zeventiende stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // achtiende stelling)

        #endregion Character2

        #region Character3

        char3Points.Add(new Character3PointsData(4, 3, 2, 1, "characterThree")); // Eerste stelling)
        char3Points.Add(new Character3PointsData( 1, 2, 3, 4, "characterThree")); // tweede stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // derde stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // vierde stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // vijfde stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // zesde stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // zevende stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // achste stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // negende stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // tiende stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // elfde stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // twaalfde stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // dertiende stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // veertiende stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // vijftiende stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // zestiende stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // zeventiende stelling)
        char3Points.Add(new Character3PointsData(50, 50, 25, 100, "characterThree")); // achtiende stelling)

        #endregion Character3
    }
    #endregion Point selection

    public void Update()
    {
        StoreData();
    }

    public int GivePoints (int classAwnserValue, int character)
    {
        character += classAwnserValue;
        return character;
    }

    public void SaveAnswer()
    {
        statementAnswers[acceptChoice.currentStatement] = answers.givenAnswer;
    }

    public void AnswerCharLoop()
    {
        foreach (int o in charArray)
        {
            charArray[currentCharacter] = GivePoints(answerValue[currentCharacter], o);
            currentCharacter++;
        }

        if (acceptChoice.currentStatement == 17)// MAAK HIER 17 VAN)
        {
            characterResult.GetTheHighest(charArray, highestInt);
        }
        currentCharacter = 0;
    }

    public void StoreData()
    {
        // PlayerPrefs.SetString("CharNameOne", "Loner");

        if (acceptChoice.currentStatement >= maxStatements)
        {
            savingData.SaveData("Loner", "Optimist", "Pesimist", characterOne, characterTwo, characterThree, acceptChoice.currentStatement, answers.givenAnswer);

            Debug.Log("Character One Name: " + PlayerPrefs.GetString("Character One Name: ") + ". Score: "  + PlayerPrefs.GetInt("Loner Score"));
        }

        //Debug.Log(PlayerPrefs.GetString("CharNameOne"));
    }
}
