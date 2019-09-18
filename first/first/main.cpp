#include <iostream>
#include "introduction.h"
#include "combinatorics.h"
#include "myMath.h"
#include "oge.h"

using namespace std;

int main()
{
	int a[5];
	for (int i = 0; i < 5; i++)
	{
		cin >> a[i];
	}
	cout << task1(a, 5);
	return 0;
}