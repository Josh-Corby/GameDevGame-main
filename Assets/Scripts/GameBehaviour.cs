using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    //Singletons used in this project
    protected static GameManager _GM { get { return GameManager.instance; } }
    protected static EnemyManager _TM { get { return EnemyManager.instance; } }
    protected static UIManager _UI { get { return UIManager.instance; } }

    protected static PlayerHealth _PH { get { return PlayerHealth.instance; } }
}
