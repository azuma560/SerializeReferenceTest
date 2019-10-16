using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class DataMaster : ScriptableObject
{
    [SerializeField] List<ActiveSkill> _activeSkills = new List<ActiveSkill>();

    public IEnumerable<ActiveSkill> ActiveSkills => _activeSkills;

    public void AddActiveSkill(ActiveSkill activeSkill)
    {
        _activeSkills.Add(activeSkill);
    }
    
#if UNITY_EDITOR
    // ScriptableObject生成用コード
    [MenuItem("Assets/Create/ScriptableObjects/Create DataMaster")]
    public static void Create()
    {
        var asset = CreateInstance<DataMaster>();

        foreach (var item in ActiveSkillData.PARAMS)
        {
            asset.AddActiveSkill(new ActiveSkill(item.Id,item.Name,item.Amount,item.ExecutorTypeName));
        }
        
        AssetDatabase.CreateAsset(asset, "Assets/0_MyProject/ScriptableObjects/DataMaster.asset");
        AssetDatabase.Refresh();
    }
#endif
}
