using System;

string LogMessage(string log, string status, string info)
{
    DateTime today = DateTime.Now;
    string date = today.ToString("yyyy-MM-dd");
    string time = today.ToString("HH:mm:ss");
    string dateTime = $"[{date} {time}]";
    string newStatus = status;
    string newInfo = $"[{info}]";
    return $"{dateTime}{newInfo}{newStatus}";
}

string answer1 = LogMessage("application.log", "User logged in", "INFO");
string answer2 = LogMessage("application.log", "Failed login attempt", "WARNING");

Console.WriteLine("Output: {0}", answer1);
Console.WriteLine("Output: {0}", answer2);

