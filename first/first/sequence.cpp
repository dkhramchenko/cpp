#include "Limits.h"
#include <iostream>

using namespace std;

namespace sequence
{
	int max()
	{
		int number = 0;
		int max = INT_MIN;
		int amount = 0;
		std::cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			std::cin >> number;
			if (number > max)
			{
				max = number;
			}
		}
		return max;
	}

	void task20()
	{
		int number = 0;
		int max = INT_MIN;
		int amount = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> number;
			if (number % 5 == 0 && number > max)
			{
				max = number;
			}
		}
		cout << max;
	}

	void task340()
	{
		int number = 0;
		int sum = 0;
		cin >> number;
		while (number != 0)
		{
			if (number % 6 == 0 && number % 10 == 4)
			{
				sum += number;
			}
			cin >> number;
		}
		cout << sum;
	}

	void task60()
	{
		int number = 0;
		int amount = 0;
		int kol = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> number;
			if (number % 4 == 0)
			{
				kol++;
			}
		}
		cout << kol;
	}
	
	void task100()
	{
		int number = 0;
		int amount = 0;
		int sum = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> number;
			if (number % 3 == 0)
			{
				sum=sum+number;
			}
		}
		cout << sum;
	}

	void task280()
	{
		int number = 0;
		int amount = 0;
		int min = INT_MAX;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> number;
			if (number % 10 == 4 && number<min)
			{
				min=number;
			}
		}
		cout << min;
	}

	void task341()
	{
		int number = 0;
		int sum1 = 0;
		int sum2=0;
		int min1 = INT_MAX;
		int min2 = INT_MAX;
		int max1 = INT_MIN;
		int max2 = INT_MIN;
		cin >> number;
		while (number != 0)
		{
			
				if (number <= max1 && number > max2)
				{
					max2 = number;
				}

			}
			return m2;
		}
		cout << sum;
	}

}