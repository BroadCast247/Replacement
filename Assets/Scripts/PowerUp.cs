using UnityEngine;

[CreateAssetMenu(menuName = "Power Up")]
public class PowerUp : ScriptableObject
{
    [Range(1,10)]
    public int ATK;
    [Range(0,2)]
    public float ROF;
    public Sprite weaponSprite;
    //Enumerator PowerUpType?
}