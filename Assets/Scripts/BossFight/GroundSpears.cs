using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;


namespace BossFight
{
    public class GroundSpears : MonoBehaviour
    {
        float distanceS = 0.5f;
        [SerializeField]
        GameObject spearHoles, spear;
        private float timeForSpear = 1;
        int i = 0;

        void Start()
        {
            spearHoles = GameObject.Find("SpearHoles");
            spear = Resources.Load("Prefabs/BossFight/Spear") as GameObject;
        }



        IEnumerable spearTime()
        {
            Instantiate(spear, spearHoles.transform.GetChild(i));
            yield return new WaitForSeconds(timeForSpear);
            i++;
        }

    }
}