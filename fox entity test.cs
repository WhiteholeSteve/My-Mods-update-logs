ModAPI.Register(
	new Modification()
	{
		OriginalItem = ModAPI.FindSpawnable("Human"),
		NameOverride = "FoxEntity",
		DescriptionOverride = "FoxEntity",
		CategoryOverride = ModAPI.FindCategory("Entities"),
		ThumbnailOverride = ModAPI.LoadSprite(".png"),
		AfterSpawn = (Instance) =>
		{
			foreach (var limb in Instance.GetComponent<PersonBehaviour>().Limbs)
            {
				if (!limb.HasBrain)
				{
					limb.transform.parent.localPosition = Vector3.zero;
				}
				else
				{
					limb.transform.GetChild(0).gameObject.SetActive(false); //brain matter stuff
				}
				if (limb.gameObject.GetComponent<GripBehaviour>() != null)
				{
					GameObject.Destroy(limb.gameObject.GetComponent<GripBehaviour>());
				}
            }


			PersonBehaviour person = Instance.GetComponent<PersonBehaviour>();
person.CountDeathAsStat = false;
  GameObject Limb1 = person.Limbs[0].gameObject;
  Limb1.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin1.png");
  Limb1.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh1.png").texture);
  Limb1.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone1.png").texture);
  Limb1.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage1.png").texture);
  Limb1.transform.localPosition = new Vector3(0.3003969f, 0.1248678f, 0f);
  Limb1.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb1.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb1.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb1.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb1.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb1.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb1.GetComponent<LimbBehaviour>().InitialHealth = 200f;
  Limb1.GetComponent<LimbBehaviour>().Health = 200f;
  Limb1.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb1.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb1.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb1.GetComponent<LimbBehaviour>().VitalParts = new Bounds[] {
new Bounds(new Vector3(-0.00555557f,0.03055555f,-2f),new Vector3(0.1100719f,0.06550996f,1f)),
new Bounds(new Vector3(-0.001851827f,-0.012963f,-2f),new Vector3(0.03692371f,0.07106556f,1f)),
};
  Limb1.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb1.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb1.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb1.GetComponent<LimbBehaviour>().HasBrain = true;
  GameObject Limb2 = person.Limbs[1].gameObject;
  Limb2.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin2.png");
  Limb2.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh2.png").texture);
  Limb2.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone2.png").texture);
  Limb2.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage2.png").texture);
  Limb2.transform.localPosition = new Vector3(0.4702513f, 0.06777194f, 0f);
  Limb2.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb2.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb2.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb2.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb2.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb2.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb2.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb2.GetComponent<LimbBehaviour>().Health = 50f;
  Limb2.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb2.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb2.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb2.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb2.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb2.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb2.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb2.GetComponent<LimbBehaviour>().HasBrain = true;
  GameObject Limb3 = person.Limbs[2].gameObject;
  Limb3.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin3.png");
  Limb3.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh3.png").texture);
  Limb3.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone3.png").texture);
  Limb3.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage3.png").texture);
  Limb3.transform.localPosition = new Vector3(0.4704368f, 0.0682737f, 0f);
  Limb3.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb3.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb3.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb3.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb3.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb3.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb3.GetComponent<LimbBehaviour>().InitialHealth = 20f;
  Limb3.GetComponent<LimbBehaviour>().Health = 20f;
  Limb3.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb3.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb3.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb3.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb3.AddComponent<GripBehaviour>().GripPosition = new Vector3(0.008333445f, -0.0287037f, ModAPI.PixelSize * 6f);
  Limb3.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb3.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb3.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb3.GetComponent<LimbBehaviour>().HasBrain = true;
  GameObject Limb4 = person.Limbs[3].gameObject;
  Limb4.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin4.png");
  Limb4.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh4.png").texture);
  Limb4.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone4.png").texture);
  Limb4.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage4.png").texture);
  Limb4.transform.localPosition = new Vector3(0.2863449f, 0.3210836f, 0.1f);
  Limb4.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb4.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb4.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
  Limb4.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb4.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb4.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb4.GetComponent<LimbBehaviour>().InitialHealth = 20f;
  Limb4.GetComponent<LimbBehaviour>().Health = 20f;
  Limb4.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb4.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb4.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb4.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb4.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb4.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb4.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb4.GetComponent<LimbBehaviour>().HasBrain = true;
  GameObject Limb5 = person.Limbs[4].gameObject;
  Limb5.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin5.png");
  Limb5.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh5.png").texture);
  Limb5.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone5.png").texture);
  Limb5.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage5.png").texture);
  Limb5.transform.localPosition = new Vector3(0.02893759f, 0.02108356f, 0f);
  Limb5.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb5.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Torso;
  Limb5.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb5.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb5.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb5.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb5.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb5.GetComponent<LimbBehaviour>().Health = 50f;
  Limb5.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb5.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb5.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb5.GetComponent<LimbBehaviour>().VitalParts = new Bounds[] {
new Bounds(new Vector3(-0.05614942f,0.03799482f,-2f),new Vector3(0.1239607f,0.08310257f,1f)),
};
  Limb5.GetComponent<CirculationBehaviour>().IsPump = true;
  Limb5.GetComponent<LimbBehaviour>().HasLungs = true;
  Limb5.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb5.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb6 = person.Limbs[5].gameObject;
  Limb6.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin6.png");
  Limb6.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh6.png").texture);
  Limb6.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone6.png").texture);
  Limb6.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage6.png").texture);
  Limb6.transform.localPosition = new Vector3(-0.2857654f, 0.02204952f, 0f);
  Limb6.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb6.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Torso;
  Limb6.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb6.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb6.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb6.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb6.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb6.GetComponent<LimbBehaviour>().Health = 50f;
  Limb6.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb6.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb6.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb6.GetComponent<LimbBehaviour>().VitalParts = new Bounds[] {
new Bounds(new Vector3(-0.05833337f,-0.0851852f,-2f),new Vector3(0.146183f,0.07013963f,1f)),
};
  Limb6.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb6.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb6.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb6.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb7 = person.Limbs[6].gameObject;
  Limb7.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin7.png");
  Limb7.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh7.png").texture);
  Limb7.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone7.png").texture);
  Limb7.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage7.png").texture);
  Limb7.transform.localPosition = new Vector3(-0.6002575f, 0.05607348f, 0.1f);
  Limb7.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb7.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Torso;
  Limb7.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
  Limb7.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb7.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb7.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb7.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb7.GetComponent<LimbBehaviour>().Health = 50f;
  Limb7.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb7.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb7.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb7.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb7.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb7.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb7.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb7.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb8 = person.Limbs[7].gameObject;
  Limb8.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin8.png");
  Limb8.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh8.png").texture);
  Limb8.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone8.png").texture);
  Limb8.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage8.png").texture);
  Limb8.transform.localPosition = new Vector3(-0.742097f, 0.05690418f, 0.1f);
  Limb8.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb8.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Torso;
  Limb8.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
  Limb8.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb8.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb8.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb8.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb8.GetComponent<LimbBehaviour>().Health = 50f;
  Limb8.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb8.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb8.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb8.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb8.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb8.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb8.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb8.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb9 = person.Limbs[8].gameObject;
  Limb9.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin9.png");
  Limb9.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh9.png").texture);
  Limb9.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone9.png").texture);
  Limb9.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage9.png").texture);
  Limb9.transform.localPosition = new Vector3(0.1512663f, -0.1332117f, -0.1f);
  Limb9.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb9.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb9.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
  Limb9.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb9.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb9.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb9.GetComponent<LimbBehaviour>().InitialHealth = 20f;
  Limb9.GetComponent<LimbBehaviour>().Health = 20f;
  Limb9.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb9.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb9.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb9.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb9.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb9.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb9.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb9.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb10 = person.Limbs[9].gameObject;
  Limb10.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin10.png");
  Limb10.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh10.png").texture);
  Limb10.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone10.png").texture);
  Limb10.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage10.png").texture);
  Limb10.transform.localPosition = new Vector3(0.1517185f, -0.3605842f, -0.1f);
  Limb10.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb10.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb10.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
  Limb10.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb10.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb10.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb10.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb10.GetComponent<LimbBehaviour>().Health = 50f;
  Limb10.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb10.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb10.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb10.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb10.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb10.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb10.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb10.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb11 = person.Limbs[10].gameObject;
  Limb11.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin11.png");
  Limb11.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh11.png").texture);
  Limb11.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone11.png").texture);
  Limb11.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage11.png").texture);
  Limb11.transform.localPosition = new Vector3(0.1522451f, -0.3609444f, -0.1f);
  Limb11.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb11.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb11.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
  Limb11.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb11.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb11.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb11.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb11.GetComponent<LimbBehaviour>().Health = 50f;
  Limb11.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb11.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb11.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb11.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb11.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb11.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb11.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb11.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb12 = person.Limbs[11].gameObject;
  Limb12.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin12.png");
  Limb12.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh12.png").texture);
  Limb12.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone12.png").texture);
  Limb12.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage12.png").texture);
  Limb12.transform.localPosition = new Vector3(-0.3f, -0.1124339f, -0.1f);
  Limb12.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb12.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb12.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
  Limb12.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb12.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb12.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb12.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb12.GetComponent<LimbBehaviour>().Health = 50f;
  Limb12.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb12.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb12.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb12.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb12.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb12.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb12.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb12.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb13 = person.Limbs[12].gameObject;
  Limb13.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin13.png");
  Limb13.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh13.png").texture);
  Limb13.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone13.png").texture);
  Limb13.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage13.png").texture);
  Limb13.transform.localPosition = new Vector3(-0.3562169f, -0.3145503f, -0.1f);
  Limb13.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb13.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb13.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
  Limb13.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb13.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb13.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb13.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb13.GetComponent<LimbBehaviour>().Health = 50f;
  Limb13.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb13.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb13.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb13.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb13.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb13.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb13.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb13.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb14 = person.Limbs[13].gameObject;
  Limb14.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin14.png");
  Limb14.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh14.png").texture);
  Limb14.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone14.png").texture);
  Limb14.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage14.png").texture);
  Limb14.transform.localPosition = new Vector3(-0.356217f, -0.3186508f, -0.1f);
  Limb14.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb14.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb14.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
  Limb14.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb14.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb14.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb14.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb14.GetComponent<LimbBehaviour>().Health = 50f;
  Limb14.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb14.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb14.GetComponent<LimbBehaviour>().Vitality = 5f;
  Limb14.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb14.GetComponent<CirculationBehaviour>().IsPump = true;
  Limb14.GetComponent<LimbBehaviour>().HasLungs = true;
  Limb14.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb14.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb15 = Instantiate<GameObject>(person.Limbs[13].gameObject, person.Limbs[13].transform.parent);
  var limbos15 = person.Limbs.ToList();
  limbos15.Add(Limb15.GetComponent<LimbBehaviour>());
  person.Limbs = limbos15.ToArray();
  GameObject.Destroy(Limb15.GetComponent<HingeJoint2D>());
  Limb15.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin15.png");
  Limb15.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh15.png").texture);
  Limb15.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone15.png").texture);
  Limb15.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage15.png").texture);
  Limb15.transform.localPosition = new Vector3(0.1526396f, -0.3594591f, 0.1f);
  Limb15.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb15.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb15.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
  Limb15.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb15.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb15.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb15.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb15.GetComponent<LimbBehaviour>().Health = 50f;
  Limb15.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb15.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb15.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb15.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb15.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb15.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb15.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb15.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb16 = Instantiate<GameObject>(person.Limbs[13].gameObject, person.Limbs[13].transform.parent);
  var limbos16 = person.Limbs.ToList();
  limbos16.Add(Limb16.GetComponent<LimbBehaviour>());
  person.Limbs = limbos16.ToArray();
  GameObject.Destroy(Limb16.GetComponent<HingeJoint2D>());
  Limb16.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin16.png");
  Limb16.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh16.png").texture);
  Limb16.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone16.png").texture);
  Limb16.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage16.png").texture);
  Limb16.transform.localPosition = new Vector3(0.1506614f, -0.134127f, 0.1f);
  Limb16.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb16.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb16.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
  Limb16.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb16.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb16.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb16.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb16.GetComponent<LimbBehaviour>().Health = 50f;
  Limb16.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb16.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb16.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb16.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb16.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb16.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb16.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb16.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb17 = Instantiate<GameObject>(person.Limbs[13].gameObject, person.Limbs[13].transform.parent);
  var limbos17 = person.Limbs.ToList();
  limbos17.Add(Limb17.GetComponent<LimbBehaviour>());
  person.Limbs = limbos17.ToArray();
  GameObject.Destroy(Limb17.GetComponent<HingeJoint2D>());
  Limb17.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin17.png");
  Limb17.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh17.png").texture);
  Limb17.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone17.png").texture);
  Limb17.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage17.png").texture);
  Limb17.transform.localPosition = new Vector3(0.1504165f, -0.3590194f, 0.1f);
  Limb17.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb17.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Legs;
  Limb17.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
  Limb17.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb17.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb17.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb17.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb17.GetComponent<LimbBehaviour>().Health = 50f;
  Limb17.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb17.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb17.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb17.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb17.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb17.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb17.GetComponent<LimbBehaviour>().IsLethalToBreak = false;
  Limb17.GetComponent<LimbBehaviour>().HasBrain = false;
  GameObject Limb18 = Instantiate<GameObject>(person.Limbs[13].gameObject, person.Limbs[13].transform.parent);
  var limbos18 = person.Limbs.ToList();
  limbos18.Add(Limb18.GetComponent<LimbBehaviour>());
  person.Limbs = limbos18.ToArray();
  GameObject.Destroy(Limb18.GetComponent<HingeJoint2D>());
  Limb18.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin18.png");
  Limb18.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh18.png").texture);
  Limb18.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone18.png").texture);
  Limb18.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage18.png").texture);
  Limb18.transform.localPosition = new Vector3(-0.3571429f, -0.3142857f, 0f);
  Limb18.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb18.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb18.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb18.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb18.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb18.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb18.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb18.GetComponent<LimbBehaviour>().Health = 50f;
  Limb18.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb18.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb18.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb18.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb18.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb18.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb18.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb18.GetComponent<LimbBehaviour>().HasBrain = true;
  GameObject Limb19 = Instantiate<GameObject>(person.Limbs[13].gameObject, person.Limbs[13].transform.parent);
  var limbos19 = person.Limbs.ToList();
  limbos19.Add(Limb19.GetComponent<LimbBehaviour>());
  person.Limbs = limbos19.ToArray();
  GameObject.Destroy(Limb19.GetComponent<HingeJoint2D>());
  Limb19.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin19.png");
  Limb19.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh19.png").texture);
  Limb19.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone19.png").texture);
  Limb19.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage19.png").texture);
  Limb19.transform.localPosition = new Vector3(-0.3571429f, -0.3142857f, 0f);
  Limb19.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb19.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb19.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb19.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb19.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb19.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb19.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb19.GetComponent<LimbBehaviour>().Health = 50f;
  Limb19.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb19.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb19.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb19.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb19.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb19.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb19.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb19.GetComponent<LimbBehaviour>().HasBrain = true;
  GameObject Limb20 = Instantiate<GameObject>(person.Limbs[13].gameObject, person.Limbs[13].transform.parent);
  var limbos20 = person.Limbs.ToList();
  limbos20.Add(Limb20.GetComponent<LimbBehaviour>());
  person.Limbs = limbos20.ToArray();
  GameObject.Destroy(Limb20.GetComponent<HingeJoint2D>());
  Limb20.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("LimbSpriteSkin20.png");
  Limb20.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadSprite("LimbSpriteFlesh20.png").texture);
  Limb20.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadSprite("LimbSpriteBone20.png").texture);
  Limb20.GetComponent<SpriteRenderer>().material.SetTexture("_DamageTex", ModAPI.LoadSprite("LimbSpriteDamage20.png").texture);
  Limb20.transform.localPosition = new Vector3(-0.3f, -0.1142857f, 0f);
  Limb20.transform.eulerAngles = new Vector3(0f, 0f, 0f) * Mathf.Sign(person.transform.localScale.x);
  Limb20.GetComponent<LimbBehaviour>().RoughClassification = LimbBehaviour.BodyPart.Head;
  Limb20.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
  Limb20.GetComponent<SpriteRenderer>().sortingOrder = 0;
  Limb20.GetComponent<LimbBehaviour>().BaseStrength = 8.5f;
  Limb20.GetComponent<LimbBehaviour>().BloodMuscleStrengthRatio = 1f;
  Limb20.GetComponent<LimbBehaviour>().InitialHealth = 50f;
  Limb20.GetComponent<LimbBehaviour>().Health = 50f;
  Limb20.GetComponent<LimbBehaviour>().FakeUprightForce = 0.005f;
  Limb20.GetComponent<LimbBehaviour>().BreakingThreshold = 4f;
  Limb20.GetComponent<LimbBehaviour>().Vitality = 2f;
  Limb20.GetComponent<LimbBehaviour>().VitalParts = null;
  Limb20.GetComponent<CirculationBehaviour>().IsPump = false;
  Limb20.GetComponent<LimbBehaviour>().HasLungs = false;
  Limb20.GetComponent<LimbBehaviour>().IsLethalToBreak = true;
  Limb20.GetComponent<LimbBehaviour>().HasBrain = true;
  int limbCount = 20;

  Limb1.GetComponent<GoreStringBehaviour>().Other = Limb3.GetComponent<Rigidbody2D>();
  var Limb1Joint = Limb1.GetComponent<LimbBehaviour>().Joint;
  Limb1Joint.anchor = new Vector2(0.02113336f, -0.06674711f);
  Limb1Joint.autoConfigureConnectedAnchor = true;  Limb1Joint.connectedBody = Limb3.GetComponent<Rigidbody2D>();
  var lim1 = Limb1Joint.limits;
lim1.min = 89.37042f;
lim1.max = -2.526097f;
Limb1Joint.limits = lim1;
  Limb1.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb4.GetComponent<ConnectedNodeBehaviour>(),
       Limb2.GetComponent<ConnectedNodeBehaviour>(),
       Limb3.GetComponent<ConnectedNodeBehaviour>(),
       Limb5.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb1.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb4.GetComponent<CirculationBehaviour>(),
       Limb2.GetComponent<CirculationBehaviour>(),
       Limb3.GetComponent<CirculationBehaviour>(),
       Limb5.GetComponent<CirculationBehaviour>(),
   };
  Limb1.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb4.GetComponent<LimbBehaviour>(),
       Limb2.GetComponent<LimbBehaviour>(),
       Limb3.GetComponent<LimbBehaviour>(),
       Limb5.GetComponent<LimbBehaviour>(),
   };
  Limb1.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb4.GetComponent<SkinMaterialHandler>(),
       Limb2.GetComponent<SkinMaterialHandler>(),
       Limb3.GetComponent<SkinMaterialHandler>(),
       Limb5.GetComponent<SkinMaterialHandler>(),
   };
  Limb1Joint.useLimits = true;
  Limb2.GetComponent<GoreStringBehaviour>().Other = Limb1.GetComponent<Rigidbody2D>();
  var Limb2Joint = Limb2.GetComponent<LimbBehaviour>().Joint;
  Limb2Joint.anchor = new Vector2(-0.03112853f, 0.008867174f);
  Limb2Joint.autoConfigureConnectedAnchor = true;  Limb2Joint.connectedBody = Limb1.GetComponent<Rigidbody2D>();
  var lim2 = Limb2Joint.limits;
