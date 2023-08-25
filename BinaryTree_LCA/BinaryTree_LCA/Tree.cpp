#include "Tree.h"
template<class T>
Tree<T>::Tree() : _root(nullptr) {}

template<class T>
Tree<T>::~Tree()
{
    if (_root != nullptr) delete _root;
}

template<class T>
void Tree<T>::AddIteratively(T data) // ����������� ����� ������
{
    Node* newNode = new Node;
    newNode->data = data;
    newNode->right = nullptr;
    newNode->left = nullptr;

    Node** tmp = &_root;
    while (*tmp != nullptr)
    {
        if (FoundNode(data)) return; // � ������ ��� ���������� ���������
        if (*tmp != nullptr && (*tmp)->data > data) tmp = &(*tmp)->left; // left branch
        if (*tmp != nullptr && (*tmp)->data < data) tmp = &(*tmp)->right; // right branch
    }
    *tmp = newNode;
}

template<class T>
bool Tree<T>::FoundNode(T& data) // �������� ��� ������������
{
    key1 = false;
    return PrivateFoundNode(&_root, data);
}

template<class T>
bool Tree<T>::PrivateFoundNode(Node** root, T& data) // ����������
{
    if ((*root) != nullptr)
    {
        PrivateFoundNode(&(*root)->right, data);
        if ((*root)->data == data) key1 = true;
        PrivateFoundNode(&(*root)->left, data);
    }
    if (key1) return true;
    else return false;
}

template<class T>
void Tree<T>::AddRecursively(T data) // ����������� ����� ������
{
    Node* newNode = new Node;
    newNode->data = data;
    newNode->right = nullptr;
    newNode->left = nullptr;

    AddRecursivelyNode(&_root, &newNode);
}

template<class T>
void Tree<T>::AddRecursivelyNode(Node** root, Node** newNode)
{
    if ((*root) != nullptr)
    {
        if ((*root)->data == (*newNode)->data) return;
        if ((*root)->data > (*newNode)->data) AddRecursivelyNode(&(*root)->right, &(*newNode));
        if ((*root)->data < (*newNode)->data) AddRecursivelyNode(&(*root)->left, &(*newNode));
    }
    else
    {
        *root = (*newNode); // �������� ����� Node
    }
}

template<class T>
void Tree<T>::DisplayMaxMin()
{
    DisplayRecursivelyMaxMin(&_root);
}

template<class T>
void Tree<T>::DisplayRecursivelyMaxMin(Node** root) // max - min
{
    if ((*root) != nullptr)
    {
        DisplayRecursivelyMaxMin(&(*root)->left);
        cout << (*root)->data << "\t";
        DisplayRecursivelyMaxMin(&(*root)->right);
    }
}

template<class T>
void Tree<T>::DisplayMinMax()
{
    DisplayRecursivelyMinMax(&_root);
}

template<class T>
void Tree<T>::DisplayRecursivelyMinMax(Node** root) // min - max
{
    if ((*root) != nullptr)
    {
        DisplayRecursivelyMinMax(&(*root)->right);
        cout << (*root)->data << "\t";
        DisplayRecursivelyMinMax(&(*root)->left);
    }
}

template<class T>
T& Tree<T>::GetRoot()
{
    return _root->data;
}

template<class T>
T& Tree<T>::LCA(T& data1, T& data2)
{
    /*
        ���� ���������:
        1. ������� ����� �� root � ������� ���� ����� 2 ����
� � � � 2. � ��������� ����� ����� ���� ��� � ��������� ����������
� � � � 3. �� ������ ���� ���� 2 ����
� � � � 4. ���� ����� ����, �� ����� ���������, � ���������� ���������� � TMP
� � � � 5. ���� ���� �� ������ ���� ��� � ������� ����, ������ ���������� LCA
    */
    if (data1 == data2) return _root->data; // LCA root
    if (data1 > _root->data && data2 < _root->data) return _root->data; // LCA root
    if (data1 < _root->data && data2 > _root->data) return _root->data; // LCA root
    if (data1 == _root->data || data2 == _root->data) return _root->data; // LCA root

    Node** tmpRoot = &_root;
    Node* LCA = nullptr;

    while (*tmpRoot != nullptr)
    {
        key1 = false;
        key2 = false;
        if ((*tmpRoot)->data > data1 && (*tmpRoot)->data > data2)
        {
            LCA = *tmpRoot;
            tmpRoot = &(*tmpRoot)->left;
            if ((*tmpRoot)->data == data1 || (*tmpRoot)->data == data2) // LCA previous
                return LCA->data;
            if (!FoundNodes(&(*tmpRoot), data1, data2)) return LCA->data; // ���� �� ������ ������ ���� ��� ������� ���������� LCA
        }
        else if ((*tmpRoot)->data < data1 && (*tmpRoot)->data < data2)
        {
            LCA = *tmpRoot;
            tmpRoot = &(*tmpRoot)->right;
            if ((*tmpRoot)->data == data1 || (*tmpRoot)->data == data2) // LCA previous
                return LCA->data;
            if (!FoundNodes(&(*tmpRoot), data1, data2)) return LCA->data; // ���� �� ������ ������ ���� ��� ������� ���������� LCA
        }
        else // LCA next �������������� �������� ��������� ������ ��������.
        {
            if (LCA->data < data1 && LCA->data < data2)
                return LCA->right->data;
            else
                return LCA->left->data;
            cout << "I'm worked!" << endl;
        }
    }
}

template<class T>
bool Tree<T>::FoundNodes(Node** root, T& data1, T& data2) // ���� 2 ���� ������� ��� true
{
    if ((*root) != nullptr)
    {
        FoundNodes(&(*root)->right, data1, data2);
        if ((*root)->data == data1) key1 = true;
        if ((*root)->data == data2) key2 = true;
        FoundNodes(&(*root)->left, data1, data2);
        cout << "Element:\t" << (*root)->data << endl;
    }
    if (key1 && key2) return true;
    else return false;
}
