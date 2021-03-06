// Copyright Allen Institute for Artificial Intelligence 2017
using System;

[Serializable]
public enum SimObjManipType : int {
	Inventory = 0,
	Static = 1,
	Rearrangeable = 2,
	StaticNoPlacement = 3,
}

[Serializable]
public enum SimObjType : int
{
	//undefined is always the first value
	Undefined = 0,
	//ADD NEW VALUES BELOW
	//DO NOT RE-ARRANGE OLDER VALUES
	Apple = 1,
	AppleSlice = 2,
	Tomato = 3,
	TomatoSliced = 4,
	Bread = 5,
	BreadSliced = 6,
	Sink = 7,
	Pot = 8,
	Pan = 9,
	Knife = 10,
	Fork = 11,
	Spoon = 12,
	Bowl = 13,
	Toaster = 14,
	CoffeeMachine = 15,
	Microwave = 16,
	StoveBurner = 17,
	Fridge = 18,
	Cabinet = 19,
	Egg = 20,
	Chair = 21,
	Lettuce = 22,
	Potato = 23,
	Mug = 24,
	Plate = 25,
	TableTop = 26,
	CounterTop = 27,
	GarbageCan = 28,
	Omelette = 29,
	EggShell = 30,
	EggFried = 31,
	StoveKnob = 32,
	Container = 33,
	Cup = 34,
	ButterKnife = 35,
	PotatoSliced = 36,
	MugFilled = 37,
	BowlFilled = 38,
	Statue = 39,
	LettuceSliced = 40,
	ContainerFull = 41,
	BowlDirty = 42,
	Sandwich = 43,
	Television = 44,
	HousePlant = 45,
	TissueBox = 46,
	VacuumCleaner = 47,
	Painting = 48,
	WateringCan = 49,
	Laptop = 50,
	RemoteControl = 51,
	Box = 52,
	Newspaper = 53,
	TissueBoxEmpty = 54,
	PaintingHanger = 55,
	KeyChain = 56,
	Dirt = 57,
	CellPhone = 58,
	CreditCard = 59,
	Cloth = 60,
	Candle = 61,
	Toilet = 62,
	Plunger = 63,
	Bathtub = 64,
	ToiletPaper = 65,
	ToiletPaperHanger = 66,
	SoapBottle = 67,
	SoapBottleFilled = 68,
	SoapBar = 69,
	ShowerDoor = 70,
	SprayBottle = 71,
	ScrubBrush = 72,
	ToiletPaperRoll = 73,
	Lamp = 74,
	LightSwitch = 75,
	Bed = 76,
	Book = 77,
	AlarmClock = 78,
	SportsEquipment = 79,
	Pen = 80,
	Pencil = 81,
	Blinds = 82,
	Mirror = 83,
	TowelHolder = 84,
	Towel = 85,
	Watch = 86,
	MiscTableObject = 87
}
