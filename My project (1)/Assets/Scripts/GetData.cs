using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour
{
    public Entity_Sheet1 entity_GameDB;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Entity_Sheet1.Param Param in entity_GameDB.sheets[0].list)
        {
            Debug.Log(Param.index + " - " + Param.character + " - " + Param.Hp + " - " + Param.Mp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
