using UnityEngine;

[CreateAssetMenu(menuName = "Object")]
public class Scriptables : ScriptableObject
{
    public ObjectType type;
    public EnemyTypes enemyTypes;
    public BuildingTypes buildingTypes;
    public EnemyStats enemyStats;
    public BuildingStats buildingStats;
    public CombatBuildingStats combatBuildingStats;
    public PassiveBuildingStats passiveBuildingStats;
    public WallStats wallStats;

    //public ResourceTypes resourceTypes;
}
public enum ObjectType
{
    Enemy,
    Building
}
public enum EnemyTypes
{
    Melee,
    Ranged,
    Tank
}
[System.Serializable]
public struct EnemyStats
{
    public float health;
    public float damage;
    public float speed;
}
public enum BuildingTypes
{
    Combat,
    Passive,
    Wall
}
[System.Serializable]
public struct BuildingStats
{
    public float health;
    public int level;
}
[System.Serializable]
public struct CombatBuildingStats
{
    public float damage;
    public float attackSpeed;
}
[System.Serializable]
public struct PassiveBuildingStats
{
    public ResourceTypes resourceTypes;
    public float generationSpeed;
}
public enum ResourceTypes
{
    Lithium, //Nieuwe Tiles kopen.
    Volts, //Buildings Healen / Boosten
    USB //Buildings upgraden
}
[System.Serializable]
public struct WallStats
{
    public float dmgReduction;
}