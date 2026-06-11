using System.Collections;
using System.Collections.Generic;
using Model.Runtime.Projectiles;
using UnityEngine;
using Utilities;

public class EfectsRa : MonoBehaviour
{
    public int rand;
   public ThirdUnitBrain brain;
    LocationService serviceunit;
    public ArchToTileProjectile fsa;
    // Start is called before the first frame update
    void Start()
    {
       brain =  ServiceLocator.Get<ThirdUnitBrain>();
        fsa = ServiceLocator.Get<ArchToTileProjectile>();
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                fsa.ProjectileSpeed = 4;
                break;
            case 1:
                fsa.ProjectileSpeed = 7;
                break;
            case 2:
                fsa.ProjectileSpeed = 10;
                break;

            default:
                break;
        }
    }
}
