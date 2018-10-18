using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class AnchorQuesite : MonoBehaviour,QuesiteSet
{
    int attempts = 0;
    int bestScore = 0;
    int currentScore = 0;
    public int currentID = 0;

    public Status status = Status.New;
    public List<MyTriple> questions = new List<MyTriple>();

    public AnchorQuesite(){
        questions.Add(new MyTriple(0, "q0", true));
        questions.Add(new MyTriple(1, "q1", false));
        questions.Add(new MyTriple(2, "q2", true));
        questions.Add(new MyTriple(3, "q3", true));
    }

    public int getAttemps(){ return attempts; }
    public int getBestScore(){ return bestScore; }
    public int getCurrentID() { return currentID;  }

    public int getNumberOfQuestions() { return questions.Count; }
    public List<MyTriple> getQuestions(){ return questions;}
    public Status getStatus(){return status;}
    public void registerResponse(int qID, string response){
        Debug.Log("User respons " + response);
        currentID++;
        if (String.Compare(response, "pass", ignoreCase: true) != 0){
            bool bool_response = (String.Compare(response, "true", ignoreCase: true) == 0);
            if (questions.Find(x => x.id == qID).r == bool_response)
                currentScore++;
            else
                currentScore--;
        }
    }

    public Status registerAttempt(){
        int old_currentScore = currentScore;
        currentScore = 0;
        attempts++;
        if (old_currentScore > bestScore) bestScore = old_currentScore;
        if (old_currentScore >= 5) { this.status = Status.Successed; return status; }
        if (attempts >= 4) { this.status = Status.Failed; return status; }
        this.status = Status.Tried;
        return status;
    }
}

