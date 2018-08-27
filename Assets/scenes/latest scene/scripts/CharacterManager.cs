    using System.Collections;
    using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public List<Character1PointsData> char1Points = new List<Character1PointsData>();
    public List<Character2PointsData> char2Points = new List<Character2PointsData>();
    public List<Character3PointsData> char3Points = new List<Character3PointsData>();
    public List<Character4PointsData> char4Points = new List<Character4PointsData>();
    public List<Character5PointsData> char5Points = new List<Character5PointsData>();
    public List<Character6PointsData> char6Points = new List<Character6PointsData>();

    public bool hasEnded;

    private AcceptChoice acceptChoice;
    private Answers answers;
    private CharacterResult characterResult;
 //   private DataSavingTest savingData;
  
    private int characterOne =0;
    private int characterTwo =1;
    private int characterThree =2;
    private int characterFour;
    private int characterFive;
    private int characterSix;
    private int highestInt;
    private int lowestInt;

    public int currentCharacter = 0;
    public int[] answerValue;
    public int[] statementAnswers;
    public int[] charArray;

    [SerializeField]
    private int maxStatements;


    void Start ()
    {
        statementAnswers = new int[23];
        charArray = new int[6];
        answerValue = new int[23];
        acceptChoice = FindObjectOfType<AcceptChoice>();
        answers = FindObjectOfType<Answers>();
        //savingData = FindObjectOfType<DataSavingTest>();
        characterResult = FindObjectOfType<CharacterResult>();

        #region Point selection

        #region Character1
        // "Betrouwbare" character

        char1Points.Add(new Character1PointsData(50, 100, 50, 0)); // Eerste stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // Tweede stelling)
        char1Points.Add(new Character1PointsData(100, 50, 0, 0)); // derde stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 50)); // vierde stelling)
        char1Points.Add(new Character1PointsData(50, 100, 50, 0)); // vijfde stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // zesde stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // zevende stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // achtste stelling)
        char1Points.Add(new Character1PointsData(100, 50, 0, 0)); // negende stelling)
        char1Points.Add(new Character1PointsData(50, 100, 50, 0)); // tiende stelling)
        char1Points.Add(new Character1PointsData(50, 100, 50, 0)); // elfde stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // twaalfde stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 50)); // dertiende stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // veertiende stelling)
        char1Points.Add(new Character1PointsData(100, 50, 0, 0)); // vijftiende stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 50)); // zestiende stelling)
        char1Points.Add(new Character1PointsData(50, 100, 50, 0)); // zeventiende stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 50)); // achtiende stelling)
        char1Points.Add(new Character1PointsData(100, 50, 0, 0)); // negentiende stelling)
        char1Points.Add(new Character1PointsData(100, 50, 0, 0)); // twintigste stelling)
        char1Points.Add(new Character1PointsData(0, 0, 50, 100)); // eenentwintigste stelling)
        char1Points.Add(new Character1PointsData(50, 100, 50, 0)); // tweeentwintigste stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 50)); // drieentwintigste stelling)
        char1Points.Add(new Character1PointsData(100, 50, 0, 0)); // vierentwintigste stelling)

        #endregion Character1

        #region Character2
        // "Feestbeest" character

        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // Eerste stelling)
        char2Points.Add(new Character2PointsData(100, 50, 0, 0)); // tweede stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // derde stelling)
        char2Points.Add(new Character2PointsData(50, 100, 50, 0)); // vierde stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // vijfde stelling)
        char2Points.Add(new Character2PointsData(50, 100, 50, 0)); // zesde stelling)
        char2Points.Add(new Character2PointsData(50, 100, 50, 0)); // zevende stelling)
        char2Points.Add(new Character2PointsData(100, 50, 0, 0)); // achtste stelling)
        char2Points.Add(new Character2PointsData(0, 50, 100, 50)); // negende stelling)
        char2Points.Add(new Character2PointsData(0, 50, 100, 50)); // tiende stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // elfde stelling)
        char2Points.Add(new Character2PointsData(50, 100, 50, 0)); // twaalfde stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // dertiende stelling)
        char2Points.Add(new Character2PointsData(100, 50, 0, 0)); // veertiende stelling)
        char2Points.Add(new Character2PointsData(0, 50, 100, 50)); // vijftiende stelling)
        char2Points.Add(new Character2PointsData(50, 100, 50, 0)); // zestiende stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // zeventiende stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // achtiende stelling)
        char2Points.Add(new Character2PointsData(0, 50, 100, 50)); // negentiende stelling)
        char2Points.Add(new Character2PointsData(0, 0, 50, 100)); // twintigste stelling)
        char2Points.Add(new Character2PointsData(50, 100, 50, 0)); // eenentwintigste stelling)
        char2Points.Add(new Character2PointsData(0, 50, 100, 50)); // tweeentwintigste stelling)
        char2Points.Add(new Character2PointsData(100, 50, 0, 0)); // drieentwintigste stelling)
        char2Points.Add(new Character2PointsData(0, 50, 100, 50)); // vierentwintigste stelling)

        #endregion Character2

        #region Character3
        // "Idealist" character

        char3Points.Add(new Character3PointsData(100, 50, 0, 0)); // Eerste stelling)
        char3Points.Add(new Character3PointsData( 0, 50, 100, 50)); // tweede stelling)
        char3Points.Add(new Character3PointsData(0, 50, 100, 50)); // derde stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // vierde stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // vijfde stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // zesde stelling)
        char3Points.Add(new Character3PointsData(100, 50, 0, 0)); // zevende stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // achste stelling)
        char3Points.Add(new Character3PointsData(0, 0, 50, 100)); // negende stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // tiende stelling)
        char3Points.Add(new Character3PointsData(0, 50, 100, 50)); // elfde stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // twaalfde stelling)
        char3Points.Add(new Character3PointsData(100, 50, 0, 0)); // dertiende stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // veertiende stelling)
        char3Points.Add(new Character3PointsData(0, 0, 50, 100)); // vijftiende stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // zestiende stelling)
        char3Points.Add(new Character3PointsData(0, 50, 100, 50)); // zeventiende stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // achtiende stelling)
        char3Points.Add(new Character3PointsData(0, 0, 50, 100)); // negentiende stelling)
        char3Points.Add(new Character3PointsData(0, 50, 100, 50)); // twintigste stelling)
        char3Points.Add(new Character3PointsData(100, 50, 0, 0)); // eenentwintigste stelling)
        char3Points.Add(new Character3PointsData(0, 50, 100, 50)); // tweeentwintigste stelling)
        char3Points.Add(new Character3PointsData(50, 100, 50, 0)); // drieentwintigste stelling)
        char3Points.Add(new Character3PointsData(0, 50, 100, 50)); // vierentwintigste stelling)

        #endregion Character3

        #region Character4
        // "Loner" character

        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // Eerste stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // tweede stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // derde stelling)
        char4Points.Add(new Character4PointsData(0, 0, 50, 100)); // vierde stelling)
        char4Points.Add(new Character4PointsData(100, 50, 0, 0)); // vijfde stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // zesde stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // zevende stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // achste stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // negende stelling)
        char4Points.Add(new Character4PointsData(0, 0, 50, 100)); // tiende stelling)
        char4Points.Add(new Character4PointsData(100, 50, 0, 0)); // elfde stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // twaalfde stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // dertiende stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // veertiende stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // vijftiende stelling)
        char4Points.Add(new Character4PointsData(0, 0, 50, 100)); // zestiende stelling)
        char4Points.Add(new Character4PointsData(100, 50, 0, 0)); // zeventiende stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // achtiende stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // negentiende stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // twintigste stelling)
        char4Points.Add(new Character4PointsData(0, 50, 100, 50)); // eenentwintigste stelling)
        char4Points.Add(new Character4PointsData(100, 50, 0, 0)); // tweeentwintigste stelling)
        char4Points.Add(new Character4PointsData(0, 0, 50, 100)); // drieentwintigste stelling)
        char4Points.Add(new Character4PointsData(50, 100, 50, 0)); // vierentwintigste stelling)

        #endregion Character4

        #region Character5
        // "Redder" character

        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // Eerste stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // tweede stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // derde stelling)
        char5Points.Add(new Character5PointsData(100, 50, 0, 0)); // vierde stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // vijfde stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // zesde stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // zevende stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // achste stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // negende stelling)
        char5Points.Add(new Character5PointsData(100, 50, 0, 0)); // tiende stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // elfde stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // twaalfde stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // dertiende stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // veertiende stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // vijftiende stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // zestiende stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // zeventiende stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // achtiende stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // negentiende stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // twintigste stelling)
        char5Points.Add(new Character5PointsData(0, 50, 100, 50)); // eenentwintigste stelling)
        char5Points.Add(new Character5PointsData(0, 0, 50, 100)); // tweeentwintigste stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // drieentwintigste stelling)
        char5Points.Add(new Character5PointsData(50, 100, 50, 0)); // vierentwintigste stelling)

        #endregion Character5

        #region Character6
        // "Tegendraads/Rebel" character

        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // Eerste stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // tweede stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // derde stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // vierde stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // vijfde stelling)
        char6Points.Add(new Character6PointsData(100, 50, 0, 0)); // zesde stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // zevende stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // achste stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // negende stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // tiende stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // elfde stelling)
        char6Points.Add(new Character6PointsData(100, 50, 0, 0)); // twaalfde stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // dertiende stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // veertiende stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // vijftiende stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // zestiende stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // zeventiende stelling)
        char6Points.Add(new Character6PointsData(100, 50, 0, 0)); // achtiende stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // negentiende stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // twintigste stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // eenentwintigste stelling)
        char6Points.Add(new Character6PointsData(50, 100, 50, 0)); // tweeentwintigste stelling)
        char6Points.Add(new Character6PointsData(0, 50, 100, 50)); // drieentwintigste stelling)
        char6Points.Add(new Character6PointsData(0, 0, 50, 100)); // vierentwintigste stelling)

        #endregion Character6
    }
    #endregion Point selection

    //public void Update()
    //{
    //    StoreData();
    //}

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

        if (acceptChoice.currentStatement == 23)
        {
            print("hoog en laag weer gegeven");
            characterResult.GetTheHighest(charArray, highestInt);
            characterResult.GetTheLowest(charArray, lowestInt);
            hasEnded = true;
            print("has ended is true");
            // knop moet weg en statement text moet weg
        }
        currentCharacter = 0;
    }

    //public void StoreData()
    //{
    //    if (acceptChoice.currentStatement >= maxStatements)
    //    {
    //        savingData.SaveData("Loner", "Optimist", "Pesimist", characterOne, characterTwo, characterThree, acceptChoice.currentStatement, answers.givenAnswer);
    //    }
    //}
}
