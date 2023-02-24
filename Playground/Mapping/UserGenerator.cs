using System;
using System.Runtime.CompilerServices;

namespace Mapping;

public static class UserGenerator
{
    private static readonly Random _rnd = new Random();
    public static User GenerateRandom()
    {
        return new User(
            _rnd.Next(),
            "John",
            "Doe"
        );
    }
}
