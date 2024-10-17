using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipApp1
{
	public enum Gender { male, female }
	public class FamilyMember
	{
		private bool screenMaximized = false;
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public string FullName { get; set; }
		public FamilyMember Mother { get; set; }
		public FamilyMember Father { get; set; }
    public FamilyMember MyHalf { get; set; }
		public FamilyMember[] Kids = null;


		public void AddMyHalf(FamilyMember m)
		{
			if (MyHalf == null)
			{
				if (Gender != m.Gender)
				{
					MyHalf = m;
					m.MyHalf = this;
					if (Kids != null && Kids.Length > 0)
						m.Kids = Kids;
				}
			}
		}
		public void AddKids(params FamilyMember[] kids)
		{
			Kids = kids;
			if (MyHalf!=null)
				MyHalf.Kids = Kids;
		}
    public FamilyMember[] GetGrandFathersName()
		{
			return new FamilyMember[] { Father?.Father, Mother?.Father };
		}
		public FamilyMember[] GetGrandMothersName()
		{
			return new FamilyMember[] { Father?.Mother, Mother?.Mother };
		}
		public FamilyMember GetFather()
		{
			return Father;
		}
		public FamilyMember GetMother()
		{
			return Mother;
		}
		public FamilyMember GetMyHalf()
		{
			return MyHalf;
		}
		public FamilyMember[] GetKids()
		{
			return Kids;
		}
		public string GetCountString(int count)
		{
			if (count > 0)
			{
				switch (count)
				{
					case 1: return "First"; break;
					case 2: return "Second";break;
					case 3: return "Third"; break;
					case 4: return "Forth"; break;
					case 5: return "Fifth"; break;
					case 6: return "Sixth"; break;
					case 7: return "Seventh"; break;
					case 8: return "Eighth"; break;
					case 9: return "Ninth"; break;
					case 10: return "Tenth"; break;
					default: return "K-th"; break;
				}
			}
			else
				return "";
		}
		public void ShowMyCloseRelatives1()
		{
			string auxStr = String.Empty;
			int countSons = 1, countDaughters = 1, width, height;

			if (!screenMaximized)
			{
				width = Console.LargestWindowWidth;
				height = Console.LargestWindowHeight;
				Console.SetWindowSize(width, height);
			}

			if (Father != null)
				Console.WriteLine($"My father: {Father.FullName}");
			if (Mother != null)
				Console.WriteLine($"My mother: {Mother.FullName}\n");
			if (MyHalf != null)
			{
				if (MyHalf.Gender == Gender.male)
					auxStr = "husband";
				else
					auxStr = "wife";
				//if (MyHalf.Father != null)
				//	Console.WriteLine($"My {auxStr}'s Father: {MyHalf.Father.FullName}");
				//if (MyHalf.Mother != null)
				//	Console.WriteLine($"My {auxStr}'s Mother: {MyHalf.Mother.FullName}");
				Console.WriteLine($"My {auxStr}: {MyHalf.FullName}");
			}
			Console.WriteLine($"Me: {FullName}\n");
			if (Kids != null && Kids.Length > 0)
			{
				Console.WriteLine("Kids:");
				foreach (var k in Kids)
				{
					if (k.Gender == Gender.male)
						Console.WriteLine($"{GetCountString(countSons++)} son: {k.FullName}");
					else
						Console.WriteLine($"{GetCountString(countDaughters++)} daughter: {k.FullName}");
				}
				Console.WriteLine("\n");
			}
		}
		public void ShowMyCloseRelatives2()
		{
			int c, cl, cr, cll, clr, crl, crr, width, height;
			string mF, mM, hF, hM, m, h;

			if (!screenMaximized)
			{
				width = Console.LargestWindowWidth;
				height = Console.LargestWindowHeight;
				Console.SetWindowSize(width,height);
			}
				


		}
	}
}
