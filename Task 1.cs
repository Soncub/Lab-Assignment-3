using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] private int [] gradeScores;
    [SerializeField] private int gradeScoresTotal;
    [SerializeField] private float average;
    [SerializeField] private string LetterGrade;

    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < gradeScores.Length; i++) 
       {
         gradeScoresTotal += gradeScores[i];
       }
        average = gradeScoresTotal / gradeScores.Length;
        average = Mathf.Round(average);

            if(average >= 90)
            {
                LetterGrade = "A";
            }
            else if(average <= 89 && average >= 80)
            {
                LetterGrade = "B";
            }
            else if(average <= 79 && average > 70)
            {
                LetterGrade = "C";
            }
            else if(average <= 69 && average > 60)
            {
                LetterGrade = "D";
            }
            else
            {
                LetterGrade = "E";
            }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("10 Weeks");
        Debug.Log("5 Modules in 10 weeks 50%*0.15");
        Debug.Log("10 readings in 10 weeks 100%");
        Debug.Log("3 quiz in 10 weeks 30%");
        Debug.Log("5 assignments in 10 weeks 50%");
        Debug.Log("instructor taught it before 0%");
    }
}
