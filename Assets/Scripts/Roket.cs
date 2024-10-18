using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class Roket : MonoBehaviour
{
    private RocketMove _roketMove;
    private RocketEnergySystem _rocketEnergySystem;

    private void Awake()
    {
        _roketMove = GetComponent<RocketMove>();
        _rocketEnergySystem = GetComponent<RocketEnergySystem>();
    }

    public void ShootBtn()
    {
        _rocketEnergySystem.UseFuel();
        _roketMove.ShootMove(_rocketEnergySystem.fuel,_rocketEnergySystem.FUELPERSHOOT);
    }
}



