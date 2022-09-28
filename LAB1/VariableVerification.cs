using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
	internal static class VariableVerification
	{
		static public bool IsStringCorrect(string fCs)
		{
			for(int i = 0; i<fCs.Length; i++)
			{
				if ((fCs[i]>'А' || fCs[i] < 'я' ) && (fCs[i] > 'A' || fCs[i] < 'z' ) || fCs[i] == ' ')
				{
					return true;
				}
			}
			return false;
		}

		static public bool IsAgeCorrect(int age)
		{
			if(age < 0)
			{
				return false;
			}
			return true;
		}

		static public bool IsNumberCorrect(string num)
		{
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < '0' || num[i] > '9')
                {
                    return false;
                }
            }
			return true;
        }

		static public bool CorrectGender(ref string gender)
		{
			if (gender == "Мужской" || gender == "мужской" || gender == "муж" || gender == "Муж" || gender == "м" || gender == "М" || gender == "0")
			{
				gender = "false";
			   return true;
			}
			else if(gender == "Женский" || gender == "женский" || gender == "жен" || gender == "Жен" || gender == "ж" || gender == "Ж" || gender == "1")
			{
				gender = "true";
				return true;
			}
			else
			{
				return false;
			}
		}

		static public bool IsYearCorrect(int year)
		{
			if(year > 2022)
			{
				return false;
			}
			return true;
		}
	}
}
