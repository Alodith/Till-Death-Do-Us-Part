using UnrealBuildTool;

public class TillDeathDoUsPart : ModuleRules
{
	public TillDeathDoUsPart(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
