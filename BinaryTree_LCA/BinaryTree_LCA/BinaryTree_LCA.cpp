#include <iostream>
#include "Tree.h"
#include "Tree.cpp"

int main()
{
	Tree<int> tree;
	tree.AddIteratively(8);
	tree.AddIteratively(3);
	tree.AddIteratively(1);
	tree.AddIteratively(0);
	tree.AddIteratively(-1);
	tree.AddIteratively(6);
	tree.AddIteratively(7);
	tree.AddIteratively(4);
	tree.AddIteratively(10);
	tree.AddIteratively(14);
	tree.AddIteratively(13);
	tree.AddIteratively(15);
	tree.AddIteratively(9);

	tree.DisplayMaxMin();
	cout << endl;

	int node1 = 9, node2 = 15;
	cout << "LCA:\t" << tree.LCA(node1, node2) << endl;

	return 0;
}