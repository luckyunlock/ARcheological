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
    void registerResponse(int qID, string response);
    int getCurrentID();
}

