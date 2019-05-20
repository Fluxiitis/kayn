namespace EasyAhri
{

using System;
using System.Linq;
using EnsoulSharp.SDK;
using EnsoulSharp.SDK.Prediction;
using EnsoulSharp.SDK.Utility;
using EnsoulSharp.SDK.MenuUI;

using Color = System.Drawing.Color;

internal class Ahri
{
	private static Spell Q, W, E, R;
	public static void OnLoad()
	{
		Q = new Spell(SpellSlot.Q, 950f);
        W = new Spell(SpellSlot.W, 800f);
        E = new Spell(SpellSlot.E, 975f);
        R = new Spell(SpellSlot.R, 450f);

        Q.SetSkillshot(0.25f, 100f, 1250f, false, SkillshotType.Line);
        E.SetSkillshot(0.25f, 60f, 1500f, true, SkillshotType.Line);
	
	var MyMenu = new Menu("EasyAhri", "EasyAhri", true);

		var combo = new Menu("combo", "Combo settings");
        combo.Add(MenuWrapper.Combo.Q);
        combo.Add(MenuWrapper.Combo.W);
        combo.Add(MenuWrapper.Combo.E);
		MyMenu.Add(combo);

		var harass = new Menu("harass", "Harass Settings");
        harass.Add(MenuWrapper.Harass.Q);
        harass.Add(MenuWrapper.Harass.W);
        harass.Add(MenuWrapper.Harass.E);
        harass.Add(MenuWrapper.Harass.Mana);
		MyMenu.Add(harass);		
		
        var draw = new Menu("draw", "Draw Settings");
        draw.Add(MenuWrapper.Draw.Q);
        draw.Add(MenuWrapper.Draw.W);
        draw.Add(MenuWrapper.Draw.E);
        draw.Add(MenuWrapper.Draw.R);
        MyMenu.Add(draw);
		
		MyMenu.Attach();
		
		Game.OnUpdate += OnUpdate;
        Gapcloser.OnGapcloser += OnGapcloser;
        Interrupter.OnInterrupterSpell += OnInterrupterSpell;
        Drawing.OnDraw += OnDraw;
	}
	
	private static void OnCombo()
	{
		var target = TargetSelector.GetTarget(E.Range);
		if (target == null || !target.IsValidTarget(E.Range))
		{	
			if (MenuWrapper.combo.E.Enabled && E.IsReady())
			{
				var ePred = E.GetPrediction(target);
				if (ePred.HitChance >= HitChance.VeryHigh)
				{
					E.Cast(ePred.castPosition);
				}
			}
		}
        if (MenuWrapper.combo.Q.Enabled && Q.IsReady())
		{
			var target = TargetSelector.GetTarget(Q.Range);
			if (target != null && target.IsValidTarget(Q.Range))
			{
				var pred = Q.GetPrediction(target);
				if (qPred.HitChance.High)
				{
					Q.Cast(qPred.castPosition);
				}
			}	
		}	
	}
	
	private static void OnHarass()
	{
		
	}
	
	
}
}