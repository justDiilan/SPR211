#pragma once
#include <iostream>
#include <stack>
#include <string>

using namespace std;

template<class T>
class Tree
{
public:
	Tree();
	~Tree();
	void AddIteratively(T data);
	void AddRecursively(T data);
	void DisplayMaxMin();
	void DisplayMinMax();
	T& GetRoot();
	T& LCA(T& data1, T& data2);
	bool FoundNode(T& data);
private:
	class Node
	{
	public:
		~Node()
		{
			if (right != nullptr) delete right;
			if (left != nullptr) delete left;
		}
		T data;
		Node* right;
		Node* left;
	};
	Node* _root;
	void AddRecursivelyNode(Node** root, Node** newNode);
	void DisplayRecursivelyMaxMin(Node** root);
	void DisplayRecursivelyMinMax(Node** root);
	bool FoundNodes(Node** root, T& data1, T& data2);
	bool PrivateFoundNode(Node** root, T& data);
	bool key1, key2;
};