lim2.min = 0f;
lim2.max = -90.92402f;
Limb2Joint.limits = lim2;
  Limb2.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb1.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb2.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb1.GetComponent<CirculationBehaviour>(),
   };
  Limb2.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb1.GetComponent<LimbBehaviour>(),
   };
  Limb2.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb1.GetComponent<SkinMaterialHandler>(),
   };
  Limb2Joint.useLimits = true;
  Limb4.GetComponent<GoreStringBehaviour>().Other = Limb1.GetComponent<Rigidbody2D>();
  var Limb4Joint = Limb4.GetComponent<LimbBehaviour>().Joint;
  Limb4Joint.anchor = new Vector2(-0.03148136f, -0.03611112f);
  Limb4Joint.autoConfigureConnectedAnchor = true;  Limb4Joint.connectedBody = Limb1.GetComponent<Rigidbody2D>();
  var lim4 = Limb4Joint.limits;
lim4.min = 0f;
lim4.max = 179.2151f;
Limb4Joint.limits = lim4;
  Limb4.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb1.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb4.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb1.GetComponent<CirculationBehaviour>(),
   };
  Limb4.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb1.GetComponent<LimbBehaviour>(),
   };
  Limb4.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb1.GetComponent<SkinMaterialHandler>(),
   };
  Limb4Joint.useLimits = true;
  Limb5.GetComponent<GoreStringBehaviour>().Other = Limb1.GetComponent<Rigidbody2D>();
  var Limb5Joint = Limb5.GetComponent<LimbBehaviour>().Joint;
  Limb5Joint.anchor = new Vector2(0.06111117f, -0.03055558f);
  Limb5Joint.autoConfigureConnectedAnchor = true;  Limb5Joint.connectedBody = Limb1.GetComponent<Rigidbody2D>();
  var lim5 = Limb5Joint.limits;
