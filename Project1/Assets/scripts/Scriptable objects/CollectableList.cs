using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectableList : ScriptableObject
{
    public List<Collectable> collectables;

    public void AddToCollection(Collectable listObj)
    {
        collectables.Add(listObj);
    }

    public void RemoveFromCollection(Collectable listObj)
    {
        for (int i = 0; i < collectables.Count; i++)
        {
            collectables.Remove(listObj);
        }
    }

    public void SortCollectables()
    {
        collectables.Sort();
    }
}