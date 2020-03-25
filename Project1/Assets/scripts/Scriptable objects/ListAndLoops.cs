using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ListAndLoops : ScriptableObject
{
    public List<string> stringList;
    public string singleString;

    public void AddToList(string stringObj)
    {
        stringList.Add(stringObj);
    }

    public void RemoveFromList(string stringObJ)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == stringObJ)
            {
                stringList.Remove(stringObJ);
            }
        }
    }

    public void SortList()
    {
        stringList.Sort();
    }
    
    public void CheckList()
    {
        foreach (var obj in stringList)
        {
            if (obj != singleString)
            {
                Debug.Log(obj);
            }
        }
    }
}