using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Move", menuName = "Create new move" )]
public class MoveBase : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;


    public string Name
    {
        get { return name; }
    }


    public string Description
    {
        get { return description; }
    }

    public int Power
    {
        get { return power; }
    }

    public int Accuracy
    {
        get { return accuracy; }
    }

    public int PP
    {
        get { return pp; }
    }

}
