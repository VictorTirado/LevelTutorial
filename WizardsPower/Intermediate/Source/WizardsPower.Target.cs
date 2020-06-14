using UnrealBuildTool;

public class WizardsPowerTarget : TargetRules
{
	public WizardsPowerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("WizardsPower");
	}
}
