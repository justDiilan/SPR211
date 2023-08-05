#pragma once
#include <string>
#include <ctime>
using namespace std;
class PrintRequest
{
public:
    string user;
    int priority;
    time_t timestamp;

    PrintRequest();
    PrintRequest(const string& user, int priority) : user(user), priority(priority), timestamp(time(0)) {}
};

