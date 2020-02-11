using Framework.Models;
using GitHubAutomation.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Services
{
    class UserCreator
    {
        public static User WithAllProperties()
        {
            return new User(TestDataReader.GetData("Name"), TestDataReader.GetData("Email"));
        }
        public static User WithAllIncorrectProperties()
        {
            return new User(TestDataReader.GetData("Name"), TestDataReader.GetData("EmailIncorrect"));
        }
        public static User AuthProperties()
        {
            return new User(TestDataReader.GetData("Name"), TestDataReader.GetData("AuthEmail"), TestDataReader.GetData("AuthPassword"));
        }
    }
}
