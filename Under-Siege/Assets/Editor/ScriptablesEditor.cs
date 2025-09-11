using UnityEditor;

[CustomEditor(typeof(Scriptables))]
public class ScriptablesEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        SerializedProperty type = serializedObject.FindProperty("type");
        SerializedProperty enemyTypes = serializedObject.FindProperty("enemyTypes");
        SerializedProperty buildingTypes = serializedObject.FindProperty("buildingTypes");
        SerializedProperty enemyStats = serializedObject.FindProperty("enemyStats");
        SerializedProperty buildingStats = serializedObject.FindProperty("buildingStats");
        SerializedProperty combatBuildingStats = serializedObject.FindProperty("combatBuildingStats");
        SerializedProperty passiveBuildingStats = serializedObject.FindProperty("passiveBuildingStats");
        SerializedProperty wallStats = serializedObject.FindProperty("wallStats");
        //SerializedProperty resourceTypes = serializedObject.FindProperty("resourceTypes");

        EditorGUILayout.PropertyField(type);

        if ((ObjectType)type.enumValueIndex == ObjectType.Enemy)
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Enemy Only", EditorStyles.boldLabel);

            EditorGUILayout.PropertyField(enemyTypes);
            EditorGUILayout.PropertyField(enemyStats);
        }
        if ((ObjectType)type.enumValueIndex == ObjectType.Building)
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Building Only", EditorStyles.boldLabel);

            EditorGUILayout.PropertyField(buildingTypes);
            EditorGUILayout.PropertyField(buildingStats);
            switch ((BuildingTypes)buildingTypes.enumValueIndex)
            {
                case BuildingTypes.Combat:
                    EditorGUILayout.PropertyField(combatBuildingStats, true);
                    break;
                case BuildingTypes.Passive:
                    EditorGUILayout.PropertyField(passiveBuildingStats, true);
                    //EditorGUILayout.PropertyField(resourceTypes);
                    break;
                case BuildingTypes.Wall:
                    EditorGUILayout.PropertyField(wallStats, true);
                    break;
            }
        }










        serializedObject.ApplyModifiedProperties();
    }
}
