// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FPSMultiplayerTemplate40EditorTarget : TargetRules
{
	public FPSMultiplayerTemplate40EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "FPSMultiplayerTemplate40" } );
	}
}