lim5.min = -20.90798f;
lim5.max = 65.97349f;
Limb5Joint.limits = lim5;
  Limb5.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb1.GetComponent<ConnectedNodeBehaviour>(),
       Limb7.GetComponent<ConnectedNodeBehaviour>(),
       Limb9.GetComponent<ConnectedNodeBehaviour>(),
       Limb12.GetComponent<ConnectedNodeBehaviour>(),
       Limb6.GetComponent<ConnectedNodeBehaviour>(),
       Limb16.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb5.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb1.GetComponent<CirculationBehaviour>(),
       Limb7.GetComponent<CirculationBehaviour>(),
       Limb9.GetComponent<CirculationBehaviour>(),
       Limb12.GetComponent<CirculationBehaviour>(),
       Limb6.GetComponent<CirculationBehaviour>(),
       Limb16.GetComponent<CirculationBehaviour>(),
   };
  Limb5.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb1.GetComponent<LimbBehaviour>(),
       Limb7.GetComponent<LimbBehaviour>(),
       Limb9.GetComponent<LimbBehaviour>(),
       Limb12.GetComponent<LimbBehaviour>(),
       Limb6.GetComponent<LimbBehaviour>(),
       Limb16.GetComponent<LimbBehaviour>(),
   };
  Limb5.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb1.GetComponent<SkinMaterialHandler>(),
       Limb7.GetComponent<SkinMaterialHandler>(),
       Limb9.GetComponent<SkinMaterialHandler>(),
       Limb12.GetComponent<SkinMaterialHandler>(),
       Limb6.GetComponent<SkinMaterialHandler>(),
       Limb16.GetComponent<SkinMaterialHandler>(),
   };
  Limb5Joint.useLimits = true;
  Limb6.GetComponent<GoreStringBehaviour>().Other = Limb20.GetComponent<Rigidbody2D>();
  var Limb6Joint = Limb6.GetComponent<LimbBehaviour>().Joint;
  Limb6Joint.anchor = new Vector2(0.09421584f, -0.01316689f);
  Limb6Joint.autoConfigureConnectedAnchor = true;  Limb6Joint.connectedBody = Limb20.GetComponent<Rigidbody2D>();
  var lim6 = Limb6Joint.limits;
