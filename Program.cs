using RelationshipApp1;
using System.Net.Cache;

internal class Program
{
	static void Main(string[] args)
	{
		FamilyMember GrandFatherFirst = new FamilyMember()
		{
			FullName = "Karatayev Kanat Myrzakhanovich",
			Age = 60,
			Gender = Gender.male
		};

		FamilyMember GrandFatherSecond = new FamilyMember()
		{
			FullName = "Aytbayev Mugradim Kamalovich",
			Age = 64,
			Gender = Gender.male
		};

		FamilyMember GrandMotherFirst = new FamilyMember()
		{
			FullName = "Akhtanova Aliya Ibrayevna",
			Age = 57,
			Gender = Gender.female
		};

		FamilyMember GrandMotherSecond = new FamilyMember()
		{
			FullName = "Zhumagulova Adel Iskakovna",
			Age = 58,
			Gender = Gender.female
		};

		FamilyMember Father = new FamilyMember()
		{
			FullName = "Myrzakhanov Altay Kanatovich",
			Age = 35,
			Gender = Gender.male,
			Father= GrandFatherFirst,
			Mother= GrandMotherFirst
		};

		FamilyMember Mother = new FamilyMember()
		{
			FullName = "Kamalova Aysha Mugradimovna",
			Age = 33,
			Gender = Gender.female,
			Father=GrandFatherSecond,
			Mother= GrandMotherSecond
		};

		FamilyMember Son1 = new FamilyMember()
		{
			FullName = "Kanatov Zhengiskhan Altayevich",
			Age = 10,
			Gender = Gender.male,
			Father = Father,
			Mother = Mother
		};

		FamilyMember Daughter = new FamilyMember()
		{
			FullName = "Kanatova Aizhan Altayevna",
			Age = 8,
			Gender = Gender.female,
			Father = Father,
			Mother = Mother
		};

		FamilyMember Son2 = new FamilyMember()
		{
			FullName = "Kanatov Baiyrkhan Altayevich",
			Age = 6,
			Gender = Gender.male,
			Father = Father,
			Mother = Mother
		};

		GrandFatherFirst.AddMyHalf(GrandMotherFirst);
		GrandFatherFirst.AddKids(Father);

		GrandFatherSecond.AddMyHalf(GrandMotherSecond);
		GrandFatherSecond.AddKids(Mother);

		Father.AddKids(Son1, Daughter, Son2);
		Father.AddMyHalf(Mother);

		Father.ShowMyCloseRelatives1();
		Father.ShowMyCloseRelatives2();

		//Mother.AddKids(Son1, Daughter, Son2);
		//Mother.AddMyHalf(Father);

		//Mother.ShowMyCloseRelatives1();
		//Mother.ShowMyCloseRelatives2();

		/*
		var GrandFathers = Son.GetGrandFathersName();
		var GrandMothers = Son.GetGrandMothersName();

		Console.WriteLine(GrandFathers[0]?.FullName);
		Console.WriteLine(GrandMothers[0]?.FullName);
		Console.WriteLine(GrandFathers[1]?.FullName);
		Console.WriteLine(GrandMothers[1]?.FullName);
		*/
	}
}



