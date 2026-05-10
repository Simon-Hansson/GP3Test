// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GP3Test : ModuleRules
{
	public GP3Test(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GP3Test",
			"GP3Test/Variant_Platforming",
			"GP3Test/Variant_Platforming/Animation",
			"GP3Test/Variant_Combat",
			"GP3Test/Variant_Combat/AI",
			"GP3Test/Variant_Combat/Animation",
			"GP3Test/Variant_Combat/Gameplay",
			"GP3Test/Variant_Combat/Interfaces",
			"GP3Test/Variant_Combat/UI",
			"GP3Test/Variant_SideScrolling",
			"GP3Test/Variant_SideScrolling/AI",
			"GP3Test/Variant_SideScrolling/Gameplay",
			"GP3Test/Variant_SideScrolling/Interfaces",
			"GP3Test/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