lim6.min = 0f;
lim6.max = 90f;
Limb6Joint.limits = lim6;
  Limb6.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb5.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb6.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb5.GetComponent<CirculationBehaviour>(),
   };
  Limb6.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb5.GetComponent<LimbBehaviour>(),
   };
  Limb6.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb5.GetComponent<SkinMaterialHandler>(),
   };
  Limb6Joint.useLimits = true;
  Limb7.GetComponent<GoreStringBehaviour>().Other = Limb8.GetComponent<Rigidbody2D>();
  var Limb7Joint = Limb7.GetComponent<LimbBehaviour>().Joint;
  Limb7Joint.anchor = new Vector2(0.05143231f, 0.0132591f);
  Limb7Joint.autoConfigureConnectedAnchor = true;  Limb7Joint.connectedBody = Limb8.GetComponent<Rigidbody2D>();
  var lim7 = Limb7Joint.limits;
lim7.min = 0f;
lim7.max = 90f;
Limb7Joint.limits = lim7;
  Limb7.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb8.GetComponent<ConnectedNodeBehaviour>(),
       Limb5.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb7.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb8.GetComponent<CirculationBehaviour>(),
       Limb5.GetComponent<CirculationBehaviour>(),
   };
  Limb7.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb8.GetComponent<LimbBehaviour>(),
       Limb5.GetComponent<LimbBehaviour>(),
   };
  Limb7.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb8.GetComponent<SkinMaterialHandler>(),
       Limb5.GetComponent<SkinMaterialHandler>(),
   };
  Limb7Joint.useLimits = true;
  GameObject.Destroy(Limb8.GetComponent<LimbBehaviour>().Joint);
  Limb8.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb8.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb7.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb8.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb7.GetComponent<CirculationBehaviour>(),
   };
  Limb8.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb7.GetComponent<LimbBehaviour>(),
   };
  Limb8.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb7.GetComponent<SkinMaterialHandler>(),
   };
  Limb8Joint.useLimits = true;
  Limb9.GetComponent<GoreStringBehaviour>().Other = Limb16.GetComponent<Rigidbody2D>();
  var Limb9Joint = Limb9.GetComponent<LimbBehaviour>().Joint;
  Limb9Joint.anchor = new Vector2(-0.1180957f, 0.1154129f);
  Limb9Joint.autoConfigureConnectedAnchor = true;  Limb9Joint.connectedBody = Limb16.GetComponent<Rigidbody2D>();
  var lim9 = Limb9Joint.limits;
