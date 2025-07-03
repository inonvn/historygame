using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "carduse",menuName = "cardManager")]
public class cardManager : ScriptableObject
{
  public string cardName;
    public int dame;
    public int hp;
    public int mana;
    public typecard type;

  public  enum typecard
    {
        none,
        fire,
        water,
        grass,
        dirt,
        material,
    }
}
