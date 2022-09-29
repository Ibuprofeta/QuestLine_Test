using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    public List<Quest> assignedQuests = new List<Quest>();

    [SerializeField]
    private QuestUIItem questUIItem;
    [SerializeField]
    private Transform questUIParent;

    private QuestDatabase questDatabase;

    private void Start(){
        questDatabase = GetComponent<QuestDatabase>();
    }

    public Quest AssignQuest(string questName){
        if(assignedQuests.Find(quest => quest.questName == questName)){
            Debug.LogWarning("Quest already assigned");
            return null;
        }

        Quest questToAdd = (Quest)gameObject.AddComponent(System.Type.GetType(questName));
        assignedQuests.Add(questToAdd);
        questDatabase.AddQuest(questToAdd);

        QuestUIItem questUI = Instantiate(questUIItem, questUIParent);
        questUI.Setup(questToAdd);
        return questToAdd;
    }
}