lim9.min = 0f;
lim9.max = 90f;
Limb9Joint.limits = lim9;
  Limb9.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb10.GetComponent<ConnectedNodeBehaviour>(),
       Limb5.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb9.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb10.GetComponent<CirculationBehaviour>(),
       Limb5.GetComponent<CirculationBehaviour>(),
   };
  Limb9.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb10.GetComponent<LimbBehaviour>(),
       Limb5.GetComponent<LimbBehaviour>(),
   };
  Limb9.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb10.GetComponent<SkinMaterialHandler>(),
       Limb5.GetComponent<SkinMaterialHandler>(),
   };
  Limb9Joint.useLimits = true;
  GameObject.Destroy(Limb10.GetComponent<LimbBehaviour>().Joint);
  Limb10.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb10.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb11.GetComponent<ConnectedNodeBehaviour>(),
       Limb9.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb10.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb11.GetComponent<CirculationBehaviour>(),
       Limb9.GetComponent<CirculationBehaviour>(),
   };
  Limb10.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb11.GetComponent<LimbBehaviour>(),
       Limb9.GetComponent<LimbBehaviour>(),
   };
  Limb10.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb11.GetComponent<SkinMaterialHandler>(),
       Limb9.GetComponent<SkinMaterialHandler>(),
   };
  Limb10Joint.useLimits = true;
  GameObject.Destroy(Limb11.GetComponent<LimbBehaviour>().Joint);
  Limb11.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb11.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb10.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb11.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb10.GetComponent<CirculationBehaviour>(),
   };
  Limb11.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb10.GetComponent<LimbBehaviour>(),
   };
  Limb11.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb10.GetComponent<SkinMaterialHandler>(),
   };
  Limb11Joint.useLimits = true;
  Limb12.GetComponent<GoreStringBehaviour>().Other = Limb7.GetComponent<Rigidbody2D>();
  var Limb12Joint = Limb12.GetComponent<LimbBehaviour>().Joint;
  Limb12Joint.anchor = new Vector2(0.07453576f, 0.169512f);
  Limb12Joint.autoConfigureConnectedAnchor = true;  Limb12Joint.connectedBody = Limb7.GetComponent<Rigidbody2D>();
  var lim12 = Limb12Joint.limits;
