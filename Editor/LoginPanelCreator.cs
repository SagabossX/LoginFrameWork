using UnityEngine;
using UnityEditor;

namespace LoginToolLib
{
   
    public class LoginPanelCreator
    {
        private static GameObject LoginPanelprefab;

        [MenuItem("Tools/Create LoginPanel")]
        private static void NewMenuOption()
        {
            LoginPanelprefab = (GameObject)AssetDatabase.LoadAssetAtPath("Packages/com.saga.loginframework/Editor/LoginPanel.prefab", typeof(GameObject));
            GameObject obj = PrefabUtility.InstantiatePrefab(LoginPanelprefab) as GameObject;
            Selection.activeGameObject = obj;
        }
    }
}

