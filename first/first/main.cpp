#include <iostream>
#include "introduction.h"
#include "combinatorics.h"
#include "myMath.h"
#include "oge.h"
#include "massiv.h"
#include "sequence.h"

using namespace std;

int main()
{
	cout << 1 * 1 << " ";
	cout << 2 * 2 << " ";
	cout << 3 * 3 << " ";
	cout << 4 * 4 << " ";
	cout << 5 * 5 << " ";

	cout << endl;

	int i = 1;
	while (i <= 5)
	{
		cout << i * i << " ";
		++i;
	}
<<<<<<< HEAD
	sequence::task20();
=======
	cout << endl;

>>>>>>> parent of 08695f4... dz
	return 0;
}