lim12.min = 0f;
lim12.max = 90f;
Limb12Joint.limits = lim12;
  Limb12.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb20.GetComponent<ConnectedNodeBehaviour>(),
       Limb5.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb12.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb20.GetComponent<CirculationBehaviour>(),
       Limb5.GetComponent<CirculationBehaviour>(),
   };
  Limb12.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb20.GetComponent<LimbBehaviour>(),
       Limb5.GetComponent<LimbBehaviour>(),
   };
  Limb12.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb20.GetComponent<SkinMaterialHandler>(),
       Limb5.GetComponent<SkinMaterialHandler>(),
   };
  Limb12Joint.useLimits = true;
  GameObject.Destroy(Limb13.GetComponent<LimbBehaviour>().Joint);
  Limb13.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb13.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb14.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb13.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb14.GetComponent<CirculationBehaviour>(),
   };
  Limb13.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb14.GetComponent<LimbBehaviour>(),
   };
  Limb13.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb14.GetComponent<SkinMaterialHandler>(),
   };
  Limb13Joint.useLimits = true;
  GameObject.Destroy(Limb14.GetComponent<LimbBehaviour>().Joint);
  Limb14.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb14.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb13.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb14.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb13.GetComponent<CirculationBehaviour>(),
   };
  Limb14.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb13.GetComponent<LimbBehaviour>(),
   };
  Limb14.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb13.GetComponent<SkinMaterialHandler>(),
   };
  Limb14Joint.useLimits = true;
  Limb15.GetComponent<LimbBehaviour>().Joint = Limb15.AddComponent<HingeJoint2D>();
  Limb15.GetComponent<LimbBehaviour>().HasJoint = true;
  Limb15.GetComponent<GoreStringBehaviour>().Other = Limb17.GetComponent<Rigidbody2D>();
  var Limb15Joint = Limb15.GetComponent<LimbBehaviour>().Joint;
  Limb15Joint.anchor = new Vector2(-0.05368876f, -0.002528116f);
  Limb15Joint.autoConfigureConnectedAnchor = true;  Limb15Joint.connectedBody = Limb17.GetComponent<Rigidbody2D>();
  var lim15 = Limb15Joint.limits;
