using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunterQuest : Quest{
    void Awake(){
        questName = "Treasure Hunter";
        description = "Hunter some treasures.";
        itemRewards = new List<string>() {"Ruby Talisman"};
        goal = new CollectionGoal(1, 0, this);

    }

    public override void Complete(){
        base.Complete();
    }

}

