// Fill out your copyright notice in the Description page of Project Settings.


#include "My_Test_Actor.h"

// Sets default values
AMy_Test_Actor::AMy_Test_Actor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AMy_Test_Actor::BeginPlay()
{
	Super::BeginPlay();
	GEngine->AddOnScreenDebugMessage(-1, 5.f, FColor::Red, input);
	
}

// Called every frame
void AMy_Test_Actor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

