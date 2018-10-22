using System;
using System.Collections.Generic;

public enum Status{
    Successed,
    Failed,
    Tried,
    New
}

public interface QuesiteSet {
    int getAttemps();
    int getBestScore();
    Status getStatus();
    Status registerAttempt();
    List<MyTriple> getQuestions();
    int getNumberOfQuestions();

    /* Returns the current question if available, null otherwise */
    MyTriple getCurrentQuestion();

    /* Register the response of the current question 
     * Returns the new current question
    */
    MyTriple registerResponse(string response);
    int getCurrentID();
}

