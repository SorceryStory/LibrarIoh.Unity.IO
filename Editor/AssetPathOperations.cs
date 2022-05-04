using SorceressSpell.LibrarIoh.IO;
using UnityEditor;
using UnityEngine;

namespace SorceressSpell.LibrarIoh.Unity.IO.Editor
{
    public static class AssetPathOperations
    {
        #region Methods

        public static string GetAssetFullPath(UnityEngine.Object unityObject)
        {
            return
                PathOperations.Combine(
                    PathOperations.RemoveLastComponent(Application.dataPath, true),
                    AssetDatabase.GetAssetPath(unityObject));
        }

        #endregion Methods
    }
}