lim15.min = 0f;
lim15.max = 90f;
Limb15Joint.limits = lim15;
  Limb15.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb17.GetComponent<ConnectedNodeBehaviour>(),
       Limb16.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb15.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb17.GetComponent<CirculationBehaviour>(),
       Limb16.GetComponent<CirculationBehaviour>(),
   };
  Limb15.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb17.GetComponent<LimbBehaviour>(),
       Limb16.GetComponent<LimbBehaviour>(),
   };
  Limb15.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb17.GetComponent<SkinMaterialHandler>(),
       Limb16.GetComponent<SkinMaterialHandler>(),
   };
  Limb15Joint.useLimits = true;
  Limb16.GetComponent<LimbBehaviour>().Joint = Limb16.AddComponent<HingeJoint2D>();
  Limb16.GetComponent<LimbBehaviour>().HasJoint = true;
  Limb16.GetComponent<GoreStringBehaviour>().Other = Limb15.GetComponent<Rigidbody2D>();
  var Limb16Joint = Limb16.GetComponent<LimbBehaviour>().Joint;
  Limb16Joint.anchor = new Vector2(-0.05042458f, 0.0401502f);
  Limb16Joint.autoConfigureConnectedAnchor = true;  Limb16Joint.connectedBody = Limb15.GetComponent<Rigidbody2D>();
  var lim16 = Limb16Joint.limits;
lim16.min = 0f;
lim16.max = 90f;
Limb16Joint.limits = lim16;
  Limb16.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb15.GetComponent<ConnectedNodeBehaviour>(),
       Limb5.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb16.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb15.GetComponent<CirculationBehaviour>(),
       Limb5.GetComponent<CirculationBehaviour>(),
   };
  Limb16.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb15.GetComponent<LimbBehaviour>(),
       Limb5.GetComponent<LimbBehaviour>(),
   };
  Limb16.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb15.GetComponent<SkinMaterialHandler>(),
       Limb5.GetComponent<SkinMaterialHandler>(),
   };
  Limb16Joint.useLimits = true;
  GameObject.Destroy(Limb17.GetComponent<LimbBehaviour>().Joint);
  Limb17.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb17.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb15.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb17.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb15.GetComponent<CirculationBehaviour>(),
   };
  Limb17.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb15.GetComponent<LimbBehaviour>(),
   };
  Limb17.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb15.GetComponent<SkinMaterialHandler>(),
   };
  Limb17Joint.useLimits = true;
  Limb18.GetComponent<LimbBehaviour>().Joint = Limb18.AddComponent<HingeJoint2D>();
  Limb18.GetComponent<LimbBehaviour>().HasJoint = true;
  Limb18.GetComponent<GoreStringBehaviour>().Other = Limb19.GetComponent<Rigidbody2D>();
  var Limb18Joint = Limb18.GetComponent<LimbBehaviour>().Joint;
  Limb18Joint.anchor = new Vector2(-0.05574083f, -0.03463525f);
  Limb18Joint.autoConfigureConnectedAnchor = true;  Limb18Joint.connectedBody = Limb19.GetComponent<Rigidbody2D>();
  var lim18 = Limb18Joint.limits;
