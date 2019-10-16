using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 本来はスプレッドシートやExcelからデータを読み込むが今回は代わりにstatic classにハードコーディングして参照する
public class ActiveSkillData
{
    public class Param
    {
        public string Id;
        public string Name;
        public int Amount;
        public string ExecutorTypeName;

        public Param(string id, string name, int amount, string executorTypeName)
        {
            Id = id;
            Name = name;
            Amount = amount;
            ExecutorTypeName = executorTypeName;
        }
    }
    
    public static readonly Param[] PARAMS = new Param[]
    {
        new Param("slash", "スラッシュ", 10,"PhysicExecutor"), 
        new Param("fire", "ファイア", 15,"MagicExecutor"), 
        new Param("poison", "ポイズン", 50,"PoisonExecutor")
    };
}
