using UnrealBuildTool;

public class TillDeathDoUsPartTarget : TargetRules
{
	public TillDeathDoUsPartTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TillDeathDoUsPart");
	}
}
