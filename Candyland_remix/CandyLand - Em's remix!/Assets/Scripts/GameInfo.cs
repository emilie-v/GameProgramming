
using System;


[Serializable]
public class GameInfo
{
    public string gameID;
    public string status;
    public string player2;
    public string player1;

    //instead of p1 p2 string, need userInfo
    // list of winners, userinfo
    //player list, userinfo
    //current player int
}

[Serializable]
public class UserInfo
{
    public string activeGame;
    //add so players can see positions
    //name above players that follows them - string
    //choose character before new game. 
    //bool - chosen char or not
    //id / int player number
    // win / lose . win bool
}