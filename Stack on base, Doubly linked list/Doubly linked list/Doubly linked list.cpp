#include <iostream>
#include "List.h"
#include "List.cpp"
using namespace std;

template<class T>
void printListOld(Node<T>* node)
{
    while (node != nullptr)
    {
        cout << node->data << endl;
        node = node->next;
    }
}
template<class T>
void printListNew(List<T>& list)
{
    for (size_t i = 0; i < list.getSize(); i++)
    {
        cout << list[i] << "\t";
    }
    cout << endl;
}

int main()
{
    List<int> list;
    list.add(5);
    list.add(3);
    list.add(7);
    list.add(8);
    list.add(10);

    //printList(&list.getHead());
    //insert
    cout << "Befor insert in the list:" << endl;
    printListNew(list);
    list.insert(17, 3);
    cout << "After insert in the list:" << endl;
    printListNew(list);

    //replace
    cout << "Replace: a new data = 15, index = 4" << endl;
    list.replace(15, 4);
    printListNew(list);

    //delete
    cout << "Delete: number 3, index = 1" << endl;
    list.del(1);
    printListNew(list);

    return 0;
}