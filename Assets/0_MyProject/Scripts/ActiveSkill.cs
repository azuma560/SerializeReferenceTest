using System;
using UnityEngine;

[Serializable]
public class ActiveSkill
{
   [SerializeField] private string _id;
   [SerializeField] private string _name;
   [SerializeField] private int _amount;
   // [SerializeReference]を付けたらポリモーフィズム機能しそうだけど無くても効いてる???
   [SerializeReference][SerializeField] private SkillExecutor _executor;
   
   public string Id => _id;
   public string Name => _name;

   public SkillExecutor Executor => _executor;

   public ActiveSkill(string id, string name, int amount, string executorTypeName)
   {
      _id = id;
      _name = name;
      _amount = amount;
      Type executorType = Type.GetType(executorTypeName);
      _executor = (SkillExecutor)Activator.CreateInstance(executorType ?? throw new Exception());
   }
   
   public void Execute()
   {
      Debug.Log($"{Name}が発動！");
      _executor.Execute(_amount);
   }
}

public abstract class SkillExecutor
{
   public abstract void Execute(int amount);
}

[Serializable]
public class PhysicExecutor : SkillExecutor
{
   public override void Execute(int amount)
   {
      Debug.Log($"物理ダメージを{amount}与えた！");
   }
}

[Serializable]
public class MagicExecutor : SkillExecutor
{
   public override void Execute(int amount)
   {
      Debug.Log($"魔法ダメージを{amount}与えた！");
   }
}

[Serializable]
public class PoisonExecutor : SkillExecutor
{
   public override void Execute(int amount)
   {
      Debug.Log($"毒を{amount}与えた！");
   }
}