#include <iostream>
#include "introduction.h"
#include "combinatorics.h"
#include "myMath.h"
#include "oge.h"

using namespace std;

int main()
{
	int const n = 6;
	int a[n];
	for (int i = 0; i < n; i++)
	{
		cin >> a[i];
	}
	cout << task6(a, n);
	return 0;
}