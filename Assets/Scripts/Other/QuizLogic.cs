using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizLogic : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject question5;
    public GameObject question6;
    public GameObject question7;
    public GameObject thankYou;
    public GameObject start;

    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(false);

    }
    public void QuestionOne()
    {
        start.SetActive(false);
        question1.SetActive(true);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(false);
    }
    public void QuestionTwo()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(true);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(false);
    }
    public void QuestionThree()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(true);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(false);
    }
    public void QuestionFour()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(true);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(false);
    }
    public void QuestionFive()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(true);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(false);
    }
    public void QuestionSix()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(true);
        question7.SetActive(false);
        thankYou.SetActive(false);
    }
    public void QuestionSeven()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(true);
        thankYou.SetActive(false);
    }
    public void TY()
    {
        start.SetActive(false);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        thankYou.SetActive(true);
    }
    
    public void ToMain()
    {
        Application.LoadLevel(0);
    }
}
