using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Tester : MonoBehaviour
{
    [SerializeField] private DataMaster _dataMaster;

    [SerializeField] private Text _text;
    
    public void OnClickedTestButton()
    {
        Test();
    }
    
    
    // テスト用コード
    [ContextMenu("Test ActiveSkills")]
    void Test()
    {
        Debug.Log(_dataMaster.ActiveSkills.Count());
        
        foreach (var item in _dataMaster.ActiveSkills)
        {
            item.Execute();
        }
    }
}
