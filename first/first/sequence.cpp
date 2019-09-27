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
}