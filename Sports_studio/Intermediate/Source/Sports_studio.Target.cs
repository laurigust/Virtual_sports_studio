using UnrealBuildTool;

public class Sports_studioTarget : TargetRules
{
	public Sports_studioTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Sports_studio");
	}
}
