using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour {

    private AcceptChoice acceptChoice;
    private CharacterManager characterManager;

    public int slidervalue2;
    public Slider swordSlider;

    public int givenAnswer;



    void Start()
    {
        acceptChoice = FindObjectOfType<AcceptChoice>();
        characterManager = FindObjectOfType<CharacterManager>();
    }  


    public void AnswerValueCheck()
    {
        if (swordSlider.value == 0)
        {
            givenAnswer = 1;
            if (acceptChoice.hasAccepted)
            {
                characterManager.answerValue[0] = characterManager.char1Points[acceptChoice.currentStatement].classAwnserValue1;
                characterManager.answerValue[1] = characterManager.char2Points[acceptChoice.currentStatement].classAwnserValue1;
                characterManager.answerValue[2] = characterManager.char3Points[acceptChoice.currentStatement].classAwnserValue1;
                characterManager.AnswerCharLoop();
            }
        }
        if (swordSlider.value == 1)
        {
            givenAnswer = 2;
            if (acceptChoice.hasAccepted)
            {
                characterManager.answerValue[0] = characterManager.char1Points[acceptChoice.currentStatement].classAwnserValue2;
                characterManager.answerValue[1] = characterManager.char2Points[acceptChoice.currentStatement].classAwnserValue2;
                characterManager.answerValue[2] = characterManager.char3Points[acceptChoice.currentStatement].classAwnserValue2;
                characterManager.AnswerCharLoop();
            }
        }
        if (swordSlider.value == 2)
        {
            givenAnswer = 3;
            if (acceptChoice.hasAccepted)
            {
                characterManager.answerValue[0] = characterManager.char1Points[acceptChoice.currentStatement].classAwnserValue3;
                characterManager.answerValue[1] = characterManager.char2Points[acceptChoice.currentStatement].classAwnserValue3;
                characterManager.answerValue[2] = characterManager.char3Points[acceptChoice.currentStatement].classAwnserValue3;
                characterManager.AnswerCharLoop();
            }
        }

        if (swordSlider.value == 3)
        {
            givenAnswer = 4;
            if (acceptChoice.hasAccepted)
            {
                characterManager.answerValue[0] = characterManager.char1Points[acceptChoice.currentStatement].classAwnserValue4;
                characterManager.answerValue[1] = characterManager.char2Points[acceptChoice.currentStatement].classAwnserValue4;
                characterManager.answerValue[2] = characterManager.char3Points[acceptChoice.currentStatement].classAwnserValue4;
                characterManager.AnswerCharLoop();
            }
        }
    } 
    
    public void Onclick(int slidervalue2)
    {
        swordSlider.value = slidervalue2;
    }
}
