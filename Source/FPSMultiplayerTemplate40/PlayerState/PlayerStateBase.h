// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/PlayerState.h"
#include "PlayerStateBase.generated.h"

/**
 * 
 */
UCLASS()
class FPSMULTIPLAYERTEMPLATE40_API APlayerStateBase : public APlayerState
{
	GENERATED_BODY()
public:
	UFUNCTION(BlueprintCallable)
	void SetOnlinePlayerName(FString strNewName);
};
