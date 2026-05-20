// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class character : ModuleRules
{
	public character(ReadOnlyTargetRules Target) : base(Target)
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
			"character",
			"character/Variant_Platforming",
			"character/Variant_Platforming/Animation",
			"character/Variant_Combat",
			"character/Variant_Combat/AI",
			"character/Variant_Combat/Animation",
			"character/Variant_Combat/Gameplay",
			"character/Variant_Combat/Interfaces",
			"character/Variant_Combat/UI",
			"character/Variant_SideScrolling",
			"character/Variant_SideScrolling/AI",
			"character/Variant_SideScrolling/Gameplay",
			"character/Variant_SideScrolling/Interfaces",
			"character/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