lim18.min = 0f;
lim18.max = 90f;
Limb18Joint.limits = lim18;
  Limb18.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb19.GetComponent<ConnectedNodeBehaviour>(),
       Limb20.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb18.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb19.GetComponent<CirculationBehaviour>(),
       Limb20.GetComponent<CirculationBehaviour>(),
   };
  Limb18.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb19.GetComponent<LimbBehaviour>(),
       Limb20.GetComponent<LimbBehaviour>(),
   };
  Limb18.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb19.GetComponent<SkinMaterialHandler>(),
       Limb20.GetComponent<SkinMaterialHandler>(),
   };
  Limb18Joint.useLimits = true;
  GameObject.Destroy(Limb19.GetComponent<LimbBehaviour>().Joint);
  Limb19.GetComponent<LimbBehaviour>().HasJoint = false;
  Limb19.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb18.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb19.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb18.GetComponent<CirculationBehaviour>(),
   };
  Limb19.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb18.GetComponent<LimbBehaviour>(),
   };
  Limb19.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb18.GetComponent<SkinMaterialHandler>(),
   };
  Limb19Joint.useLimits = true;
  Limb20.GetComponent<LimbBehaviour>().Joint = Limb20.AddComponent<HingeJoint2D>();
  Limb20.GetComponent<LimbBehaviour>().HasJoint = true;
  Limb20.GetComponent<GoreStringBehaviour>().Other = Limb18.GetComponent<Rigidbody2D>();
  var Limb20Joint = Limb20.GetComponent<LimbBehaviour>().Joint;
  Limb20Joint.anchor = new Vector2(-0.03417873f, 0.0912405f);
  Limb20Joint.autoConfigureConnectedAnchor = true;  Limb20Joint.connectedBody = Limb18.GetComponent<Rigidbody2D>();
  var lim20 = Limb20Joint.limits;
lim20.min = 0f;
lim20.max = 90f;
Limb20Joint.limits = lim20;
  Limb20.GetComponent<ConnectedNodeBehaviour>().Connections = new ConnectedNodeBehaviour[]{
       Limb18.GetComponent<ConnectedNodeBehaviour>(),
       Limb12.GetComponent<ConnectedNodeBehaviour>(),
   };
  Limb20.GetComponent<CirculationBehaviour>().PushesTo = new CirculationBehaviour[]{
       Limb18.GetComponent<CirculationBehaviour>(),
       Limb12.GetComponent<CirculationBehaviour>(),
   };
  Limb20.GetComponent<LimbBehaviour>().ConnectedLimbs = new List<LimbBehaviour>(){
       Limb18.GetComponent<LimbBehaviour>(),
       Limb12.GetComponent<LimbBehaviour>(),
   };
  Limb20.GetComponent<SkinMaterialHandler>().adjacentLimbs = new SkinMaterialHandler[]{
       Limb18.GetComponent<SkinMaterialHandler>(),
       Limb12.GetComponent<SkinMaterialHandler>(),
   };
  Limb20Joint.useLimits = true;


			for(int i = limbCount; i < person.Limbs.Length; i++)
            {
				person.Limbs[i].PhysicalBehaviour.Disintegrate();
			}

			foreach (var Limb in person.Limbs)
			{
				Limb.gameObject.FixColliders();
			}
			var nocol = Instance.AddComponent<NoCollide>();
			nocol.NoCollideSetA = Instance.GetComponentsInChildren<Collider2D>();
			nocol.NoCollideSetB = Instance.GetComponentsInChildren<Collider2D>();

			person.LinkedPoses[PoseState.Rest].Angles = new List<RagdollPose.LimbPose>();
			foreach (var limb in person.Limbs)
			{
				if (limb != null && !limb.PhysicalBehaviour.isDisintegrated && limb.HasJoint)
                {
					person.LinkedPoses[PoseState.Rest].Angles.Add(new RagdollPose.LimbPose(limb, limb.Joint.jointAngle + (limb.transform.eulerAngles.z - limb.Joint.connectedBody.transform.eulerAngles.z) * Mathf.Sign(person.transform.localScale.x)));
				}
			}
			person.LinkedPoses[PoseState.Rest].ConstructDictionary();

			person.LinkedPoses[PoseState.Protective].Angles = new List<RagdollPose.LimbPose>();
			foreach (var limb in person.Limbs)
			{
				if (limb != null && !limb.PhysicalBehaviour.isDisintegrated && limb.HasJoint)
                {
					person.LinkedPoses[PoseState.Protective].Angles.Add(new RagdollPose.LimbPose(limb, limb.Joint.jointAngle + (limb.transform.eulerAngles.z - limb.Joint.connectedBody.transform.eulerAngles.z) * Mathf.Sign(person.transform.localScale.x)));
				}
			}
			person.LinkedPoses[PoseState.Protective].ConstructDictionary();

			foreach (var item in person.Limbs)
                        {
                            if(item.RoughClassification == LimbBehaviour.BodyPart.Head)
                            {
                                item.NodeBehaviour.IsRoot = true;
                                item.NodeBehaviour.Value = 1000000;
                            }
                            else
                            {
                                item.NodeBehaviour.IsRoot = false;
                                item.NodeBehaviour.Value = 100000;
                            }
                        }

                        foreach (var item in person.Limbs)
                        {
                            if (item.RoughClassification == LimbBehaviour.BodyPart.Head)
                            {
                                item.NodeBehaviour.RootPropagation();
                            }
                        }
		}
	}
);