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
        BuildEnvironment = TargetBuildEnvironment.Unique;
        bUseLoggingInShipping = true;

        GlobalDefinitions.Add("ALLOW_BLUEPRINT_LOGS_IN_SHIPPING=1");
    }
}
