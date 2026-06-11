using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class BuffSystem : MonoBehaviour
{
    private Dictionary<ThirdUnitBrain, List<Buff>> Regis = new Dictionary<ThirdUnitBrain, List<Buff>>();
    // Start is called before the first frame update
    private void Awake()
    {
        ServiceLocator.Register(this);
    }
    void DEL(ThirdUnitBrain unit, Buff newbanis)
    {
        if (!Regis.ContainsKey(unit))
        {
            Regis[unit] = new List<Buff>();
        }
        Regis[unit].Add(newbanis);
    }
    public float Spede(float baseSpes,ThirdUnitBrain unit)
    {
        if (!Regis.ContainsKey(unit))
        {
            return baseSpes;
        }
        else
        {

           float todModifecater = 1f;

            foreach (var item in Regis[unit])
            {
                //item *= todModifecater;

            }
                return baseSpes * todModifecater;

        }
    }
}
