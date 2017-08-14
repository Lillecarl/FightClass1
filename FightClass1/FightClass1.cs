using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using robotManager;
using robotManager.FiniteStateMachine;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using wManager.Wow.Bot.States;
using Timer = robotManager.Helpful.Timer;
using wManager.Wow.Enums;
using FightClass1;
using FightClass1.FightClasses;
using SpellWork;
using WoWDB;

public class Main : ICustomClass
{
    public float Range { get { return 5; } }

    private Engine engine;

    public void Initialize()
    {
        if (Directory.Exists(@"Data\DBC"))
        {
            lock (Global.DBCLock)
            {
                DBC.Spell = DBCReader.ReadDBC<SpellEntry>(DBC.SpellStrings);
                DBC.SkillLine = DBCReader.ReadDBC<SkillLineEntry>(DBC.SkillLineStrings);
                DBC.SpellRange = DBCReader.ReadDBC<SpellRangeEntry>(DBC.SpellRangeStrings);

                DBC.SpellDuration = DBCReader.ReadDBC<SpellDurationEntry>(null);
                DBC.SkillLineAbility = DBCReader.ReadDBC<SkillLineAbilityEntry>(null);
                DBC.SpellRadius = DBCReader.ReadDBC<SpellRadiusEntry>(null);
                DBC.SpellCastTimes = DBCReader.ReadDBC<SpellCastTimesEntry>(null);
            }
        }
        else
            Logging.WriteError("DBC Folder doesn't exist!");

        DataMgr.Init();


        engine = new Engine(false);
        engine.States.Add(new CombatState { Priority = int.MaxValue });

        engine.States.Sort();
        engine.StartEngine(10, "Carlcombat", true);
    }

    public void Dispose()
    {
        if (engine != null)
        {
            engine.StopEngine();
            engine.States.Clear();
        }
    }

    public void ShowConfiguration()
    {
    }
}

class CombatState : State
{
    public override string DisplayName
    {
        get { return "Carlcombat"; }
    }

    public override bool NeedToRun
    {
        get
        {
            return true;
        }
    }

    private bool firstrun = true;
    private FighterBase fighterbase;

    public override void Run()
    {
        if (firstrun)
        {
            firstrun = false;

            fighterbase = new Druid_Feral();
            fighterbase.Init();
        }
        else
            fighterbase.Update();
    }
}
