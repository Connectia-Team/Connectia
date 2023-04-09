// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ConnectiaServerTarget : TargetRules
{
	public ConnectiaServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Connectia" } );
		
		// Doing this will prevent building via engines downloaded with EGS.
		// For now, not to break the building from such engines, we will cherry-pick this commit when we need to build server binaries.
		{
			BuildEnvironment = TargetBuildEnvironment.Unique;
			bUseLoggingInShipping = true;
			// This thing is not in the official repo of Unreal Engine.
			// In order to allow blueprint logs in a shipping server build, 
			// you will also need to add this commit to your engine source:
			// https://github.com/zhmyh1337/UnrealEngine/commit/0bd2c482612a1581d81b58ed52c25704217fda46
			// (obviously, visible only if you are in the github EpicGames organization).
			GlobalDefinitions.Add("ALLOW_BLUEPRINT_LOGS_IN_SHIPPING=1");
		}
    }
}
