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
				sum += number;
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
			if (number % 10 == 4 && number < min)
			{
				min = number;
			}
		}
		cout << min;
	}

	

	void task461()
	{
		int number = 0;
		int kol = 0;
		int length = 0;
		cin >> number;
		while (number != 0)
		{
			++length;
			if (number % 2 != 0 && number % 3 == 0)
			{
				++kol;
			}
			cin >> number;
		}
		cout << length;
		cout << endl;
		cout << kol;

	}

	void task341()
	{
		int number = 0;
		int min1 = INT_MAX;
		int min2 = INT_MAX;
		int max1 = INT_MIN;
		int max2 = INT_MIN;

		cin >> number;
		while (number != 0)
		{
			// max
			if (number > max2 && number <= max1)
			{
				max2 = number;
			}
			if (number > max1)
			{
				max2 = max1;
				max1 = number;
			}

			// min
			if (number >= min1 && number < min2)
			{
				min2 = number;
			}
			if (number < min1)
			{
				min2 = min1;
				min1 = number;
			}

			cin >> number;
		}

		cout << max1 + max2 << endl << min1 + min2;
	}

	void task361()
	{
		int speed = 0;
		double v = 0;
		int maxSpeed = 0;
		int amountOfSlow = 0;
		int amount = 0;
		cin >> amount;

		for (int i = 0; i < amount; i++)
		{
			cin >> v;
			speed = int(v);

			// max
			if (speed > maxSpeed)
			{
				maxSpeed = speed;
			}

			// slow amount
			if (speed < 30)
			{
				++amountOfSlow;
			}
		}

		cout << maxSpeed << endl;
		if (amountOfSlow > 0)
		{
			cout << "YES";
		}
		else
		{
			cout << "NO";
		}
	}

	void task421()
	{
		int speed = 0;
		double sr = 0;
		int amount = 0;
		int sum = 0;
		int avto40 = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> speed;
			sum = sum + speed;

			if (speed <= 40)
			{
				avto40++;
			}
		}
		sr = double(sum) / amount;
		cout << sr;
		cout << endl;
		if (avto40 >= 2)
		{
			cout << "YES";
		}
		else
		{
			cout << "NO";
		}
	}

	void task441()
	{
		int speed = 0;
		int max = 0;
		int min = 300;
		int raznost = 0;
		int amount = 0;
		int avto30 = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> speed;

			if (speed > max)
			{
				max = speed;
			}
			if (speed < min)
			{
				min = speed;
			}
			if (speed <= 30)
			{
				avto30++;
			}
		}
		raznost = max - min;
		cout << raznost;
		cout << endl;
		cout << avto30;
	}

	void task481()
	{
		int number = 0;
		int sum = 0;
		int kol = 0;
		cin >> number;
		while (number != 0)
		{
			sum = sum + number;
			if (number % 2 == 0 && number % 5 == 0)
			{
				kol++;
			}
			cin >> number;
		}
		cout << sum;
		cout << endl;
		cout << kol;
	}
}